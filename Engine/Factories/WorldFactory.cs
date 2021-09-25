using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, -1, "Home", 
                "No place like home.", "pack://application:,,,/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(0, 0, "Village Center",
                "A village center.", "");

            newWorld.AddLocation(-1, 0, "Farm",
                "A farm.", "");

            newWorld.AddLocation(-1, -1, "Field",
                "A field", "");

            newWorld.AddLocation(1, 0, "Tavern",
                "A Tavern.", "");

            newWorld.AddLocation(2, 0, "Cellar",
                "A Cellar.", "");

            newWorld.AddLocation(1, 0, "Front Gate",
                "Village front gate", "");

            newWorld.AddLocation(0, 1, "Forest",
                "A Forest", "");

            return newWorld;
        }
    }
}
