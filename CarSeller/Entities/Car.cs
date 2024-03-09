namespace CarSeller.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ImageUrl { get; set; }

        // İlişki için SellerId
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
    }
}
