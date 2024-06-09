using Microsoft.Extensions.Configuration;

namespace CreationalPatterns.ConfigurationFactories;

public class ConfigurationFactory : IConfigurationFactory
{
    public required string JsonName
    {
        get => _jsonName!;
        set
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(value, nameof(JsonName));
            _jsonName = value;
        }
    }

    public required string BasePath
    {
        get => _basePath!;
        set
        {
            ArgumentNullException.ThrowIfNull(value, nameof(BasePath));
            _basePath = value;
        }
    }

    private string? _jsonName;
    private string? _basePath;

    public IConfiguration CreateConfiguration()
    {
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory() + "/" + BasePath)
            .AddJsonFile(JsonName)
            .Build();

        return config;
    }
}