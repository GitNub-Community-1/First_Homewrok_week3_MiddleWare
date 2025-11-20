using Npgsql;

namespace DbContext;

public class ApplicationConnection
{
    readonly string connstring= "Host=localhost;Port=5432;Database=;Username=postgres;Password=maradona@$$34;";
    public NpgsqlConnection GetConnect() => new NpgsqlConnection(connstring);
}