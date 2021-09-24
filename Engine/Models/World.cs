using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imageName)
        {
            Location location = new Location();
            location.XCoordinate = xCoordinate;
            location.YCoordinate = yCoordinate;
            location.Name = name;
            location.Description = description;
            location.ImageName = imageName;

            _locations.Add(location)
        }
    }
}
