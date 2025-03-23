namespace ZeroAlloc.Console.Week4_DistributedSystems;

public static class CQRSExample
{
    public static void Run()
    {
        System.Console.WriteLine("\nCQRS Pattern Example");

        var command = new CreateOrderCommand("order123", 3);
        ICommandHandler<CreateOrderCommand> handler = new OrderCommandHandler();
        handler.Handle(command);

        IQueryHandler<GetOrderQuery, string> queryHandler = new OrderQueryHandler();
        var result = queryHandler.Handle(new GetOrderQuery("order123"));

        System.Console.WriteLine(result);
    }
}

public record CreateOrderCommand(string OrderId, int Quantity);

public interface ICommandHandler<in TCommand>
{
    void Handle(TCommand command);
}

public class OrderCommandHandler : ICommandHandler<CreateOrderCommand>
{
    public void Handle(CreateOrderCommand command)
    {
        System.Console.WriteLine($"Order Created: {command.OrderId} with Quantity: {command.Quantity}");
    }
}

public record GetOrderQuery(string OrderId);

public interface IQueryHandler<in TQuery, out TResult>
{
    TResult Handle(TQuery query);
}

public class OrderQueryHandler : IQueryHandler<GetOrderQuery, string>
{
    public string Handle(GetOrderQuery query)
    {
        return $"Query Result: Order {query.OrderId} found.";
    }
}