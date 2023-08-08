namespace InventoryMangment
{
    public class ConsoleVirtualGUI
    {
        private static ProductsRepo Mangment =  ProductsRepo.Instance;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this Mangment System, please choose what you want to do!");

            while (true)
            {
                Console.WriteLine("1.Add a New Product");
                Console.WriteLine("2.View All Existing Products");
                Console.WriteLine("3.Edit an Exisiting Product");
                Console.WriteLine("4.Delete a Product");
                Console.WriteLine("5.Search For a Product");
                Console.WriteLine("6.Close");
                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1: 
                        MyProduct product = new MyProduct();
                        Console.WriteLine("Creating a new product ");
                        Console.WriteLine("What is Your Product name ?");
                        product.Name = Console.ReadLine();
                        Console.WriteLine("What is the Price For This Product?");
                        product.Price= Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("How many Products are there ?");
                        product.Quantity = Convert.ToInt32(Console.ReadLine());
                        product.EntityOption = EntityStateOption.Active;
                        try
                        {
                            Mangment.AddNewProduct(product);
                        }
                        catch (Exception e) { 
                        Console.WriteLine("please ensure that the data you entered are correct ");
                        }
                        
                        break;
                    case 2:

                        Console.WriteLine("Viewing All Existing Products");
                        foreach (var Product in Mangment.GetProducts())
                        {
                            var index = 0;
                            if (Product.EntityOption ==EntityStateOption.Active)
                            Console.WriteLine($"{index++}.{Product.Name} costs {Product.Price}$ and there is {Product.Quantity}");

                            }
                        break;
                    case 3:
                        Console.WriteLine("Edit an Existing Product");
                        Console.WriteLine("Enter the name of the product you want to edit:");
                        string productNameToEdit = Console.ReadLine();

                        try
                        {
                            Console.WriteLine($"Editing {productNameToEdit}");
                            Console.WriteLine("Enter new name (or press Enter to keep the same):");
                            string newName = Console.ReadLine();
                            Console.WriteLine("Enter new price (or press Enter to keep the same):");
                            string newPriceString = Console.ReadLine();
                            decimal? newPrice = !string.IsNullOrWhiteSpace(newPriceString) ? decimal.Parse(newPriceString) : (decimal?)null;
                            Console.WriteLine("Enter new quantity (or press Enter to keep the same):");
                            string newQuantityString = Console.ReadLine();
                            int? newQuantity = !string.IsNullOrWhiteSpace(newQuantityString) ? int.Parse(newQuantityString) : (int?)null;

                            Mangment.EditExistingProduct(productNameToEdit, newName, newPrice, newQuantity);
                            Console.WriteLine("Product edited successfully.");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"sorry No such product exist ");
                        }

                        break;
                    case 4:
                        Console.WriteLine("4.Delete a Product");
                        break;
                    case 5:
                        Console.WriteLine("5.Search For a Product");
                        break;
                    case 6:
                        Console.WriteLine("6.Close");
                        break;



                }

            }

        }
    }
}