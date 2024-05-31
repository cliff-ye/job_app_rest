using Job_App_Rest.Data;
using Job_App_Rest.Dto;
using Job_App_Rest.GenericRepository;
using Job_App_Rest.Models;
using Job_App_Rest.Services.ServicesInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Job_App_Rest.Services.ServicesImplementation
{
    public class CompanyServiceImpl : GenericRepository<Company>, ICompanyService
    {
        public CompanyServiceImpl(AppDbContext dbContext) : base(dbContext)
        {
        }

        //public async Task<ActionResult<Company>> GetCompanywithJobs(int id)
        //{
        //    var data = await _dbSet.Include(company => company.Jobs)
        //                          .FirstOrDefaultAsync(company => company.Id == id);

        //    if (data == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(data);
        //}
    }
}
