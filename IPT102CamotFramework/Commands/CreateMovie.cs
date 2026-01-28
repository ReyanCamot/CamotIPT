using Dapper;
using IPT102CamotDomain.Models;
using IPT102CamotFramework.Extensions;
using IPT102CamotRepository.Interfaces;
using System.Threading.Tasks;

namespace IPT102CamotFramework.Commands
{
    public class CreateMovie
    {
        private readonly string _connectionName = "DefaultConnection";
        private readonly string _storedProcedureName;
        private readonly IRepository _repository;

        public CreateMovie(IRepository repository)
        {
            _storedProcedureName = "[dbo].[CreateMovie]";
            _repository = repository;
        }

        public async Task<bool> ExecuteAsync(MovieModel model)
        {
            var parameters = model.ToMovieDynamicParameters();
            return await _repository.SaveDataAsync(_connectionName, _storedProcedureName, parameters);
        }
    }
}
