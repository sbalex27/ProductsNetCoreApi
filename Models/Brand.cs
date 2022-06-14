namespace ProductsNetCoreApi.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Product>? Products { get; set; }

        public Brand(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
