namespace WordleHelpr
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.knownStuff = new System.Windows.Forms.TextBox();
            this.Inside = new System.Windows.Forms.TextBox();
            this.isNotIn = new System.Windows.Forms.TextBox();
            this.wordList = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.letterPlacement = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // knownStuff
            // 
            this.knownStuff.Location = new System.Drawing.Point(13, 22);
            this.knownStuff.Name = "knownStuff";
            this.knownStuff.Size = new System.Drawing.Size(100, 29);
            this.knownStuff.TabIndex = 1;
            this.knownStuff.Text = "_____";
            this.knownStuff.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Inside
            // 
            this.Inside.Location = new System.Drawing.Point(13, 57);
            this.Inside.Name = "Inside";
            this.Inside.Size = new System.Drawing.Size(100, 29);
            this.Inside.TabIndex = 2;
            this.Inside.Text = "~";
            this.Inside.TextChanged += new System.EventHandler(this.Inside_TextChanged);
            // 
            // isNotIn
            // 
            this.isNotIn.Location = new System.Drawing.Point(13, 92);
            this.isNotIn.Multiline = true;
            this.isNotIn.Name = "isNotIn";
            this.isNotIn.Size = new System.Drawing.Size(100, 91);
            this.isNotIn.TabIndex = 4;
            this.isNotIn.Text = "~";
            this.isNotIn.TextChanged += new System.EventHandler(this.isNotIn_TextChanged);
            // 
            // wordList
            // 
            this.wordList.BackColor = System.Drawing.Color.SeaGreen;
            this.wordList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordList.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.wordList.Location = new System.Drawing.Point(422, 12);
            this.wordList.Name = "wordList";
            this.wordList.Size = new System.Drawing.Size(366, 653);
            this.wordList.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox1.Location = new System.Drawing.Point(13, 189);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(280, 44);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Current Matches: ";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SeaGreen;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox2.Location = new System.Drawing.Point(120, 22);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(277, 29);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "<- Add Known, for unkonw put \'_\'";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox3.Location = new System.Drawing.Point(120, 57);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(287, 65);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "<- Add letters you know, but not the correct place";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.SeaGreen;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox4.Location = new System.Drawing.Point(120, 108);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(277, 55);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "<- Add Letters you know are not in the word";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.SeaGreen;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox6.Location = new System.Drawing.Point(13, 561);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(384, 104);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "In the Box above, enter the letters  with the points they cannot belong at,      " +
    "                       (letter, place1,place2,placeX...)";
            // 
            // letterPlacement
            // 
            this.letterPlacement.Location = new System.Drawing.Point(13, 279);
            this.letterPlacement.Multiline = true;
            this.letterPlacement.Name = "letterPlacement";
            this.letterPlacement.Size = new System.Drawing.Size(354, 276);
            this.letterPlacement.TabIndex = 14;
            this.letterPlacement.Text = "~";
            this.letterPlacement.TextChanged += new System.EventHandler(this.letterPlacement_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.SeaGreen;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox5.Location = new System.Drawing.Point(127, 225);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(280, 44);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Tilde  ~  means no answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 677);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.letterPlacement);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.wordList);
            this.Controls.Add(this.isNotIn);
            this.Controls.Add(this.Inside);
            this.Controls.Add(this.knownStuff);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Wordle Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox knownStuff;
        private System.Windows.Forms.TextBox Inside;
        private System.Windows.Forms.TextBox isNotIn;
        private System.Windows.Forms.TreeView wordList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox letterPlacement;
        private System.Windows.Forms.TextBox textBox5;
    }
}

