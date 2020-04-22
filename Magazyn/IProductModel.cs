namespace Magazyn
{
    interface IProductModel
    {
        string Location { get; set; }
        string ProductName { get; set; }
        int Quantity { get; set; }
    }
}