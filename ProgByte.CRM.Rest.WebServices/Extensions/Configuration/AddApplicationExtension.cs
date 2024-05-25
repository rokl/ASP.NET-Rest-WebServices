namespace ProgByte.CRM.Rest.WebServices.Extensions.Configuration
{
    /// <summary>
    /// Configure any services needed for the application
    /// </summary>
    public static class AddApplicationExtension
    {
        /// <summary>
        /// Add application services
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void AddApplication(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddHttpContextAccessor();
        }
    }
}
