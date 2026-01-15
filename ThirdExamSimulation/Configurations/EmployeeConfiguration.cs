using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThirdExamSimulation.Areas.Admin.Models;

namespace ThirdExamSimulation.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.Property(x => x.Name).IsRequired().HasMaxLength(256);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(256);
        builder.Property(x => x.ImagePath).IsRequired().HasMaxLength(256);

        builder.HasOne(x => x.Position).WithMany(x => x.Employees).HasForeignKey(x => x.PositionId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Cascade);
    }
}
