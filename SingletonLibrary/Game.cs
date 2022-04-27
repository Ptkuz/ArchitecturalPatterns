using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLibrary
{
    public class Game
    {
        public GameSettings Settings { get; set; }

        public void Apply(ScreenResolution screenResolution) 
        {
            Settings = GameSettings.getInstance(screenResolution);

            
        }
    }
}
