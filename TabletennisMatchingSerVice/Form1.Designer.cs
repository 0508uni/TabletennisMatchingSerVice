namespace TabletennisMatchingSerVice
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PlayerDataGrid = new System.Windows.Forms.DataGridView();
            this.名前DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出身地DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.実績DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.戦型DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.練習時間帯曜日DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.playerDataSet = new TabletennisMatchingSerVice.PlayerDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.読み出しToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PracticeTimeZone = new System.Windows.Forms.ComboBox();
            this.Birthplace = new System.Windows.Forms.ComboBox();
            this.Achievement = new System.Windows.Forms.ComboBox();
            this.Names = new System.Windows.Forms.TextBox();
            this.BattleType = new System.Windows.Forms.ComboBox();
            this.PracticePlace = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerDataGrid
            // 
            this.PlayerDataGrid.AutoGenerateColumns = false;
            this.PlayerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.名前DataGridViewTextBoxColumn,
            this.出身地DataGridViewTextBoxColumn,
            this.実績DataGridViewTextBoxColumn,
            this.戦型DataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.練習時間帯曜日DataGridViewTextBoxColumn});
            this.PlayerDataGrid.DataSource = this.playerDataTableBindingSource1;
            this.PlayerDataGrid.Location = new System.Drawing.Point(10, 27);
            this.PlayerDataGrid.Name = "PlayerDataGrid";
            this.PlayerDataGrid.RowTemplate.Height = 21;
            this.PlayerDataGrid.Size = new System.Drawing.Size(941, 160);
            this.PlayerDataGrid.TabIndex = 0;
            this.PlayerDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PlayerDataGrid_CellContentClick);
            // 
            // 名前DataGridViewTextBoxColumn
            // 
            this.名前DataGridViewTextBoxColumn.DataPropertyName = "名前";
            this.名前DataGridViewTextBoxColumn.HeaderText = "名前";
            this.名前DataGridViewTextBoxColumn.Name = "名前DataGridViewTextBoxColumn";
            // 
            // 出身地DataGridViewTextBoxColumn
            // 
            this.出身地DataGridViewTextBoxColumn.DataPropertyName = "出身地";
            this.出身地DataGridViewTextBoxColumn.HeaderText = "出身地";
            this.出身地DataGridViewTextBoxColumn.Name = "出身地DataGridViewTextBoxColumn";
            // 
            // 実績DataGridViewTextBoxColumn
            // 
            this.実績DataGridViewTextBoxColumn.DataPropertyName = "実績";
            this.実績DataGridViewTextBoxColumn.HeaderText = "実績";
            this.実績DataGridViewTextBoxColumn.Name = "実績DataGridViewTextBoxColumn";
            // 
            // 戦型DataGridViewTextBoxColumn
            // 
            this.戦型DataGridViewTextBoxColumn.DataPropertyName = "戦型";
            this.戦型DataGridViewTextBoxColumn.HeaderText = "戦型";
            this.戦型DataGridViewTextBoxColumn.Name = "戦型DataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "練習場所（都道府県）";
            this.dataGridViewTextBoxColumn1.HeaderText = "練習場所（都道府県）";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // 練習時間帯曜日DataGridViewTextBoxColumn
            // 
            this.練習時間帯曜日DataGridViewTextBoxColumn.DataPropertyName = "練習時間帯・曜日";
            this.練習時間帯曜日DataGridViewTextBoxColumn.HeaderText = "練習時間帯・曜日";
            this.練習時間帯曜日DataGridViewTextBoxColumn.Name = "練習時間帯曜日DataGridViewTextBoxColumn";
            // 
            // playerDataTableBindingSource1
            // 
            this.playerDataTableBindingSource1.DataMember = "playerDataTable";
            this.playerDataTableBindingSource1.DataSource = this.playerDataSet;
            // 
            // playerDataSet
            // 
            this.playerDataSet.DataSetName = "PlayerDataSet";
            this.playerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "卓球個人情報を入力してください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "名前";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "出身地";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "実績";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "戦型";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "練習場所（都道府県）";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "練習時間帯・曜日";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(98, 406);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(334, 32);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "登録";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButtonClicked);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(654, 406);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(299, 32);
            this.removeButton.TabIndex = 15;
            this.removeButton.Text = "消去";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButtonClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(963, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "ファイル";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.読み出しToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click_1);
            // 
            // 読み出しToolStripMenuItem
            // 
            this.読み出しToolStripMenuItem.Name = "読み出しToolStripMenuItem";
            this.読み出しToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.読み出しToolStripMenuItem.Text = "読み出し";
            this.読み出しToolStripMenuItem.Click += new System.EventHandler(this.読み出しToolStripMenuItem_Click_1);
            // 
            // playerDataTableBindingSource
            // 
            this.playerDataTableBindingSource.DataMember = "playerDataTable";
            this.playerDataTableBindingSource.DataSource = this.playerDataSet;
            // 
            // PracticeTimeZone
            // 
            this.PracticeTimeZone.FormattingEnabled = true;
            this.PracticeTimeZone.Location = new System.Drawing.Point(133, 363);
            this.PracticeTimeZone.Name = "PracticeTimeZone";
            this.PracticeTimeZone.Size = new System.Drawing.Size(334, 20);
            this.PracticeTimeZone.TabIndex = 18;
            // 
            // Birthplace
            // 
            this.Birthplace.FormattingEnabled = true;
            this.Birthplace.Location = new System.Drawing.Point(654, 238);
            this.Birthplace.Name = "Birthplace";
            this.Birthplace.Size = new System.Drawing.Size(299, 20);
            this.Birthplace.TabIndex = 19;
            // 
            // Achievement
            // 
            this.Achievement.FormattingEnabled = true;
            this.Achievement.Location = new System.Drawing.Point(133, 304);
            this.Achievement.Name = "Achievement";
            this.Achievement.Size = new System.Drawing.Size(334, 20);
            this.Achievement.TabIndex = 20;
            // 
            // Names
            // 
            this.Names.Location = new System.Drawing.Point(133, 240);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(334, 19);
            this.Names.TabIndex = 21;
            // 
            // BattleType
            // 
            this.BattleType.FormattingEnabled = true;
            this.BattleType.Location = new System.Drawing.Point(654, 304);
            this.BattleType.Name = "BattleType";
            this.BattleType.Size = new System.Drawing.Size(297, 20);
            this.BattleType.TabIndex = 22;
            // 
            // PracticePlace
            // 
            this.PracticePlace.FormattingEnabled = true;
            this.PracticePlace.Location = new System.Drawing.Point(654, 357);
            this.PracticePlace.Name = "PracticePlace";
            this.PracticePlace.Size = new System.Drawing.Size(297, 20);
            this.PracticePlace.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 450);
            this.Controls.Add(this.PracticePlace);
            this.Controls.Add(this.BattleType);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.Achievement);
            this.Controls.Add(this.Birthplace);
            this.Controls.Add(this.PracticeTimeZone);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PlayerDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.BindingSource playerDataTableBindingSource;
        private PlayerDataSet playerDataSet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 読み出しToolStripMenuItem;
        private System.Windows.Forms.BindingSource playerDataTableBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名前DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出身地DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 実績DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 戦型DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 練習時間帯曜日DataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox PracticeTimeZone;
        private System.Windows.Forms.ComboBox Birthplace;
        private System.Windows.Forms.ComboBox Achievement;
        private System.Windows.Forms.TextBox Names;
        private System.Windows.Forms.ComboBox BattleType;
        private System.Windows.Forms.ComboBox PracticePlace;
    }
}

