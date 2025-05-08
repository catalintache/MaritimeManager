using Microsoft.EntityFrameworkCore;
namespace MyApp.Infrastructure.Repositories {
  public class EfRepository<T> : IRepository<T> where T : class {
    private readonly AppDbContext _ctx;
    public EfRepository(AppDbContext ctx) => _ctx = ctx;
    public async Task<IEnumerable<T>> GetAllAsync() => await _ctx.Set<T>().ToListAsync();
    public async Task<T?> GetAsync(int id) => await _ctx.Set<T>().FindAsync(id);
    public async Task AddAsync(T entity) { await _ctx.Set<T>().AddAsync(entity); await _ctx.SaveChangesAsync(); }
    public async Task UpdateAsync(T entity) { _ctx.Set<T>().Update(entity); await _ctx.SaveChangesAsync(); }
    public async Task DeleteAsync(T entity) { _ctx.Set<T>().Remove(entity); await _ctx.SaveChangesAsync(); }
  }
}