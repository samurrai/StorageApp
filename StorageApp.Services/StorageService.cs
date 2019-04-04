using StorageApp.Models;
using System.IO;
using System.Xml.Serialization;

namespace StorageApp.Services
{
    public class StorageService
    {
        public delegate void Add(Product product);
        public event Add AddPressed;

        public void AddPressedEvent(Product product)
        {
            AddPressed?.Invoke(product);
        }

        public void WriteToXml(Product product) {

            XmlSerializer serializer = new XmlSerializer(typeof(Product));

            using (FileStream writer = new FileStream("data.xml", FileMode.Append))
            {
                serializer.Serialize(writer, product);
            }
        }
    }
}
