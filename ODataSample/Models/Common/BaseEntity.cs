using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ODataSample.Models.Common
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Created", Description = "DateTime of creation")]
        public DateTime Created { get; set; } = DateTime.UtcNow;

        [Display(Name = "Modified", Description = "DateTime of modification")]
        public DateTime Modified { get; set; } = DateTime.UtcNow;
    }
}
