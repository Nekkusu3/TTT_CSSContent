// Decompiled with JetBrains decompiler
// Type: TTT_CSSContent.Form1
// Assembly: TTT CSSContent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 799875EB-CDD8-4575-AE43-DCA24A7F954A
// Assembly location: D:\User\Documents\server, code etc\Programme\TTT CSSContent.exe

using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using TTT_CSSContent.Properties;

namespace TTT_CSSContent
{
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private Button button1;
    private RichTextBox richTextBox1;
    private Button button3;
    private Button button2;
    private Button button4;
    private Button button5;
    private Button button6;

    public Form1() => this.InitializeComponent();

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    public void button1_Click(object sender, EventArgs e)
    {
      string text = this.richTextBox1.Text;
      string path = "c:\\Program Files\\Steam\\SteamApps\\Common\\Garrysmod";
      string str = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", (object) string.Empty).ToString() + "\\CSSContent.zip";
      if (!System.IO.File.Exists(str))
        this.button1.Text = "Files not found!";
      else if (!Directory.Exists(path))
      {
        if (Directory.Exists("c:\\Program Files (x86)\\Steam\\SteamApps\\Common\\Garrysmod\\"))
          path = "c:\\Program Files (x86)\\Steam\\SteamApps\\Common\\Garrysmod\\";
        else if (Directory.Exists(text))
          path = text;
        else
          this.button1.Text = "Custom Path not found!";
      }
      if (System.IO.File.Exists(str))
      {
        string destinationDirectoryName = path + "\\garrysmod\\addons";
        this.button1.Text = "Unzipping... Please wait";
        ZipFile.ExtractToDirectory(str, destinationDirectoryName);
        this.button1.Text = "Unzipping done! Press check";
      }
      else
        this.button1.Text = "Files not downloaded!";
    }

    private void DownloadURL(object sender, EventArgs e) => Process.Start("https://drive.google.com/file/d/12CzucLLTtZsPP8pxm2iipwc07M_9t6DP");

    public void button2_Click(object sender, EventArgs e)
    {
      string text = this.richTextBox1.Text;
      string path = "c:\\Program Files\\Steam\\SteamApps\\Common\\Garrysmod";
      if (!System.IO.File.Exists(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", (object) string.Empty).ToString() + "\\CSSContent.zip"))
        this.button1.Text = "Files not found!";
      else if (!Directory.Exists(path))
      {
        if (Directory.Exists("c:\\Program Files (x86)\\Steam\\SteamApps\\Common\\Garrysmod\\"))
          path = "c:\\Program Files (x86)\\Steam\\SteamApps\\Common\\Garrysmod\\";
        else if (Directory.Exists(text))
          path = text;
        else
          this.button1.Text = "Custom Path not found!";
      }
      if (System.IO.File.Exists(path + "\\garrysmod\\addons" + "\\CSSContent\\particles\\water_impact.pcf"))
        this.button2.Text = "Gucci";
      else
        this.button2.Text = "Files not found!!";
    }

    private void button4_click(object sender, EventArgs e)
    {
      string text = this.richTextBox1.Text;
      string path = "c:\\Program Files\\Steam\\SteamApps\\Common\\Garrysmod";
      if (!Directory.Exists(path))
      {
        if (Directory.Exists("c:\\Program Files (x86)\\Steam\\SteamApps\\Common\\Garrysmod\\"))
          path = "c:\\Program Files (x86)\\Steam\\SteamApps\\Common\\Garrysmod\\";
        else if (Directory.Exists(text))
          path = text;
        else
          this.button4.Text = "Custom Path not found!";
      }
      new WebClient().DownloadFile("https://harambe.ch/config.cfg", path + "\\garrysmod\\cfg\\config.cfg");
      this.button4.Text = "Binds changed!";
    }

    private void button5_click(object sender, EventArgs e) => Process.Start("https://www.harambe.ch");

    private void button6_click(object sender, EventArgs e) => Process.Start("https://steamcommunity.com/sharedfiles/filedetails/?id=2048190007");

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.button1 = new Button();
      this.richTextBox1 = new RichTextBox();
      this.button3 = new Button();
      this.button2 = new Button();
      this.button4 = new Button();
      this.button5 = new Button();
      this.button6 = new Button();
      this.SuspendLayout();
      this.button1.BackColor = System.Drawing.Color.Transparent;
      this.button1.FlatStyle = FlatStyle.Flat;
      this.button1.ForeColor = System.Drawing.Color.Magenta;
      this.button1.Location = new Point(12, 112);
      this.button1.Name = "button1";
      this.button1.Size = new Size(667, 74);
      this.button1.TabIndex = 0;
      this.button1.Text = "Unzip";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.richTextBox1.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.richTextBox1.ForeColor = System.Drawing.Color.Black;
      this.richTextBox1.Location = new Point(733, 112);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new Size(437, 74);
      this.richTextBox1.TabIndex = 1;
      this.richTextBox1.Text = "Custom Path\nPath should be: D:\\Documents\\Steam\\steamapps\\common\\GarrysMod\\";
      this.button3.BackColor = System.Drawing.Color.Transparent;
      this.button3.BackgroundImageLayout = ImageLayout.None;
      this.button3.FlatStyle = FlatStyle.Flat;
      this.button3.ForeColor = System.Drawing.Color.Magenta;
      this.button3.Location = new Point(12, 12);
      this.button3.Name = "button3";
      this.button3.Size = new Size(1158, 74);
      this.button3.TabIndex = 3;
      this.button3.Text = "Download Files";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new EventHandler(this.DownloadURL);
      this.button2.BackColor = System.Drawing.Color.Transparent;
      this.button2.FlatStyle = FlatStyle.Flat;
      this.button2.ForeColor = System.Drawing.Color.Magenta;
      this.button2.Location = new Point(12, 229);
      this.button2.Name = "button2";
      this.button2.Size = new Size(1158, 74);
      this.button2.TabIndex = 4;
      this.button2.Text = "Check";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button4.BackColor = System.Drawing.Color.Transparent;
      this.button4.FlatStyle = FlatStyle.Flat;
      this.button4.ForeColor = System.Drawing.Color.Magenta;
      this.button4.Location = new Point(0, 460);
      this.button4.Name = "button4";
      this.button4.Size = new Size(300, 100);
      this.button4.TabIndex = 5;
      this.button4.Text = "Binds";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new EventHandler(this.button4_click);
      this.button5.BackColor = System.Drawing.Color.Transparent;
      this.button5.FlatStyle = FlatStyle.Flat;
      this.button5.ForeColor = System.Drawing.Color.Magenta;
      this.button5.Location = new Point(888, 460);
      this.button5.Name = "button5";
      this.button5.Size = new Size(300, 100);
      this.button5.TabIndex = 6;
      this.button5.Text = "Made by Nekkusu\r\nMore at www.harambe.ch\r\n";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new EventHandler(this.button5_click);
      this.button6.BackColor = System.Drawing.Color.Transparent;
      this.button6.FlatStyle = FlatStyle.Flat;
      this.button6.ForeColor = System.Drawing.Color.Magenta;
      this.button6.Location = new Point(12, 337);
      this.button6.Name = "button6";
      this.button6.Size = new Size(1158, 74);
      this.button6.TabIndex = 7;
      this.button6.Text = "Steam Collection + Addons";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new EventHandler(this.button6_click);
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.BackColor = SystemColors.ControlLightLight;
      this.BackgroundImage = (Image) Resources._41412d88d4dc7ca6296876eaa2706aa1;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.ClientSize = new Size(1182, 613);
      this.Controls.Add((Control) this.button6);
      this.Controls.Add((Control) this.button5);
      this.Controls.Add((Control) this.button4);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.richTextBox1);
      this.Controls.Add((Control) this.button1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Form1);
      this.Text = "CSSContent + Binds";
      this.TopMost = true;
      this.TransparencyKey = System.Drawing.Color.Red;
      this.Load += new EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
    }
  }
}
