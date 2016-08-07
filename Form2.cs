// Decompiled with JetBrains decompiler
// Type: Clock4School.Form2
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
  public class Form2 : Form
  {
    private IContainer components = (IContainer) null;
    private string h1;
    private string h2;
    private string h3;
    private string h4;
    private string h5;
    private string h6;
    private string h7;
    private Form3 frm3;
    private CheckBox checkBox1;
    private CheckBox checkBox2;
    private CheckBox checkBox3;
    private CheckBox checkBox4;
    private CheckBox checkBox5;
    private CheckBox checkBox6;
    private CheckBox checkBox7;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private TextBox textBox5;
    private TextBox textBox6;
    private TextBox textBox7;
    private Label label1;
    private Button button1;
    private Button button2;
    private Button button3;
    private TextBox textBox8;
    private Label label2;

    public Form2()
    {
      this.InitializeComponent();
      this.frm3 = new Form3();
    }

    public Form2(string name)
    {
    }

    private void load_edit()
    {
    }

    private void Form2_Load(object sender, EventArgs e)
    {
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox1.Checked)
      {
        this.textBox1.Enabled = true;
      }
      else
      {
        if (this.checkBox1.Checked)
          return;
        this.textBox1.Enabled = false;
      }
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox2.Checked)
      {
        this.textBox2.Enabled = true;
      }
      else
      {
        if (this.checkBox2.Checked)
          return;
        this.textBox2.Enabled = false;
      }
    }

    private void checkBox3_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox3.Checked)
      {
        this.textBox3.Enabled = true;
      }
      else
      {
        if (this.checkBox3.Checked)
          return;
        this.textBox3.Enabled = false;
      }
    }

    private void checkBox4_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox4.Checked)
      {
        this.textBox4.Enabled = true;
      }
      else
      {
        if (this.checkBox4.Checked)
          return;
        this.textBox4.Enabled = false;
      }
    }

    private void checkBox5_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox5.Checked)
      {
        this.textBox5.Enabled = true;
      }
      else
      {
        if (this.checkBox5.Checked)
          return;
        this.textBox5.Enabled = false;
      }
    }

    private void checkBox6_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox6.Checked)
      {
        this.textBox6.Enabled = true;
      }
      else
      {
        if (this.checkBox6.Checked)
          return;
        this.textBox6.Enabled = false;
      }
    }

    private void checkBox7_CheckedChanged(object sender, EventArgs e)
    {
      if (this.checkBox7.Checked)
      {
        this.textBox7.Enabled = true;
      }
      else
      {
        if (this.checkBox7.Checked)
          return;
        this.textBox7.Enabled = false;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (!(this.textBox8.Text != ""))
        return;
      this.saving();
    }

    private void saving()
    {
      if (this.textBox1.Enabled)
        this.h1 = this.textBox1.Text;
      else if (!this.textBox1.Enabled)
        this.h1 = ".";
      if (this.textBox2.Enabled)
        this.h2 = this.textBox2.Text;
      else if (!this.textBox2.Enabled)
        this.h2 = ".";
      if (this.textBox3.Enabled)
        this.h3 = this.textBox3.Text;
      else if (!this.textBox3.Enabled)
        this.h3 = ".";
      if (this.textBox4.Enabled)
        this.h4 = this.textBox4.Text;
      else if (!this.textBox4.Enabled)
        this.h4 = ".";
      if (this.textBox5.Enabled)
        this.h5 = this.textBox5.Text;
      else if (!this.textBox5.Enabled)
        this.h5 = ".";
      if (this.textBox6.Enabled)
        this.h6 = this.textBox6.Text;
      else if (!this.textBox6.Enabled)
        this.h6 = ".";
      if (this.textBox7.Enabled)
        this.h7 = this.textBox7.Text;
      else if (!this.textBox7.Enabled)
        this.h7 = ".";
      string[] contents = new string[7]
      {
        this.h1,
        this.h2,
        this.h3,
        this.h4,
        this.h5,
        this.h6,
        this.h7
      };
      if (!File.Exists("C:\\\\timer\\" + this.textBox8.Text + ".txt"))
      {
        DialogResult dialogResult = MessageBox.Show("Are you sure you want to add this Schedule?", "Add Schedule", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
          File.WriteAllLines("C:\\\\timer\\" + this.textBox8.Text + ".txt", contents);
          if (File.Exists("C:\\\\timer\\" + this.textBox8.Text + ".txt"))
          {
            int num = (int) MessageBox.Show("Schedule is now saved");
            this.Close();
          }
        }
        if (dialogResult == DialogResult.No)
        {
          int num1 = (int) MessageBox.Show("Schedule Not Saved");
        }
        this.Close();
      }
      else
      {
        if (!File.Exists("C:\\\\timer\\" + this.textBox8.Text + ".txt"))
          return;
        DialogResult dialogResult = MessageBox.Show("Over Write Schedule?", "", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
          File.WriteAllLines("C:\\\\timer\\" + this.textBox8.Text + ".txt", contents);
          this.Close();
        }
        else if (dialogResult != DialogResult.Yes)
        {
          int num = (int) MessageBox.Show("Schedule Not Over Written");
        }
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (this.frm3.ShowDialog((IWin32Window) this) == DialogResult.OK)
      {
        string @string = this.frm3.comboBox1.SelectedItem.ToString();
        if (@string != "")
        {
          string[] strArray = File.ReadAllLines("C:\\\\timer\\" + @string + ".txt");
          this.textBox8.Text = @string;
          if (strArray[0] == ".")
          {
            this.textBox1.Text = "";
            this.textBox1.Enabled = false;
          }
          else if (strArray[0] != ".")
          {
            this.textBox1.Text = strArray[0];
            this.textBox1.Enabled = true;
            this.checkBox1.Checked = true;
          }
          if (strArray[1] == ".")
          {
            this.textBox2.Text = "";
            this.textBox2.Enabled = false;
          }
          else if (strArray[1] != ".")
          {
            this.textBox2.Text = strArray[1];
            this.textBox2.Enabled = true;
            this.checkBox2.Checked = true;
          }
          if (strArray[2] == ".")
          {
            this.textBox3.Text = "";
            this.textBox3.Enabled = false;
          }
          else if (strArray[2] != ".")
          {
            this.textBox3.Text = strArray[2];
            this.textBox3.Enabled = true;
            this.checkBox3.Checked = true;
          }
          if (strArray[3] == ".")
          {
            this.textBox4.Text = "";
            this.textBox4.Enabled = false;
          }
          else if (strArray[3] != ".")
          {
            this.textBox4.Text = strArray[3];
            this.textBox4.Enabled = true;
            this.checkBox4.Checked = true;
          }
          if (strArray[4] == ".")
          {
            this.textBox5.Text = "";
            this.textBox5.Enabled = false;
          }
          else if (strArray[4] != ".")
          {
            this.textBox5.Text = strArray[4];
            this.textBox5.Enabled = true;
            this.checkBox5.Checked = true;
          }
          if (strArray[5] == ".")
          {
            this.textBox6.Text = "";
            this.textBox6.Enabled = false;
          }
          else if (strArray[5] != ".")
          {
            this.textBox6.Text = strArray[5];
            this.textBox6.Enabled = true;
            this.checkBox6.Checked = true;
          }
          if (strArray[6] == ".")
          {
            this.textBox7.Text = "";
            this.textBox7.Enabled = false;
          }
          else
          {
            if (!(strArray[6] != "."))
              return;
            this.textBox7.Text = strArray[6];
            this.textBox7.Enabled = true;
            this.checkBox7.Checked = true;
          }
        }
        else
        {
          int num = (int) MessageBox.Show("Schedule Not Loaded");
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("Schedule Not Loaded");
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form2));
      this.checkBox1 = new CheckBox();
      this.checkBox2 = new CheckBox();
      this.checkBox3 = new CheckBox();
      this.checkBox4 = new CheckBox();
      this.checkBox5 = new CheckBox();
      this.checkBox6 = new CheckBox();
      this.checkBox7 = new CheckBox();
      this.textBox1 = new TextBox();
      this.textBox2 = new TextBox();
      this.textBox3 = new TextBox();
      this.textBox4 = new TextBox();
      this.textBox5 = new TextBox();
      this.textBox6 = new TextBox();
      this.textBox7 = new TextBox();
      this.label1 = new Label();
      this.button1 = new Button();
      this.button2 = new Button();
      this.button3 = new Button();
      this.textBox8 = new TextBox();
      this.label2 = new Label();
      this.SuspendLayout();
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new Point(58, 112);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new Size(71, 17);
      this.checkBox1.TabIndex = 0;
      this.checkBox1.Text = "First Hour";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new Point(49, 138);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new Size(89, 17);
      this.checkBox2.TabIndex = 1;
      this.checkBox2.Text = "Second Hour";
      this.checkBox2.UseVisualStyleBackColor = true;
      this.checkBox2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
      this.checkBox3.AutoSize = true;
      this.checkBox3.Location = new Point(55, 164);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new Size(76, 17);
      this.checkBox3.TabIndex = 2;
      this.checkBox3.Text = "Third Hour";
      this.checkBox3.UseVisualStyleBackColor = true;
      this.checkBox3.CheckedChanged += new EventHandler(this.checkBox3_CheckedChanged);
      this.checkBox4.AutoSize = true;
      this.checkBox4.Location = new Point(52, 190);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new Size(82, 17);
      this.checkBox4.TabIndex = 3;
      this.checkBox4.Text = "Fourth Hour";
      this.checkBox4.UseVisualStyleBackColor = true;
      this.checkBox4.CheckedChanged += new EventHandler(this.checkBox4_CheckedChanged);
      this.checkBox5.AutoSize = true;
      this.checkBox5.Location = new Point(57, 216);
      this.checkBox5.Name = "checkBox5";
      this.checkBox5.Size = new Size(72, 17);
      this.checkBox5.TabIndex = 4;
      this.checkBox5.Text = "Fifth Hour";
      this.checkBox5.UseVisualStyleBackColor = true;
      this.checkBox5.CheckedChanged += new EventHandler(this.checkBox5_CheckedChanged);
      this.checkBox6.AutoSize = true;
      this.checkBox6.Location = new Point(56, 242);
      this.checkBox6.Name = "checkBox6";
      this.checkBox6.Size = new Size(75, 17);
      this.checkBox6.TabIndex = 5;
      this.checkBox6.Text = "Sixth Hour";
      this.checkBox6.UseVisualStyleBackColor = true;
      this.checkBox6.CheckedChanged += new EventHandler(this.checkBox6_CheckedChanged);
      this.checkBox7.AutoSize = true;
      this.checkBox7.Location = new Point(47, 268);
      this.checkBox7.Name = "checkBox7";
      this.checkBox7.Size = new Size(92, 17);
      this.checkBox7.TabIndex = 6;
      this.checkBox7.Text = "Seventh Hour";
      this.checkBox7.UseVisualStyleBackColor = true;
      this.checkBox7.CheckedChanged += new EventHandler(this.checkBox7_CheckedChanged);
      this.textBox1.Enabled = false;
      this.textBox1.Location = new Point(135, 110);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(100, 20);
      this.textBox1.TabIndex = 7;
      this.textBox2.Enabled = false;
      this.textBox2.Location = new Point(144, 136);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(100, 20);
      this.textBox2.TabIndex = 8;
      this.textBox3.Enabled = false;
      this.textBox3.Location = new Point(137, 162);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new Size(100, 20);
      this.textBox3.TabIndex = 9;
      this.textBox4.Enabled = false;
      this.textBox4.Location = new Point(140, 187);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new Size(100, 20);
      this.textBox4.TabIndex = 10;
      this.textBox5.Enabled = false;
      this.textBox5.Location = new Point(135, 214);
      this.textBox5.Name = "textBox5";
      this.textBox5.Size = new Size(100, 20);
      this.textBox5.TabIndex = 11;
      this.textBox6.Enabled = false;
      this.textBox6.Location = new Point(137, 240);
      this.textBox6.Name = "textBox6";
      this.textBox6.Size = new Size(100, 20);
      this.textBox6.TabIndex = 12;
      this.textBox7.Enabled = false;
      this.textBox7.Location = new Point(145, 266);
      this.textBox7.Name = "textBox7";
      this.textBox7.Size = new Size(100, 20);
      this.textBox7.TabIndex = 13;
      this.label1.Location = new Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new Size(268, 83);
      this.label1.TabIndex = 14;
      this.label1.Text = componentResourceManager.GetString("label1.Text");
      this.button1.Location = new Point(12, 291);
      this.button1.Name = "button1";
      this.button1.Size = new Size(84, 35);
      this.button1.TabIndex = 15;
      this.button1.Text = "Add Schedule As New";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button2.Location = new Point(102, 291);
      this.button2.Name = "button2";
      this.button2.Size = new Size(88, 35);
      this.button2.TabIndex = 16;
      this.button2.Text = "Edit Exsisting Schedule";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new EventHandler(this.button2_Click);
      this.button3.Location = new Point(196, 291);
      this.button3.Name = "button3";
      this.button3.Size = new Size(84, 35);
      this.button3.TabIndex = 17;
      this.button3.Text = "Cancel";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new EventHandler(this.button3_Click);
      this.textBox8.Location = new Point(141, 84);
      this.textBox8.Name = "textBox8";
      this.textBox8.Size = new Size(100, 20);
      this.textBox8.TabIndex = 19;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(52, 87);
      this.label2.Name = "label2";
      this.label2.Size = new Size(83, 13);
      this.label2.TabIndex = 20;
      this.label2.Text = "Schedule Name";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new Size(292, 336);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.textBox8);
      this.Controls.Add((Control) this.button3);
      this.Controls.Add((Control) this.button2);
      this.Controls.Add((Control) this.button1);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.textBox7);
      this.Controls.Add((Control) this.textBox6);
      this.Controls.Add((Control) this.textBox5);
      this.Controls.Add((Control) this.textBox4);
      this.Controls.Add((Control) this.textBox3);
      this.Controls.Add((Control) this.textBox2);
      this.Controls.Add((Control) this.textBox1);
      this.Controls.Add((Control) this.checkBox7);
      this.Controls.Add((Control) this.checkBox6);
      this.Controls.Add((Control) this.checkBox5);
      this.Controls.Add((Control) this.checkBox4);
      this.Controls.Add((Control) this.checkBox3);
      this.Controls.Add((Control) this.checkBox2);
      this.Controls.Add((Control) this.checkBox1);
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form2";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Add Schedule";
      this.Load += new EventHandler(this.Form2_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
