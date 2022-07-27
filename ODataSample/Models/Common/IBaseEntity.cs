using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataSample.Models.Common
{
    public interface IBaseEntity
    {
        int Id { get; set; }

        DateTime Created { get; set; }

        DateTime Modified { get; set; }
    }
}
