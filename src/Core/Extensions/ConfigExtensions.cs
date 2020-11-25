﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace Core.Extensions
{
    public static class ConfigExtensions
    {
        public static TSettings AddConfig<TSettings>(this IServiceCollection services, IConfiguration configuration, Action<BinderOptions> configureOptions = null)
            where TSettings : class, new()
        {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            var settings = configuration.Get<TSettings>(configureOptions);
            services.TryAddSingleton(settings);

            return settings;
        }

        public static TSettings AddConfig<TSettings>(this IServiceCollection services, IConfiguration configuration, string sectionKey, Action<BinderOptions> configureOptions = null)
            where TSettings : class, new()
        {
            IConfigurationSection section = null;

            if (!string.IsNullOrEmpty(sectionKey))
                section = configuration.GetSection(sectionKey);
            
            return services.AddConfig<TSettings>(section ?? configuration, configureOptions);
        }

        public static TSettings AddConfig<ISettings, TSettings>(this IServiceCollection services, IConfiguration configuration, Action<BinderOptions> configureOptions)
            where ISettings : class
            where TSettings : class, ISettings, new()
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            var settings = Get<TSettings>(configuration, configureOptions);
            services.TryAddSingleton<ISettings>(settings);

            return settings;
        }

        public static TSettings AddConfig<ISettings, TSettings>(this IServiceCollection services, IConfiguration configuration, string sectionKey, Action<BinderOptions> configureOptions = null)
            where ISettings : class
            where TSettings : class, ISettings, new()
        {
            IConfigurationSection section = null;
            
            if (!string.IsNullOrEmpty(sectionKey))
                section = configuration.GetSection(sectionKey);
            
            return services.AddConfig<ISettings, TSettings>(section ?? configuration, configureOptions);
        }

        private static TSettings Get<TSettings>(IConfiguration configuration, Action<BinderOptions> configureOptions)
        {
            if (configureOptions == null)
                configureOptions = options => { };

            return configuration.Get<TSettings>(configureOptions);
        }
    }
}
