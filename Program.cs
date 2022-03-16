using System;
using System.Collections.Generic;

namespace InventoryManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
 
            var listbook = new List<Inventory>();
            listbook.Add(new Inventory("lettuce", 10.5, 50, "Leafy green" ));
            listbook.Add(new Inventory("cabbage", 20, 100, "Cruciferous"));
            listbook.Add(new Inventory("pumpkin", 30, 30, "Marrow"));
            listbook.Add(new Inventory("cauliflower", 10, 25, "Cruciferous"));
            listbook.Add(new Inventory("zucchini", 20.5,50, "Marrow"));
            listbook.Add(new Inventory("yam", 30, 50, "Root"));
            listbook.Add(new Inventory("spinach",10,100, "Leafy green"));
            listbook.Add(new Inventory("broccoli", 20.2,75, "Cruciferous"));
            listbook.Add(new Inventory("garlic",30,20, "Leafy green"));
            listbook.Add(new Inventory("silverbeet",10,50, "Marrow"));

            Console.WriteLine($"Total products in the list : {listbook.Count}");

            Console.WriteLine("Adding a new product...");
            listbook.Add(new Inventory("Potato", 10, 50, "Root"));
            Console.WriteLine("Product added!");
            Console.WriteLine($"Total Product Now : {listbook.Count}\n");
            Console.WriteLine("Products which are Leafy green type:\n");
            foreach(var i in listbook)
            {
                if(i.Type.Equals("Leafy green"))
                {
                    Console.WriteLine(i.Name);
                }
            }
            Console.WriteLine("\nRemoving Garlic from the list...");
            for (int i = 0; i < listbook.Count; i++)
            {
                if(listbook[i].Name.Equals("garlic"))
                {
                    listbook.RemoveAt(i);
                    break;
                }
            }
            Console.WriteLine("Garlic has been removed from the list!");
            Console.WriteLine($"Now Total Product in the list : {listbook.Count}");
        }
    }
}
/*
lettuce, 10.5 RS, 50, Leafy green
cabbage, 20 RS, 100, Cruciferous
pumpkin, 30 RS, 30, Marrow
cauliflower, 10 RS, 25, Cruciferous
zucchini, 20.5 RS, 50, Marrow
yam, 30 RS, 50, Root
spinach, 10 RS, 100, Leafy green
broccoli, 20.2 RS, 75, Cruciferous
garlic, 30 RS, 20, Leafy green
silverbeet, 10 RS, 50, Marrow
*/