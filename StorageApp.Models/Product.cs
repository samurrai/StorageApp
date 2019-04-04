using System;

namespace StorageApp.Models
{
    [Serializable]
    public class Product
    {
        public string Name { get; set; }
        public int Cost { get; set; }
    }
}