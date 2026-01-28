using System.Data;
using Dapper;

namespace IPT102Framework.Extensions
{
    public static class StringExtension
    {
        public static DynamicParameters ToDynamicParameters(this string value, string name)
        {
            var parameters = new DynamicParameters();

            parameters.Add($"@{name}", value, DbType.String, ParameterDirection.Input);

            return parameters;
        }
    }
}
