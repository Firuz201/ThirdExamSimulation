using ThirdExamSimulation.Areas.Admin.Models.Common;

namespace ThirdExamSimulation.Areas.Admin.Models
{
    public class Position : BaseEntity
    {
        public string Title { get; set; } = null!;

        public ICollection<Employee> Employees { get; set; } = [];
    }
}
