using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Padronize.Data;
using Padronize.Models;

namespace Padronize.Repositories
{
    public class StandartRepository
    {

        private readonly IRepository _repository;
        public StandartRepository(StoreDataContext context, IRepository repository)
        {
            this._repository = repository;
        }

        public StandartRepository()
        {

        }

        public IEnumerable<Standart> GetStandarts(int page = 0, int pageSize = 5)
        {
            var Standarts = this._repository.FindAll<Standart>();
            //var posts =  await _repository.FindAll<Standart>();
            //var otherPost = await _context.Post.Skip(page * pageSize).Take(pageSize).ToListAsync();
            return Standarts;
        }


        public Standart GetStandartId(int id)
        {
            var post = _repository.FindById<Standart>(id);
            return post;
        }


        public void PutStandart(long id, Standart Standart)
        {
            _repository.Update<Standart>(Standart);
        }


        public Standart newStandart(Standart Standart)
        {
            _repository.Create<Standart>(Standart);
            return new Standart { id = Standart.id };
        }



        public Standart DeleteStandart(int id)
        {
            var Standart = _repository.FindById<Standart>(id);
            _repository.Delete<Standart>(Standart);
            return Standart;
        }

    }
}