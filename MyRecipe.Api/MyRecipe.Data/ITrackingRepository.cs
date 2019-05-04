using Microsoft.EntityFrameworkCore.Storage;
using MyRecipe.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRecipe.Data
{
    public interface ITrackingRepository<T> where T : TrackedEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetByID(int Id);
        IQueryable<T> Get();
        void Save(T Item);
        void Add(T Item);
        void SaveAll(IEnumerable<T> Items);
        void AddAll(IEnumerable<T> Items);
        Task Delete(int PrimaryKey);

        Task SaveChanges();

        Task<IDbContextTransaction> StartTransaction();

    }
}
