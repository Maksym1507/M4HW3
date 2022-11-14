namespace M4HW3.Entities
{
    public class TitleEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<EmployeeEntity> Employees { get; set; } = new ();
    }
}
