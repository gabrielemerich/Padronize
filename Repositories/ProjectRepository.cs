using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Padronize.Data;
using Padronize.Models;

namespace Padronize.Repositories
{
    public class ProjectRepository
    {

        private readonly IRepository _repository;
        public ProjectRepository(StoreDataContext context, IRepository repository)
        {
            this._repository = repository;
        }

        public ProjectRepository()
        {

        }

        public IEnumerable<Project> GetProjects(int page = 0, int pageSize = 5)
        {
            var projects = this._repository.FindAll<Project>("applications.Standarts");
            //var posts =  await _repository.FindAll<Project>();
            //var otherPost = await _context.Post.Skip(page * pageSize).Take(pageSize).ToListAsync();
            return projects;
        }


        public Project GetProjectId(int id)
        {
            var post = _repository.FindById<Project>(id);
            return post;
        }


        public void PutProject(long id, Project project)
        {
            _repository.Update<Project>(project);
        }


        public Project newProject(Project project)
        {
            _repository.Create<Project>(project);
            return new Project { id = project.id };
        }



        public Project DeleteProject(int id)
        {
            var project = _repository.FindById<Project>(id);
            _repository.Delete<Project>(project);
            return project;
        }

    }
}