using Animals.Models.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class Engine
    {
        private World world;

        public Engine()
        {
            this.world = new World(100);
        }

        public void Run()
        {
            SetStartPosition(20);
        }

        private void SetStartPosition(int animalCount)
        {          
        }
    }
}
