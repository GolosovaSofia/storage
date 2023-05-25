
using System.Xml.Linq;

namespace storage
{
    internal class Infostorage
    {
        public uint ID { get; set; }
    }
    class InfoProducts : Infostorage
    {
        public string Type { get; set; }
        public uint Number { get; set; }
        public uint Life { get; set; }
        public uint Cost { get; set; }
        public string Give { get; set; }

        public InfoProducts(uint id, string type, uint number, uint life, uint cost, string give)
        {
            ID = id;
            Type = type;
            Number = number;
            Life = life;
            Cost = cost;
            Give = give;
        }
    }

    class InfoUsers : Infostorage
    {
        public string Fam { get; set; }
        public string Name { get; set; }
        public uint Phone { get; set; }
        public uint Creditc { get; set; }

        public InfoUsers(uint id, string fam, string name, uint phone, uint creditc)
        {
            ID = id;
            Fam = fam;
            Name = name;
            Phone = phone;
            Creditc = creditc;
        }
    }
}
