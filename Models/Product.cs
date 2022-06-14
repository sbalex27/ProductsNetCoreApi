namespace ProductsNetCoreApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public float Gain { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int BrandId { get; set; }
        public Brand? Brand { get; set; }

        public Product(int id, string name, int value, float gain, int categoryId)
        {
            Id = id;
            Name = name;
            Value = value;
            Gain = gain;
            CategoryId = categoryId;
        }
    }
}
