using Dapper;
using IPT102CamotDomain.Models;
using IPT102CamotRepository.Interfaces;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace IPT102CamotFramework.Queries
{
    public class GetMovieById
    {
        private readonly string _connectionName = "DefaultConnection";
        private readonly string _storedProcedureName;
        private readonly IRepository _repository;

        public GetMovieById(IRepository repository)
        {
            _storedProcedureName = "[dbo].[GetMovie]";
            _repository = repository;
        }

        public async Task<MovieModel?> ExecuteAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, DbType.Int32, ParameterDirection.Input);

            var data = await _repository.GetDataAsync<MovieModel>(
                _connectionName,
                _storedProcedureName,
                parameters
            );

            return data.FirstOrDefault();
        }
    }
}
