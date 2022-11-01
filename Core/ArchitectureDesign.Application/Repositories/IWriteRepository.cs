using ArchitectureDesign.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureDesign.Application.Repositories
{
    public interface IWriteRepository<T>  : IRepository<T> where T : BaseEntity
    {
        Task<T> AddAsync(T model);
        Task<T> AddRangeAsync(List<T> datas);

        bool Remove(T model);
        bool RemoveRange(List<T> datas);
        Task<bool> RemoveAsync(string id);
        bool Update(T model);
        Task<int> SaveAsync();



    }
}
