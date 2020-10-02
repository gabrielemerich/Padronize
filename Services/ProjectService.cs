using System.Collections.Generic;
using System.Threading.Tasks;
using Padronize.Data;
using Padronize.Models;
using Padronize.Repositories;

namespace Padronize.Services
{
    public class ProjectService
    {
        private readonly ProjectRepository repo;
        public ProjectService(){
            
        }
        public ProjectService(StoreDataContext context, IRepository repository)
        {
            repo = new ProjectRepository(context,repository);
        }


         public  IEnumerable<Project> GetProjects(int page = 0, int pageSize = 5)
        {
            var projects =   this.repo.GetProjects();
            //var otherPost = await _context.Post.Skip(page * pageSize).Take(pageSize).ToListAsync();
            return projects;
        }

      
        public  Project GetProjectId(int id)
        {
            var project =  repo.GetProjectId(id);
            return project;
        }

     
        public void PutPost(long id, Project project)
        {
            repo.PutProject(id,project);
        }

      
        public  Project newProject(Project project)
        {
            return  repo.newProject(project);
            
        }

        
      
        public  Project DeletePost(int id)
        {
            return  repo.DeleteProject(id);
        }
    }
}