namespace SportAktivity
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
            this.showGrid_bt = new System.Windows.Forms.Button();
            this.OpenForm2_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showGrid_bt
            // 
            this.showGrid_bt.Location = new System.Drawing.Point(103, 503);
            this.showGrid_bt.Name = "showGrid_bt";
            this.showGrid_bt.Size = new System.Drawing.Size(140, 56);
            this.showGrid_bt.TabIndex = 1;
            this.showGrid_bt.Text = "Show";
            this.showGrid_bt.UseVisualStyleBackColor = true;
            this.showGrid_bt.Click += new System.EventHandler(this.showGrid_bt_Click);
            // 
            // OpenForm2_button
            // 
            this.OpenForm2_button.Location = new System.Drawing.Point(721, 494);
            this.OpenForm2_button.Name = "OpenForm2_button";
            this.OpenForm2_button.Size = new System.Drawing.Size(122, 56);
            this.OpenForm2_button.TabIndex = 4;
            this.OpenForm2_button.Text = "Go to Players";
            this.OpenForm2_button.UseVisualStyleBackColor = true;
            this.OpenForm2_button.Click += new System.EventHandler(this.OpenForm2_button_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(1010, 339);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 596);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OpenForm2_button);
            this.Controls.Add(this.showGrid_bt);
            this.Name = "Form1";
            this.Text = "game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button showGrid_bt;
        private System.Windows.Forms.Button OpenForm2_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

