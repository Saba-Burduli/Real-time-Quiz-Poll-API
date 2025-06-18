namespace Domain;

public class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(This IServiceCollection services)
    {
        services.AddDbContext<EnterwellQuizDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("PostgresConnection")));

    }
    
}