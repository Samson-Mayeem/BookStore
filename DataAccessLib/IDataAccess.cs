namespace DataAccessLib
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U paramenters, string connectionString);
        void SaveData<T>(string sql, T parameters, string connectionString);
    }
}