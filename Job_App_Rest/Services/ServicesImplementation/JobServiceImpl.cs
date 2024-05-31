using Job_App_Rest.Data;
using Job_App_Rest.GenericRepository;
using Job_App_Rest.Models;
using Job_App_Rest.Services.ServicesInterface;

namespace Job_App_Rest.Services.ServicesImplementation
{
    public class JobServiceImpl : GenericRepository<Job>, IJobService
    {
        public JobServiceImpl(AppDbContext dbContext):base(dbContext)
        {
            
        }
    }
}
