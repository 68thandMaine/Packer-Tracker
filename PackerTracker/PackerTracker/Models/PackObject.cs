using System;
using System.Collections.Generic;

namespace PackerTracker.Models
{
    public class PackObject
    {
        private string _itemName;
        private int _price;
        private int _weight;
        private bool _purchase;
        private static List<PackObject> _inventory = new List<PackObject> { };
        private int _id;

        public PackObject(string product, int price, int weight, bool purchased)
        {
            _itemName = product;
            _price = price;
            _weight = weight;
            _purchase = purchased;
            _inventory.Add(this);
            _id = _inventory.Count;
        }

        public static List<PackObject> GetAll()
        {
            return _inventory;
        }

        public string GetProduct()
        {
            return _itemName;
        }

        public int GetPrice()
        {
            return _price;
        }

        public int GetWeight()
        {
            return _weight;
        }

        public string IsItPurchased()
        {
            return _purchase.ToString();
        }

        public int GetId()
        {
            return _id;
        }

        public static void ClearAll()
        {
            _inventory.Clear();
        }

        public static PackObject Find (int searchId)
        {
            return _inventory[searchId - 1];
        }

    }
}
