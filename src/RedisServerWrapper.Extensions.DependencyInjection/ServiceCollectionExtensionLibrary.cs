using Microsoft.Extensions.Configuration;
using RedisServerWrapper;
using System;

// ReSharper disable once CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensionLibrary {
    public static IServiceCollection AddRedisServer(this IServiceCollection services, RedisSettings redisSettings) =>
        services.AddSingleton(new RedisServer(redisSettings));

    public static RedisSettings GetRedisSettings(this IConfiguration configuration) =>
        configuration.GetSection(nameof(RedisSettings)).Get<RedisSettings>() ?? throw new InvalidCastException(nameof(configuration));
}
