using System.ComponentModel.DataAnnotations;

namespace Job_App_Rest.Dto
{
    public record CompanyDto([Required] string CompanyName, [Required] string Description);
}
