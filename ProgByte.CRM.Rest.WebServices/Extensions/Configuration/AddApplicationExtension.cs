namespace ProgByte.CRM.Rest.WebServices.Extensions.Configuration
{
    public static class AddApplicationExtension
    {
        public static void AddApplication(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddHttpContextAccessor();
        }
    }
}
