using Job_App_Rest.Models;
using System.ComponentModel.DataAnnotations;

namespace Job_App_Rest.Dto
{
    public record CompanyReqDto([Required] string CompanyName, [Required] string Description, List<JobReqDto> jobs);
}
