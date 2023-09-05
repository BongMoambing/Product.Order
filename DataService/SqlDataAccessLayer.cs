using Dapper;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Product.Order.DataService;

public class SqlDataAccessLayer : ISqlDataAccessLayer
{
    private IConfiguration _configuration;
    public SqlDataAccessLayer(IConfiguration configuration)
    {
         _configuration = configuration;
    }

    public async Task<IEnumerable<T>> LoadData<T, U>(string storeProcedure, U parameters, string connectionId = "DefaultConnection")
    {
        try
        {
            using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionId));
            return await connection.QueryAsync<T>(storeProcedure, parameters, commandType: CommandType.StoredProcedure);
        }catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);    
        }
      
    }

    public async Task SaveData<T>(string storeProcedure, T parameters, string connectionId = "DefaultConnection")
    {
        using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionId));
        await connection.ExecuteAsync(storeProcedure, parameters, commandType: CommandType.StoredProcedure);
    }
}
