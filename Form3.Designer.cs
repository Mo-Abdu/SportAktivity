namespace SportAktivity
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showGrid_bt = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.search_bt = new System.Windows.Forms.Button();
            this.delete_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // showGrid_bt
            // 
            this.showGrid_bt.Location = new System.Drawing.Point(58, 339);
            this.showGrid_bt.Name = "showGrid_bt";
            this.showGrid_bt.Size = new System.Drawing.Size(144, 47);
            this.showGrid_bt.TabIndex = 1;
            this.showGrid_bt.Text = "Show";
            this.showGrid_bt.UseVisualStyleBackColor = true;
            this.showGrid_bt.Click += new System.EventHandler(this.showGrid_bt_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(586, 339);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(148, 26);
            this.searchTextBox.TabIndex = 2;
            // 
            // search_bt
            // 
            this.search_bt.Location = new System.Drawing.Point(586, 371);
            this.search_bt.Name = "search_bt";
            this.search_bt.Size = new System.Drawing.Size(148, 32);
            this.search_bt.TabIndex = 3;
            this.search_bt.Text = "Search";
            this.search_bt.UseVisualStyleBackColor = true;
            this.search_bt.Click += new System.EventHandler(this.search_bt_Click);
            // 
            // delete_bt
            // 
            this.delete_bt.Location = new System.Drawing.Point(270, 339);
            this.delete_bt.Name = "delete_bt";
            this.delete_bt.Size = new System.Drawing.Size(138, 47);
            this.delete_bt.TabIndex = 4;
            this.delete_bt.Text = "Delete";
            this.delete_bt.UseVisualStyleBackColor = true;
            this.delete_bt.Click += new System.EventHandler(this.delete_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(568, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search by Referee name";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_bt);
            this.Controls.Add(this.search_bt);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.showGrid_bt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Referee";
            this.Load += new System.EventHandler(this.Referee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showGrid_bt;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button search_bt;
        private System.Windows.Forms.Button delete_bt;
        private System.Windows.Forms.Label label1;
    }
}