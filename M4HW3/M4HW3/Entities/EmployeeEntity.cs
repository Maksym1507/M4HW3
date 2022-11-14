namespace M4HW3.Entities
{
    public class EmployeeEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HireDate { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public int OfficeId { get; set; }

        public OfficeEntity Office { get; set; }

        public int TitleId { get; set; }

        public TitleEntity Title { get; set; }

        public List<EmployeeProjectEntity> EmployeeProjects { get; set; } = new ();
    }
}
