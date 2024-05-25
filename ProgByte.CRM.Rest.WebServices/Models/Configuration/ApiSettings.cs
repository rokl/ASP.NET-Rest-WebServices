using Swashbuckle.AspNetCore.Annotations;
using System.Xml.Serialization;

namespace ProgByte.CRM.Rest.WebServices.Models.Configuration
{
    /// <summary>
    /// General API settings
    /// </summary>
    public class ApiSettings
    {
        /// <summary>
        /// Section name in the configuration file
        /// </summary>
        public const string SectionName = "ApiConfiguration";

        /// <summary>
        /// API title shown in the Swagger documentation
        /// </summary>
        public string? Title { get; set; }
    }
}
