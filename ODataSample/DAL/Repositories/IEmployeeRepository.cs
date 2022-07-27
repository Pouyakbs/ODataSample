using ODataSample.DAL.Repositories.Common;
using ODataSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataSample.DAL.Repositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
    }
}
