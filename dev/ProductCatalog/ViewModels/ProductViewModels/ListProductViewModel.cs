namespace ProductCatalog.ViewModels.ProductViewModels
{
    public class ListProductViewModel
    {
         public int Id { get; set; }
        public string  Title { get; set; }
        public decimal Price { get; set; }
        public int CategoyId { get; set; }
        public string Category { get; set; }
 
        
    }
}