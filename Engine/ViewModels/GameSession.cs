using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    class GameSession
    {
        Player CurrentPlayer { get; set; }

        // GameSession Object Constructor
        public GameSession()
        {
            CurrentPlayer = new Player();
        }
    }
    
}
