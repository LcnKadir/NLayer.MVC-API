namespace NLayer.Core.Model
{
    public class Category : BaseEntitiy
    {
        public string Name { get; set; }


        public ICollection<Product> Products { get; set; }
    }

}
