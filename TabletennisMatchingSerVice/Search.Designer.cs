namespace TabletennisMatchingSerVice
{
    partial class Search
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
            this.Search1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.areaBox = new System.Windows.Forms.ComboBox();
            this.areaBox1 = new System.Windows.Forms.ComboBox();
            this.areaBox2 = new System.Windows.Forms.ComboBox();
            this.areaBox3 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Search1
            // 
            this.Search1.Location = new System.Drawing.Point(454, 379);
            this.Search1.Name = "Search1";
            this.Search1.Size = new System.Drawing.Size(122, 37);
            this.Search1.TabIndex = 0;
            this.Search1.Text = "検索";
            this.Search1.UseVisualStyleBackColor = true;
            this.Search1.Click += new System.EventHandler(this.Search1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 19);
            this.textBox1.TabIndex = 1;
            // 
            // areaBox
            // 
            this.areaBox.FormattingEnabled = true;
            this.areaBox.Location = new System.Drawing.Point(105, 305);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(318, 20);
            this.areaBox.TabIndex = 2;
            this.areaBox.Text = "練習場所";
            this.areaBox.SelectedIndexChanged += new System.EventHandler(this.CitySelected);
            // 
            // areaBox1
            // 
            this.areaBox1.FormattingEnabled = true;
            this.areaBox1.Location = new System.Drawing.Point(587, 305);
            this.areaBox1.Name = "areaBox1";
            this.areaBox1.Size = new System.Drawing.Size(287, 20);
            this.areaBox1.TabIndex = 3;
            this.areaBox1.Text = "練習時間帯・曜日";
            this.areaBox1.SelectedIndexChanged += new System.EventHandler(this.areaBox1_SelectedIndexChanged);
            // 
            // areaBox2
            // 
            this.areaBox2.FormattingEnabled = true;
            this.areaBox2.Location = new System.Drawing.Point(105, 211);
            this.areaBox2.Name = "areaBox2";
            this.areaBox2.Size = new System.Drawing.Size(318, 20);
            this.areaBox2.TabIndex = 4;
            this.areaBox2.Text = "実績";
            this.areaBox2.SelectedIndexChanged += new System.EventHandler(this.areaBox2_SelectedIndexChanged);
            // 
            // areaBox3
            // 
            this.areaBox3.FormattingEnabled = true;
            this.areaBox3.Location = new System.Drawing.Point(587, 211);
            this.areaBox3.Name = "areaBox3";
            this.areaBox3.Size = new System.Drawing.Size(287, 20);
            this.areaBox3.TabIndex = 5;
            this.areaBox3.Text = "戦型";
            this.areaBox3.SelectedIndexChanged += new System.EventHandler(this.areaBox3_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(51, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 172);
            this.listBox1.TabIndex = 6;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.areaBox3);
            this.Controls.Add(this.areaBox2);
            this.Controls.Add(this.areaBox1);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search1);
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox areaBox;
        private System.Windows.Forms.ComboBox areaBox1;
        private System.Windows.Forms.ComboBox areaBox2;
        private System.Windows.Forms.ComboBox areaBox3;
        private System.Windows.Forms.ListBox listBox1;
    }
}