using System.Text.Json;
using CreationalPatterns.ConfigurationFactories;
using Microsoft.Extensions.Configuration;

namespace CreationalPatterns.FilterService;

public class FilterConfigurator
{
    public static ComponentFilters GetComponentFilters(IConfigurationFactory factory)
    {
        ArgumentNullException.ThrowIfNull(factory, nameof(factory));

        IConfiguration config = factory.CreateConfiguration();

        ComponentFilters filters = config.GetSection("Filters").Get<ComponentFilters>()
                                    ?? throw new JsonException("Cannot parse configuration file to ComponentFilters");

        return filters;
    }
}