using System.Collections.Generic;
using System.Threading.Tasks;
using Padronize.Data;
using Padronize.Models;
using Padronize.Repositories;

namespace Padronize.Services
{
    public class ApplicationService
    {
        private readonly ApplicationRepository repo;
        public ApplicationService(){
            
        }
        public ApplicationService(StoreDataContext context, IRepository repository)
        {
            repo = new ApplicationRepository(context,repository);
        }


         public  IEnumerable<Application> GetApplications(int page = 0, int pageSize = 5)
        {
            var Applications =   this.repo.GetApplications();
            //var otherPost = await _context.Post.Skip(page * pageSize).Take(pageSize).ToListAsync();
            return Applications;
        }

      
        public  Application GetApplicationId(int id)
        {
            var Application =  repo.GetApplicationId(id);
            return Application;
        }

     
        public void PutPost(long id, Application Application)
        {
            repo.PutApplication(id,Application);
        }

      
        public  Application newApplication(Application Application)
        {
            return  repo.newApplication(Application);
            
        }

        
      
        public  Application DeletePost(int id)
        {
            return  repo.DeleteApplication(id);
        }
    }
}