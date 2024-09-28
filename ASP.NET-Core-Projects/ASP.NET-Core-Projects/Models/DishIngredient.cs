namespace ASP.NET_Core_Projects.Models
{
    public class DishIngredient
    {
        public int DishId { get; set; }
        public Dish Dish { get; set; }
        public int IngredientId {  get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
