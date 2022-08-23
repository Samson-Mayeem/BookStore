﻿using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace DataAccessLib
{
    public class DataAccess : IDataAccess
    {
        public async Task<List<T>> LoadData<T, U>(string sql, U paramenters, string connectionString)
        {
            using IDbConnection connection = new MySqlConnection(connectionString);
            var rows = await connection.QueryAsync<T>(sql, paramenters);
            return rows.ToList();
        }

        public void SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                connection.ExecuteAsync(sql, parameters);
            }
        }


    }
}