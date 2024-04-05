using Backpack;

namespace dz02._04
{
    class Program
    {
        static void Main()
        {
            BP backpack = new BP("black", "Nike", "polyester", 0.5, 20);
            Console.WriteLine($"New backpack created -> {backpack.Color} {backpack.Brand}");
            Item item = new Item("book", 1);

            try
            {
                backpack.AddItem(item);
                Console.WriteLine($"New item added to backpack -> {item.Name}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
