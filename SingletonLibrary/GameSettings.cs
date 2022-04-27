namespace SingletonLibrary
{
    public class GameSettings
    {

        


        private static GameSettings _instance;

        public ScreenResolution ScreenResolution { get; private set; }

        protected GameSettings(ScreenResolution screenResolution) 
        { 
            ScreenResolution = screenResolution;
        }

        public static GameSettings getInstance(ScreenResolution screenResolution) 
        {
            if (_instance == null)
                _instance = new GameSettings(screenResolution);
            return _instance;
        }
        
    }
}