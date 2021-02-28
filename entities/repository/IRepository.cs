using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace financeiro_service.Core.Repository
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        T GetById(Guid id);
        (IQueryable<T> Itens, int TotalPaginas, int TotalItens) GetAll(ParametrosBusca parametros);
        (IQueryable<T> Itens, int TotalPaginas, int TotalItens) GetAll(Expression<Func<T, bool>> expression, ParametrosBusca parametros);
        Task<T> Create(T entity);
        Task CreateRangeAsync(ICollection<T> entity);
        void DeleteRange(Expression<Func<T, bool>> predicate);
        T Update(T entity);
        T Delete(T entity);
        Task SaveChanges();
    }
}
