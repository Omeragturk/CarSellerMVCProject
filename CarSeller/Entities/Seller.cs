namespace CarSeller.Entities
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactEmail { get; set; }

        public List<Car> Cars { get; set; }
    }
}
