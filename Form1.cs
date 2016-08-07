// Decompiled with JetBrains decompiler
// Type: Clock4School.Form1
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
  public class Form1 : Form
  {
    private IContainer components = (IContainer) null;
    private Form4 frm4;
    private string hour1;
    private string hour2;
    private string hour3;
    private string hour4;
    private string hour5;
    private string hour6;
    private string hour7;
    private ComboBox comboBox1;
    private Button button1;
    private Button button2;
    public Timer timer1;

    public Form1()
    {
      this.InitializeComponent();
    }

    [DllImport("winmm.dll")]
    private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

    private void Form1_Load(object sender, EventArgs e)
    {
      if (Directory.Exists("C://timer/"))
      {
        this.comboBox1.Items.Clear();
        foreach (string file in Directory.GetFiles("C://timer/"))
          this.comboBox1.Items.Add((object) file.Remove(file.Length - 4).Remove(0, 10));
      }
      else
      {
        if (Directory.Exists("C://timer/"))
          return;
        Directory.CreateDirectory("C://timer/");
        Directory.CreateDirectory("C://timer/mp3/");
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int num = (int) new Form2().ShowDialog((IWin32Window) this);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.comboBox1.SelectedIndex > -1)
      {
        Form4 form4 = new Form4(this.comboBox1.SelectedItem.ToString());
        this.Hide();
        form4.Show((IWin32Window) this);
      }
      else
      {
        int num = (int) MessageBox.Show("Please Select A Schedule");
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void comboBox1_DropDown(object sender, EventArgs e)
    {
      this.comboBox1.Items.Clear();
      foreach (string file in Directory.GetFiles("C://timer/"))
        this.comboBox1.Items.Add((object) file.Remove(file.Length - 4).Remove(0, 10));
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      e.Cancel = false;
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
      this.comboBox1 = new ComboBox();
      this.button1 = new Button();
      this.button2 = new Button();
      this.timer1 = new Timer(this.components);
      this.SuspendLayout();
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new Point(12, 12);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(182, 21);
      this.comboBox1.TabIndex = 0;
      this.comboBox1.DropDown += new EventHandler(this.comboBox1_DropDown);
      this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
      this.button1.Location = new Point(12, 39);
      this.button1.Name = "button1";
      this.button1.Size = new Size(88, 48);
      this.button1.TabIndex = 1;
      this.button1.Text = "Add Times To Schedule";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(106, 39);
      this.button2.Name = "button2";
      this.button2.Size = new Size(88, 48);
      this.button2.TabIndex = 2;
      this.button2.Text = "Start Clock With Selected Schedule";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(205, 98);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.comboBox1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.ShowIcon = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Clock4School";
      this.TopMost = true;
      this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
    }
  }
}
