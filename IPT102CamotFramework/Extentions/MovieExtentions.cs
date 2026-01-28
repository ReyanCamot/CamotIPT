using Dapper;
using IPT102CamotDomain.Models;
using System.Data;

namespace IPT102CamotFramework.Extensions
{
    public static class MovieExtensions
    {
        public static DynamicParameters ToMovieDynamicParameters(this MovieModel model)
        {
            var p = new DynamicParameters();

            p.Add("@Id", model.Id, DbType.Int32, ParameterDirection.Input);

            p.Add("@Title", model.Title, DbType.String, ParameterDirection.Input);
            p.Add("@ReleaseYear", model.ReleaseYear, DbType.Int32, ParameterDirection.Input);
            p.Add("@RuntimeMinutes", model.RuntimeMinutes, DbType.Int32, ParameterDirection.Input);
            p.Add("@Rating", model.Rating, DbType.Decimal, ParameterDirection.Input);

            return p;
        }
    }
}
