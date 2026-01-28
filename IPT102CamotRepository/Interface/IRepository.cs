using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;

namespace IPT102CamotRepository.Interfaces
{
    public interface IRepository
    {
        Task<IEnumerable<T>> GetDataAsync<T>(
            string connectionString,
            string storedProcName,
            DynamicParameters parameters = null
        );

        Task<bool> SaveDataAsync(
            string connectionString,
            string storedProcName,
            DynamicParameters parameters = null
        );
    }
}
