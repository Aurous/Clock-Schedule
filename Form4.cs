// Decompiled with JetBrains decompiler
// Type: Clock4School.Form4
// Assembly: Clock4School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 09B1CF10-0326-43F8-B308-8A802A05E20C
// Assembly location: C:\Users\ltrya\Desktop\Clock4School.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Clock4School
{
  public class Form4 : Form
  {
    private IContainer components = (IContainer) null;
    private Form1 frm;
    private string hour1;
    private string hour2;
    private string hour3;
    private string hour4;
    private string hour5;
    private string hour6;
    private string hour7;
    private string combob;
    public Label label1;
    public Timer timer1;

    public Form4(string cb)
    {
      this.combob = cb;
      this.frm = new Form1();
      this.BackColor = Color.White;
      this.TransparencyKey = Color.White;
      this.InitializeComponent();
    }

    [DllImport("winmm.dll")]
    private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

    private void Form4_Load(object sender, EventArgs e)
    {
      this.get_datas();
      this.frm.Hide();
    }

    private void get_datas()
    {
      string[] strArray = File.ReadAllLines("C://timer/" + this.combob + ".txt");
      if (strArray[0] == ".")
        this.hour1 = "";
      else if (strArray[0] != ".")
        this.hour1 = strArray[0];
      if (strArray[1] == ".")
        this.hour2 = "";
      else if (strArray[1] != ".")
        this.hour2 = strArray[1];
      if (strArray[2] == ".")
        this.hour3 = "";
      else if (strArray[2] != ".")
        this.hour3 = strArray[2];
      if (strArray[3] == ".")
        this.hour4 = "";
      else if (strArray[3] != ".")
        this.hour4 = strArray[3];
      if (strArray[4] == ".")
        this.hour5 = "";
      else if (strArray[4] != ".")
        this.hour5 = strArray[4];
      if (strArray[5] == ".")
        this.hour6 = "";
      else if (strArray[5] != ".")
        this.hour6 = strArray[5];
      if (strArray[6] == ".")
        this.hour7 = "";
      else if (strArray[6] != ".")
        this.hour7 = strArray[6];
      this.timer1.Start();
    }

    private void label1_Click(object sender, EventArgs e)
    {
      if (this.FormBorderStyle == FormBorderStyle.None)
      {
        this.FormBorderStyle = FormBorderStyle.Fixed3D;
      }
      else
      {
        if (this.FormBorderStyle != FormBorderStyle.Fixed3D)
          return;
        this.FormBorderStyle = FormBorderStyle.None;
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      string shortTimeString = DateTime.Now.ToShortTimeString();
      string str = shortTimeString.Remove(shortTimeString.Length - 3);
      this.label1.Text = str;
      if (str == this.hour1)
      {
        this.WindowState = FormWindowState.Normal;
        this.playmusic();
        this.timer1.Stop();
        if (MessageBox.Show("Its Now " + this.hour1, "Timer") == DialogResult.OK)
        {
          this.hour1 = "";
          this.timer1.Start();
          Form4.mciSendString("close MediaFile", (StringBuilder) null, 0, IntPtr.Zero);
        }
      }
      if (str == this.hour2)
      {
        this.WindowState = FormWindowState.Normal;
        this.playmusic();
        this.timer1.Stop();
        if (MessageBox.Show("Its Now " + this.hour2, "Timer") == DialogResult.OK)
        {
          this.hour2 = "";
          this.timer1.Start();
          Form4.mciSendString("close MediaFile", (StringBuilder) null, 0, IntPtr.Zero);
        }
      }
      if (str == this.hour3)
      {
        this.WindowState = FormWindowState.Normal;
        this.playmusic();
        this.timer1.Stop();
        if (MessageBox.Show("Its Now " + this.hour3, "Timer") == DialogResult.OK)
        {
          this.hour3 = "";
          this.timer1.Start();
          Form4.mciSendString("close MediaFile", (StringBuilder) null, 0, IntPtr.Zero);
        }
      }
      if (str == this.hour4)
      {
        this.WindowState = FormWindowState.Normal;
        this.playmusic();
        this.timer1.Stop();
        if (MessageBox.Show("Its Now " + this.hour4, "Timer") == DialogResult.OK)
        {
          this.hour4 = "";
          this.timer1.Start();
          Form4.mciSendString("close MediaFile", (StringBuilder) null, 0, IntPtr.Zero);
        }
      }
      if (str == this.hour5)
      {
        this.WindowState = FormWindowState.Normal;
        this.playmusic();
        this.timer1.Stop();
        if (MessageBox.Show("Its Now " + this.hour5, "Timer") == DialogResult.OK)
        {
          this.hour5 = "";
          this.timer1.Start();
          Form4.mciSendString("close MediaFile", (StringBuilder) null, 0, IntPtr.Zero);
        }
      }
      if (str == this.hour6)
      {
        this.WindowState = FormWindowState.Normal;
        this.playmusic();
        this.timer1.Stop();
        if (MessageBox.Show("Its Now " + this.hour6, "Timer") == DialogResult.OK)
        {
          this.hour6 = "";
          this.timer1.Start();
          Form4.mciSendString("close MediaFile", (StringBuilder) null, 0, IntPtr.Zero);
        }
      }
      if (!(str == this.hour7))
        return;
      this.WindowState = FormWindowState.Normal;
      this.playmusic();
      this.timer1.Stop();
      if (MessageBox.Show("Its Now " + this.hour7, "Timer") == DialogResult.OK)
      {
        this.hour7 = "";
        this.timer1.Start();
        Form4.mciSendString("close MediaFile", (StringBuilder) null, 0, IntPtr.Zero);
      }
    }

    private void playmusic()
    {
      Form4.mciSendString("open \"C://timer/mp3/sound.mp3\" type mpegvideo alias MediaFile", (StringBuilder) null, 0, IntPtr.Zero);
      Form4.mciSendString("play MediaFile", (StringBuilder) null, 0, IntPtr.Zero);
    }

    private void Form4_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.frm.Show();
      this.timer1.Stop();
      new Form1().Show((IWin32Window) this);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.label1 = new Label();
      this.timer1 = new Timer(this.components);
      this.SuspendLayout();
      this.label1.AutoSize = true;
      this.label1.Font = new Font("Rockwell Extra Bold", 27.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(134, 43);
      this.label1.TabIndex = 0;
      this.label1.Text = "00:00";
      this.label1.Click += new EventHandler(this.label1_Click);
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(158, 61);
      this.Controls.Add((Control) this.label1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form4";
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "CLOCK";
      this.FormClosing += new FormClosingEventHandler(this.Form4_FormClosing);
      this.Load += new EventHandler(this.Form4_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
