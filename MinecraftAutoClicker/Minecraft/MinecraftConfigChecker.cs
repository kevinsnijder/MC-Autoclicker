namespace MinecraftAutoClicker.Minecraft
{
   /// <summary>
   /// Class to check and replace values in the minecraft configuration file
   /// </summary>
   public class MinecraftConfigChecker
   {
      private bool? _requireFocusLostReplacement { get; set; }
      private string _configPath { get; set; }

      /// <summary>
      /// Initializes the checker
      /// </summary>
      public MinecraftConfigChecker(string? customConfigPath = null)
      {
         if (string.IsNullOrEmpty(customConfigPath))
            _configPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\options.txt";
         else
            _configPath = customConfigPath;
      }

      /// <summary>
      /// The path to the .minecraft options.txt
      /// </summary>
      public string ConfigPath { get { return _configPath; } }

      /// <summary>
      /// Checks if the pauseOnFocusLost needs to be replaced
      /// </summary>
      public bool RequireFocusLostReplacement { 
         get {
            if (_requireFocusLostReplacement == null)
               _requireFocusLostReplacement = ConfigRequiresFocusLostReplacement();
            return (bool)_requireFocusLostReplacement;
         } 
      }

      /// <summary>
      /// Checks if the pauseOnFocusLost needs to be replaced
      /// </summary>
      private bool ConfigRequiresFocusLostReplacement()
      {
         foreach (string line in File.ReadLines(_configPath))
         {
            if (line.Contains("pauseOnLostFocus:true"))
               return true;
         }
         return false;
      }

      /// <summary>
      /// Sets pauseOnFocusLost to false
      /// </summary>
      public bool ReplacePauseOnFocusLost() 
      {
         if (!RequireFocusLostReplacement)
            return false;

         string text = File.ReadAllText(_configPath);
         text = text.Replace("pauseOnLostFocus:true", "pauseOnLostFocus:false");
         File.WriteAllText(_configPath, text);
         return true;
      }
   }
}
