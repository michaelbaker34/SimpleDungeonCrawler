using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        // GameSession Object Constructor
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "TestPlayer";
            CurrentPlayer.Class = "TestClass";
            CurrentPlayer.Gold = 1000;
        }
    }
    
}
