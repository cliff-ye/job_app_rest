using Job_App_Rest.Dto;
using Job_App_Rest.GenericRepository;
using Job_App_Rest.Models;
using Microsoft.AspNetCore.Mvc;

namespace Job_App_Rest.Services.ServicesInterface
{
    public interface ICompanyService : IGenericRepository<Company>
    {
        //public Task<ActionResult<Company>> GetCompanywithJobs(int id);
    }
}
