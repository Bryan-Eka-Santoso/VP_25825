using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Week1.Models
{
    public class barang
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int Harga { get => harga; set => harga = value; }
        private int harga;

        public barang(int id, string name, string description, int harga)
        {
            Id = id;
            Name = name;
            Description = description;
            Harga = harga;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
