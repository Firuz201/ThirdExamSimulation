using ThirdExamSimulation.Areas.Admin.Models.Common;

namespace ThirdExamSimulation.Areas.Admin.Models
{
    public class Employee : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImagePath { get; set; } = string.Empty;

        public int PositionId { get; set; }

        public Position Position { get; set; } = null!;

    }
}
