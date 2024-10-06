namespace RapidOrder.ProducerAPI.Models
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; } = "";
        public float productPrice { get; set; }
        public string productImageUrl { get; set; } = "";
        public string? productShortName { get; set; }
        public string? productDescription { get; set; }
        public DateTime createdDate { get; set; }
        public string? deliveryTimeSpan { get; set; }
        public int? categoryId { get; set; }
        public string? categoryName { get; set; }
    }
}
