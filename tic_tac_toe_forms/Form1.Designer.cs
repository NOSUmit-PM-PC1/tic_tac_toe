namespace tic_tac_toe_forms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExitGame = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemScoreGame = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridGame = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGame)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNewGame,
            this.MenuItemScoreGame,
            this.MenuItemExitGame});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // MenuItemNewGame
            // 
            this.MenuItemNewGame.Name = "MenuItemNewGame";
            this.MenuItemNewGame.Size = new System.Drawing.Size(180, 22);
            this.MenuItemNewGame.Text = "Новая";
            this.MenuItemNewGame.Click += new System.EventHandler(this.MenuItemNewGame_Click);
            // 
            // MenuItemExitGame
            // 
            this.MenuItemExitGame.Name = "MenuItemExitGame";
            this.MenuItemExitGame.Size = new System.Drawing.Size(180, 22);
            this.MenuItemExitGame.Text = "Выход";
            // 
            // MenuItemScoreGame
            // 
            this.MenuItemScoreGame.Name = "MenuItemScoreGame";
            this.MenuItemScoreGame.Size = new System.Drawing.Size(180, 22);
            this.MenuItemScoreGame.Text = "Результаты";
            // 
            // dataGridGame
            // 
            this.dataGridGame.AllowUserToAddRows = false;
            this.dataGridGame.AllowUserToDeleteRows = false;
            this.dataGridGame.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGame.ColumnHeadersVisible = false;
            this.dataGridGame.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridGame.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridGame.Location = new System.Drawing.Point(12, 37);
            this.dataGridGame.Name = "dataGridGame";
            this.dataGridGame.ReadOnly = true;
            this.dataGridGame.RowHeadersVisible = false;
            this.dataGridGame.RowTemplate.Height = 50;
            this.dataGridGame.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridGame.Size = new System.Drawing.Size(359, 311);
            this.dataGridGame.TabIndex = 1;
            this.dataGridGame.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGame_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 369);
            this.Controls.Add(this.dataGridGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNewGame;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExitGame;
        private System.Windows.Forms.ToolStripMenuItem MenuItemScoreGame;
        private System.Windows.Forms.DataGridView dataGridGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

