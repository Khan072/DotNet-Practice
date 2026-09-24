// Console.Write("Enter your role: ");
// string role=Console.ReadLine();

// string access = role switch
// {
//     "admin" => "Full access",
//     "user" => "Limited access",
//     _ => "No access"
// };

// Console.WriteLine(access);


// using System;

Console.Write("Enter product price: ");
int price = int.Parse(Console.ReadLine());

Console.Write("Enter quantity: ");
int quantity = int.Parse(Console.ReadLine());

int total = price * quantity;
int discount = 0;

if (total >= 10000)
{
    discount = total * 20 / 100;
}
else if (total >= 5000)
{
    discount = total * 10 / 100;
}
else if (total >= 2000)
{
    discount = total * 5 / 100;
}

int finalPrice = total - discount;

Console.WriteLine("Total: ₹" + total);
Console.WriteLine("Discount: ₹" + discount);
Console.WriteLine("Final Price: ₹" + finalPrice);
