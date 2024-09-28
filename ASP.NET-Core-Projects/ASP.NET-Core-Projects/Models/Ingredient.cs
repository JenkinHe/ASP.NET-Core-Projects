namespace ASP.NET_Core_Projects.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<DishIngredient> DishIngredients { get; set; }
    }
}
