using Microsoft.OpenApi.Models;
using ProgByte.CRM.Rest.WebServices.Configuration;
using ProgByte.CRM.Rest.WebServices.Models.Configuration;
using System.Reflection;

namespace ProgByte.CRM.Rest.WebServices.Extensions.Configuration
{
    public static class AddSwaggerExtension
    {
        public static void AddSwagger(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.Configure<ApiSettings>(configuration.GetSection(ApiSettings.SectionName));

            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen(options =>
            {
                options.SchemaFilter<EnumSchemaFilter>();

                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {Token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                        Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,
                        },
                        new List<string>()
                    }
                });

                options.CustomSchemaIds(type => type.FullName);

                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });

            services.ConfigureOptions<ConfigureSwaggerOptions>();
        }
    }
}
