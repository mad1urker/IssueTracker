using IssueTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTracker.Application.Interfaces.Repositories;
using IssueTracker.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext _context;
        protected readonly DbSet<T> _dbSet;


        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task AddAsync(T entity) 
            => await _dbSet.AddAsync(entity);

        public async Task DeleteAsync(T entity)
            => _dbSet.Remove(entity);

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
            => await _dbSet.ToListAsync();

        public async Task<T> GetByIdAsync(int id)
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
            => await _dbSet.FindAsync(id);
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.

        public async Task UpdateAsync(T entity)
            => _dbSet.Update(entity);

        public async Task SaveChangesAsync()
            => await _context.SaveChangesAsync();

        public async Task SaveSaveChangesAsync() => _context.SaveChanges();
        
    }
}
