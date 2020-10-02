using System.Collections.Generic;
using System.Threading.Tasks;
using Padronize.Data;
using Padronize.Models;

namespace Padronize.Repositories
{
    public class ApplicationRepository
    {

        private readonly IRepository _repository;
        public ApplicationRepository(StoreDataContext context, IRepository repository)
        {
            this._repository = repository;
        }

        public ApplicationRepository (){
            
        }

        public  IEnumerable<Application> GetApplications(int page = 0, int pageSize = 5)
        {
            var posts =   _repository.FindAll<Application>("Application.Standart");
            //var otherPost =  _context.Post.Skip(page * pageSize).Take(pageSize).ToList();
            return posts;
        }

      
        public  Application GetApplicationId(int id)
        {
            var post =  _repository.FindById<Application>(id);
            return post;
        }

     
        public  void PutApplication(long id, Application Application)
        {
            _repository.Update<Application>(Application);
        }

      
        public  Application newApplication(Application Application)
        {
             _repository.Create<Application>(Application);
            return  new Application { id = Application.id };
        }

        
      
        public Application DeleteApplication(int id)
        {
            var Application =  _repository.FindById<Application>(id);
             _repository.Delete<Application>(Application);
            return Application;
        }
        
    }
}