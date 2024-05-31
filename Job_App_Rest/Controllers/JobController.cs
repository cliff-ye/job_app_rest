using Job_App_Rest.Data;
using Job_App_Rest.Dto;
using Job_App_Rest.Models;
using Job_App_Rest.Services.ServicesImplementation;
using Job_App_Rest.Services.ServicesInterface;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace Job_App_Rest.Controllers
{
    [ApiController]
    [Route("/api/v1/jobs")]
    public class JobController : Controller
    {
        private readonly AppDbContext _appDbContext;
        IJobService _jobRepo;
        public JobController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _jobRepo = new JobServiceImpl(_appDbContext);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Job>> GetJob(int id)
        {
            if(id == 0) 
            {
                return BadRequest();
            }

            var job = await _jobRepo.Get(id);
            return Ok(job);
        }

        [HttpPost]
        public async Task<ActionResult<Job>> CreateJob(CreateJobReqDto createJobReqDto)
        {
            if (createJobReqDto == null)
            {
                return BadRequest();
            }

            var job = createJobReqDto.Adapt<Job>();
            var company = createJobReqDto.company.Adapt<Company>();

            job.Company = company;

            return await _jobRepo.Create(job);

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteJob(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
             await _jobRepo.Delete(id);

            return NoContent();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Job>>> GetAllJobs()
        {
              var jobs = await _jobRepo.GetAll();
            return Ok(jobs);
        }
       

    }
}
