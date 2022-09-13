using System.Runtime.InteropServices;

namespace MinecraftAutoClicker
{
   public static class WindowManager
   {
      /// Adds the ability to show and hide windows
      [DllImport("user32.dll")]
      static extern bool ShowWindow(IntPtr processPointer, int nCmdShow);

      /// <summary>
      /// Minimizes a window
      /// </summary>
      public static void MinimizeWindow(IntPtr processPointer)
      {
         ShowWindow(processPointer, 2);
      }

      /// <summary>
      /// Maximizes a window
      /// </summary>
      public static void MaximizeWindow(IntPtr processPointer) 
      {
         ShowWindow(processPointer, 3);
      }
   }
}
