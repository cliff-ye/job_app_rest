﻿using System.ComponentModel.DataAnnotations;

namespace Job_App_Rest.Dto
{
    public record JobReqDto([Required] string Title, [Required] string Description, [Required] string EmploymentType, 
        [Required] string Location, [Required] string MinimumExperience, [Required] decimal Compensation, [Required] string Department);


}