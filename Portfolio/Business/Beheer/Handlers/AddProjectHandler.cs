using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beheer.Handlers
{

    public interface IAddProjectHandler
    {
        Task<int> HandleAsync();
    }
    public class AddProjectHandler : IAddProjectHandler
    {
        private readonly IPortfolioContext _context;
        public AddProjectHandler(IPortfolioContext context)
        {
            _context = context; 
        }
        public async Task<int> HandleAsync()
        {


            return 1;
        }
    }
}
