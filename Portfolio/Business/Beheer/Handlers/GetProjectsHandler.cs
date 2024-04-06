using Dto_s.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beheer.Handlers
{
    public interface IGetProjectsHandler
    {
        public Task<IEnumerable<ProjectsDto>> HandleAsync();

    }
    public class GetProjectsHandler : IGetProjectsHandler
    {
        private readonly IPortfolioContext _portfoliocontext;
        public GetProjectsHandler(IPortfolioContext portfoliocontext)
        {
            _portfoliocontext = portfoliocontext;
        }
        public async Task<IEnumerable<ProjectsDto>> HandleAsync()
        {
            var result = await _portfoliocontext.Projects.TolistAsync();

            return result;
        }

    }
}
