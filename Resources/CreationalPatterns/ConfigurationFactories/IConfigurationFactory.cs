using Microsoft.Extensions.Configuration;

namespace CreationalPatterns.ConfigurationFactories;

public interface IConfigurationFactory
{
    IConfiguration CreateConfiguration();
}