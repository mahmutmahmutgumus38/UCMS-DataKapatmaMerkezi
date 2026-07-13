using Microsoft.Data.SqlClient;

namespace DataKapatmaMerkezi.Services;

public class SqlService
{
    private readonly IConfiguration _configuration;

    public SqlService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public SqlConnection GetConnection()
    {
        return new SqlConnection(
            _configuration.GetConnectionString("SqlConnection"));
    }
}
