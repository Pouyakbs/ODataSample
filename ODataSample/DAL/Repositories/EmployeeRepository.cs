using Microsoft.Extensions.Logging;
using ODataSample.DAL.DbContexts;
using ODataSample.DAL.Repositories.Common;
using ODataSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataSample.DAL.Repositories
{
    public sealed class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationContext appDbContext, ILoggerFactory loggerFactory)
           : base(appDbContext, loggerFactory)
        {
        }
    }
}
