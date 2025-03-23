namespace ZeroAlloc.Console.Week4_DistributedSystems;

public static class ShardingSimulation
{
    private const int ShardCount = 4;
    private static readonly Dictionary<int, List<User>> Shards = new();

    public static void Run()
    {
        System.Console.WriteLine("\nDatabase Sharding Simulation with Pagination");

        System.Console.Write("Enter total number of users to simulate: ");
        if (!int.TryParse(System.Console.ReadLine(), out int userCount) || userCount <= 0)
        {
            System.Console.WriteLine("Invalid user count.");
            return;
        }

        for (int i = 0; i < ShardCount; i++)
        {
            Shards[i] = new List<User>();
        }

        for (int userId = 1; userId <= userCount; userId++)
        {
            var shardId = GetShardId(userId);
            Shards[shardId].Add(new User(userId, $"user{userId}@example.com"));
        }

        const int pageSize = 10;
        var totalPages = (int)Math.Ceiling(userCount / (double)pageSize);

        System.Console.Write("Enter page number to view (1 to " + totalPages + "): ");
        if (!int.TryParse(System.Console.ReadLine(), out int pageNumber) || pageNumber < 1 || pageNumber > totalPages)
        {
            System.Console.WriteLine("Invalid page number.");
            return;
        }

        var users = GetPagedUsers(pageNumber, pageSize);

        System.Console.WriteLine();
        System.Console.WriteLine($"Users on page {pageNumber} (Page size = {pageSize}):");
        foreach (var user in users)
        {
            System.Console.WriteLine($"- {user.Id}: {user.Email} (Shard {GetShardId(user.Id)})");
        }
    }

    private static int GetShardId(int userId) => userId % ShardCount;

    private static List<User> GetPagedUsers(int pageNumber, int pageSize)
    {
        var allUsers = Shards.Values.SelectMany(list => list).OrderBy(u => u.Id).ToList();
        return allUsers.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
    }

    private record User(int Id, string Email);
}