var product = Console.ReadLine().ToLower();
var TOWN = Console.ReadLine().ToLower();
var quantity = double.Parse(Console.ReadLine());

if (TOWN == "sofia")
{
    if (product == "cafe") Console.WriteLine(quantity * 0.50);
    else if (product == "voda") Console.WriteLine(quantity * 1);
    else if (product == "bira") Console.WriteLine(quantity * 2);
    else if (product == "vodka") Console.WriteLine(quantity * 10);
    else if (product == "cigari") Console.WriteLine(quantity * 5);
    else if (product == "narga") Console.WriteLine(quantity * 15);
    else Console.WriteLine("Invalid product");
}
else if (TOWN == "varna")
{
    if (product == "cafe") Console.WriteLine(quantity * 0.40);
    else if (product == "voda") Console.WriteLine(quantity * 0.80);
    else if (product == "bira") Console.WriteLine(quantity * 1.50);
    else if (product == "vodka") Console.WriteLine(quantity * 9);
    else if (product == "cigari") Console.WriteLine(quantity * 5.50);
    else if (product == "narga") Console.WriteLine(quantity * 20);
    else Console.WriteLine("Invalid product");
}
else if (TOWN == "burgas")
{
    if (product == "cafe") Console.WriteLine(0.50 * quantity * 0.60);
    else if (product == "voda") Console.WriteLine(quantity * 1);
    else if (product == "bira") Console.WriteLine(quantity * 1.50);
    else if (product == "vodka") Console.WriteLine(quantity * 12);
    else if (product == "cigari") Console.WriteLine(quantity * 5.50);
    else if (product == "narga") Console.WriteLine(quantity * 17);
    else Console.WriteLine("Invalid product");
}
