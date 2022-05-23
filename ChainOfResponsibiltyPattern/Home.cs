using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibiltyPattern
{
    class Home
    {
        public string Name { get; set; }
        public bool MakeDinner { get; set; }
        public bool WashDishes { get; set; }
        public bool WaterGarden { get; set; }

        public Home(string name, bool makeDinner, bool washDishes, bool waterGarden)
        {
            Name = name;
            MakeDinner = makeDinner;
            WashDishes = washDishes;
            WaterGarden = waterGarden;
        }
    }
}
