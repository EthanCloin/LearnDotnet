namespace LearnDotnet.Models;

public class IngredientModel
{
    public int IngredientID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int MinimumOrderQuantity { get; set; }
    public int QuantityStocked { get; set; }
    public int QuantityAvailable { get; set; }
    public int QuantityConsumed { get; set; }
}

public class ProductIngredientDisplayModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int IngredientQuantity { get; set; }
}