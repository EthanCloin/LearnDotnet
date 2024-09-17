namespace LearnDotnet.Models;

public class ProductModel
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int MinimumBatchSize { get; set; }
    public int UnitsStocked { get; set; }
    public int UnitsAllocated { get; set; }
    public int UnitsFulfilled { get; set; }
}