using Dapper;
using LearnDotnet.Models;
using Microsoft.Data.Sqlite;

public class MainRepository
{
    private readonly SqliteConnection connection;
    private readonly IConfiguration configuration;

    public MainRepository(IConfiguration configuration)
    {
        connection = new SqliteConnection(configuration.GetConnectionString("DefaultConnection"));
    }

    public async Task<IEnumerable<OrderModel>> GetOrders()
    {
        var sql = "SELECT OrderID, Status FROM Orders";
        connection.Open();
        var orders = await connection.QueryAsync<OrderModel>(sql);
        connection.Close();
        return orders;
    }
}