namespace DataAccessLib
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U paramenters, string connectionString);
        Task SaveData<T>(string sql, T parameters, string connectionString);
        Task DeleteData<T>(string sql, T parameters, string connectionString);
        void Update<T>(string sql, T parameters, string connectionString);
    }
}