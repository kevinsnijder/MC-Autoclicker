using System.Diagnostics;

namespace MinecraftAutoClicker
{
   public static class ProcessManager
   {
      public static IEnumerable<IntPtr> GetProcessPointersByName(string processName)
      {
         var pointerList = new List<IntPtr>();
         var processList = Process.GetProcesses();
         foreach (Process P in processList)
         {
            if (P.ProcessName.Equals(processName))
            {
               pointerList.Add(P.MainWindowHandle);
            }
         }

         return pointerList;
      }
   }
}
