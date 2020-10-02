using System.Collections.Generic;
using System.Threading.Tasks;
using Padronize.Data;
using Padronize.Models;
using Padronize.Repositories;

namespace Padronize.Services
{
    public class StandartService
    {
        private readonly StandartRepository repo;
        public StandartService(){
            
        }
        public StandartService(StoreDataContext context, IRepository repository)
        {
            repo = new StandartRepository(context,repository);
        }


         public  IEnumerable<Standart> GetStandarts(int page = 0, int pageSize = 5)
        {
            var Standarts =   this.repo.GetStandarts();
            //var otherPost = await _context.Post.Skip(page * pageSize).Take(pageSize).ToListAsync();
            return Standarts;
        }

      
        public  Standart GetStandartId(int id)
        {
            var Standart =  repo.GetStandartId(id);
            return Standart;
        }

     
        public void PutPost(long id, Standart Standart)
        {
            repo.PutStandart(id,Standart);
        }

      
        public  Standart newStandart(Standart Standart)
        {
            return  repo.newStandart(Standart);
            
        }

        
      
        public  Standart DeletePost(int id)
        {
            return  repo.DeleteStandart(id);
        }
    }
}