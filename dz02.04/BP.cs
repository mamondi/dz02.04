using System;
using System.Collections.Generic;

namespace Backpack
{
    internal class BP
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Material { get; set; }
        public double Weight { get; set; }
        public double Capacity { get; } = 10;
        private double currentVolume;
        private List<Item> contents;
        private Action<Item> onItemAdded;

        public BP(string color, string brand, string material, double weight, int capacity, Action<Item> onItemAdded = null)
        {
            Color = color;
            Brand = brand;
            Material = material;
            Weight = weight;
            Capacity = capacity;
            contents = new List<Item>();
            this.onItemAdded = onItemAdded;
        }

        public void AddItem(Item item)
        {
            if (currentVolume + item.Volume > Capacity)
            {
                throw new InvalidOperationException("Рюкзак повний. Неможливо додати новий предмет.");
            }

            contents.Add(item);
            currentVolume += item.Volume;
            onItemAdded?.Invoke(item);
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public double Volume { get; set; }

        public Item(string name, double volume)
        {
            Name = name;
            Volume = volume;
        }
    }
}