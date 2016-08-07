// Decompiled with JetBrains decompiler
// Type: Clock4School.Form3
// Assembly: Clock4School, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 09B1CF10-0326-43F8-B308-8A802A05E20C
// Assembly location: C:\Users\ltrya\Desktop\Clock4School.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Clock4School
{
  public class Form3 : Form
  {
    private IContainer components = (IContainer) null;
    private Label label1;
    private Button button1;
    public ComboBox comboBox1;

    public Form3()
    {
      this.InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (this.comboBox1.SelectedItem == null)
        return;
      Form form = (Form) new Form2(this.comboBox1.SelectedItem.ToString());
      this.Close();
    }

    private void Form3_Load(object sender, EventArgs e)
    {
      this.comboBox1.Items.Clear();
      foreach (string file in Directory.GetFiles("C://timer/"))
        this.comboBox1.Items.Add((object) file.Remove(file.Length - 4).Remove(0, 10));
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.comboBox1 = new ComboBox();
      this.label1 = new Label();
      this.button1 = new Button();
      this.SuspendLayout();
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new Point(12, 25);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new Size(138, 21);
      this.comboBox1.TabIndex = 0;
      this.label1.AutoSize = true;
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(138, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Choose A Schedule To Edit";
      this.button1.DialogResult = DialogResult.OK;
      this.button1.Location = new Point(33, 52);
      this.button1.Name = "button1";
      this.button1.Size = new Size(98, 23);
      this.button1.TabIndex = 2;
      this.button1.Text = "Edit Schedule";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(165, 87);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.comboBox1);
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form3";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Edit";
      this.Load += new EventHandler(this.Form3_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
