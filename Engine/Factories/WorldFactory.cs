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
            // instantiate world object and add locations
            World newWorld = new World();

            newWorld.AddLocation(0, -1, "Home", 
                "No place like home.", "pack://application:,,,/Engine;component/Images/Locations/Home.png");

            newWorld.AddLocation(0, 0, "Village Center",
                "A village center.", "pack://application:,,,/Engine;component/Images/Locations/VillageCenter.png");

            newWorld.AddLocation(-1, -1, "Farm",
                "A farm.", "pack://application:,,,/Engine;component/Images/Locations/Farm.png");

            newWorld.AddLocation(-1, -2, "Field",
                "A field", "pack://application:,,,/Engine;component/Images/Locations/Field.png");

            newWorld.AddLocation(0, 1, "Tavern",
                "A Tavern.", "pack://application:,,,/Engine;component/Images/Locations/Tavern.png");

            newWorld.AddLocation(0, 2, "Cellar",
                "A Cellar.", "pack://application:,,,/Engine;component/Images/Locations/Cellar.png");

            newWorld.AddLocation(1 , 0, "Front Gate",
                "Village front gate", "pack://application:,,,/Engine;component/Images/Locations/FrontGate.png");

            newWorld.AddLocation(2, 0, "Forest",
                "A Forest", "pack://application:,,,/Engine;component/Images/Locations/Forest.png");

            newWorld.AddLocation(-1 , 0, "Trader",
                "Trader", "pack://application:,,,/Engine;component/Images/Locations/Trader.png");

            return newWorld;
        }
    }
}
