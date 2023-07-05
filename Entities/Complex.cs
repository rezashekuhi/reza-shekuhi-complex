namespace ComplexManagment.Entities
{
    public class Complex
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int unitCount { get; set; }
        public List<Blook> Blooks { get; set; }

    }
}
