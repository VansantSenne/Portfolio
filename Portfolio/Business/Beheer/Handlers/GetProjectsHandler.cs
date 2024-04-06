using DAL.Context;
using Dto.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Beheer.Handlers
{
    public interface IGetProjectsHandler 
    {
        Task<IEnumerable<ProjectsDto>> HandleAsync();
    }
    public class GetProjectsHandler : IGetProjectsHandler
    {
        private readonly IPortfolioContext _portfolioContext;

        public GetProjectsHandler(IPortfolioContext portfolioContext)
        {
            _portfolioContext = portfolioContext;
        }
        public async Task<IEnumerable<ProjectsDto>> HandleAsync()
        {
            var result = await _portfolioContext.Projects.ToListAsync();
            if (result == null) 
            {
                return null;
            }

            return result.Select(x => new ProjectsDto
            {
                Id = x.ObjectId,
                Name = x.Name,
                FrameworkId = x.FrameworkId,
                CategoryId = x.CategoryId,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
            }).ToList();
        }
    }
}
