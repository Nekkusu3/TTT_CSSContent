// Decompiled with JetBrains decompiler
// Type: TTT_CSSContent.Program
// Assembly: TTT CSSContent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 799875EB-CDD8-4575-AE43-DCA24A7F954A
// Assembly location: D:\User\Documents\server, code etc\Programme\TTT CSSContent.exe

using System;
using System.Windows.Forms;

namespace TTT_CSSContent
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
