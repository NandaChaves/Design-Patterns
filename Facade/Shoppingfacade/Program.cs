namespace Shoppingfacade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pratical interface with facade
            ShoppingItem shopItem = new ShoppingItem();
            shopItem.AddItemToCart("red shoes", 5);
            Console.ReadLine();
        }
    }
}
