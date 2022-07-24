namespace LeaveManagment.Web.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(List<T> entities);
        Task<List<T>> GetAllAsync();
        Task<T?> GetAsync(int? id);
        Task DeleteAsync(int id);
        //Task<int> GetCountAsync();
        Task UpdateAsync(T entity);
        Task<bool> Exists(int id);
    }
}
