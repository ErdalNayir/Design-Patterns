using PrototypePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Entities
{
    internal class Plane : IClonablePrototype<Plane>
    {
        public string name { get; set; }
        public string model { get; set; }
        public string company { get; set; }

        public Plane(string name, string model, string company)
        {
            this.name = name;
            this.model = model;
            this.company = company;
        }

        public Plane Clone()
        {
            return base.MemberwiseClone() as Plane;
        }
    }
}
