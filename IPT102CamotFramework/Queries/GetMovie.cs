using System.Collections.Generic;
using System.Threading.Tasks;
using IPT102CamotDomain.Models;
using IPT102CamotRepository.Interfaces;

namespace IPT102CamotFramework.Queries
{
    public class GetAllMovies
    {
        private readonly string _connectionName = "DefaultConnection";
        private readonly string _storedProcedureName;
        private readonly IRepository _repository;

        public GetAllMovies(IRepository repository)
        {
            _storedProcedureName = "[dbo].[GetMovie]";
            _repository = repository;
        }

        public async Task<IEnumerable<MovieModel>> ExecuteAsync()
        {
            return await _repository.GetDataAsync<MovieModel>(_connectionName, _storedProcedureName);
        }
    }
}
