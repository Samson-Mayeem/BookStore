using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace DataAccessLib
{
    public class DataAccess : IDataAccess
    {
        public Task DeleteData<T>(string sql, T parameters, string connectionString)
        {
            throw new NotImplementedException();
        }

        public async Task<List<T>> LoadData<T, U>(string sql, U paramenters, string connectionString)
        {
            using IDbConnection connection = new MySqlConnection(connectionString);
            var rows = await connection.QueryAsync<T>(sql, paramenters);
            return rows.ToList();
        }

        public Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                return connection.ExecuteAsync(sql, parameters);
            }
        }

        public void Update<T>(string sql, T parameters, string connectionString)
        {
            throw new NotImplementedException();
        }
    }
}