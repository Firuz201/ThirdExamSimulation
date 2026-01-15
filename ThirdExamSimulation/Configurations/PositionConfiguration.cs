using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThirdExamSimulation.Areas.Admin.Models;

namespace ThirdExamSimulation.Configurations;

public class PositionConfiguration: IEntityTypeConfiguration<Position>
{
    public void Configure(EntityTypeBuilder <Position> builder)
    {
        builder.Property(x => x.Title).IsRequired().HasMaxLength(256);
    }
}
