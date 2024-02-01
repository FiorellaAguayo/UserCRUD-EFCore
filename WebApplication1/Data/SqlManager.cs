namespace WebApplication1.Data
{
    public class SqlManager<T> : SqlDataManager<T> where T : class
    {
        public SqlManager(ApplicationDbContext context) : base(context)
        {
        }

        public async Task Create(T entity) => await CreateAsync(entity);

        public async Task Update(T entity) => await UpdateAsync(entity);

        public async Task Delete(int id) => await DeleteAsync(id);

        public async Task<T> Get(int id) => await GetByIdAsync(id);

        public async Task<IEnumerable<T>> GetAll() => await GetAllAsync();
    }
}
