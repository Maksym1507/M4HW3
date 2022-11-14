namespace M4HW3.Entities
{
    public class EmployeeProjectEntity
    {
        public int Id { get; set; }

        public decimal Rate { get; set; }

        public DateTime StartedDate { get; set; }

        public int EmployeeId { get; set; }

        public EmployeeEntity Employee { get; set; }

        public int ProjectId { get; set; }

        public ProjectEntity Project { get; set; }
    }
}
