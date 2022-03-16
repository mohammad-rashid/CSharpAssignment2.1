using System;


namespace InventoryManagement
{
    public class Inventory
    {
        public string Name;
        public double Price;
        public int Quantity;
        public string Type;

        public Inventory(string name, double price, int quantity, string type)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Type = type;
        }
    }
}