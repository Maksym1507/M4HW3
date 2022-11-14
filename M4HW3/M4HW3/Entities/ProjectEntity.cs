namespace M4HW3.Entities
{
    public class ProjectEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Budjet { get; set; }

        public DateTime StartedDate { get; set; }

        public List<EmployeeProjectEntity> EmployeeProjects { get; set; } = new ();
    }
}
