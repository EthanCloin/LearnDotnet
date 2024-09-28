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

    public async Task<IEnumerable<ProductModel>> GetProducts()
    {
        var sql = "SELECT ProductID, Name, UnitsStocked FROM Products";
        connection.Open();
        var products = await connection.QueryAsync<ProductModel>(sql);
        connection.Close();
        return products;
    }

    public async Task<IEnumerable<ProductModel>> GetProductsByOrder(int orderID)
    {
        var sql = $@"
SELECT p.ProductID, p.Name, p.UnitsStocked FROM Products p
JOIN OrderProducts op ON p.ProductID = op.ProductID
WHERE op.OrderID = {orderID}";
        connection.Open();
        var products = await connection.QueryAsync<ProductModel>(sql);
        connection.Close();
        return products;
    }
}