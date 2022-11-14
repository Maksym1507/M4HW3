namespace M4HW3.Entities
{
    public class OfficeEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public List<EmployeeEntity> Employees { get; set; } = new ();
    }
}
