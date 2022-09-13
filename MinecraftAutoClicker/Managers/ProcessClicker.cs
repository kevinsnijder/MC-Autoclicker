using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MinecraftAutoClicker
{
   public class ProcessClicker
   {
      /// <summary>
      /// Constants for mousebutton identifiers
      /// </summary>
      private const int WM_LBUTTONDOWN = 0x0201;
      private const int WM_LBUTTONUP = 0x0202;
      private const int WM_RBUTTONDOWN = 0x0204;
      private const int WM_RBUTTONUP = 0x0205;

      /// Adds the ability to send mouseclicks
      [DllImport("user32.dll")]
      static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

      private int _totalKeyPresses;
      private IEnumerable<IntPtr>? _processPointers;

      /// <summary>
      /// Creates the processClicker
      /// </summary>
      public ProcessClicker()
      {
         _totalKeyPresses = 0;
      }

      /// <summary>
      /// Attaches to processes
      /// </summary>
      public void AttachToProcesses(IEnumerable<IntPtr> processes) 
      {
         _processPointers = processes;
      }

      public IEnumerable<IntPtr>? AttachedProcesses { get { return _processPointers; } }

      /// <summary>
      /// Performs a left click in all the processes
      /// </summary>
      public void LeftClick() 
      {
         if(_processPointers == null) return;

         foreach (IntPtr process in _processPointers) {
            PostMessage(process, WM_LBUTTONDOWN, 1, MakeLParam(70, 20));
            PostMessage(process, WM_LBUTTONUP, 0, MakeLParam(71, 21));
         }
         _totalKeyPresses++;
      }

      /// <summary>
      /// Performs a right click in all the processes
      /// </summary>
      public void RightClick() {
         if (_processPointers == null) return;

         foreach (IntPtr process in _processPointers)
         {
            PostMessage(process, WM_RBUTTONDOWN, 1, MakeLParam(70, 20));
            PostMessage(process, WM_RBUTTONUP, 0, MakeLParam(71, 21));
         }
         _totalKeyPresses++;
      }

      public int MakeLParam(int LoWord, int HiWord)
      {
         return (int)((HiWord << 16) | (LoWord & 0xFFFF));
      }

      public int TotalKeyPresses { get { return _totalKeyPresses; } }
   }
}
