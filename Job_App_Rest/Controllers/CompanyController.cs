using Job_App_Rest.Data;
using Job_App_Rest.Dto;
using Job_App_Rest.GenericRepository;
using Job_App_Rest.Models;
using Job_App_Rest.Services.ServicesImplementation;
using Job_App_Rest.Services.ServicesInterface;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Reflection;

namespace Job_App_Rest.Controllers
{
    [ApiController]
    [Route("/api/v1/companies")]
    public class CompanyController : Controller
    {
        private readonly AppDbContext _appDbContext;
        ICompanyService _companyRepo;
        public CompanyController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _companyRepo = new CompanyServiceImpl(_appDbContext);
        }

        [HttpPost]
        public async Task<ActionResult<Company>> AddCompany(CompanyReqDto companyReqDto)
        {
            if(companyReqDto == null)
            {
                return BadRequest();
            }

            var company = companyReqDto.Adapt<Company>();
            var jobs = companyReqDto.jobs.Select(jobs => jobs.Adapt<Job>()).ToList();

            company.Jobs = jobs;

            return await _companyRepo.Create(company);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Company>> GetCompany(int id) 
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var company = await _companyRepo.Get(id);
            return company;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetAllCompanies()
        {
            var companies = await _companyRepo.GetAll();

            if(companies == null)
            {
                return NotFound();
            }

            return Ok(companies);
        }

       

    }
}
