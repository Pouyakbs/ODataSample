using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ODataSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataSample.DAL.Configurations
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(m => m.Id);
            builder.Property(m => m.FirstName).IsRequired().HasMaxLength(128).IsUnicode();
            builder.Property(m => m.LastName).IsRequired().HasMaxLength(128).IsUnicode();
            builder.Property(m => m.BirthDate).IsRequired();
        }
    }
}
