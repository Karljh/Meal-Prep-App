namespace MealPrepApp
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnMeals = new System.Windows.Forms.Button();
            this.lblConnStat = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInsrtMealsWeek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(651, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 100);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meal Prep for the week";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMeals
            // 
            this.btnMeals.Location = new System.Drawing.Point(838, 863);
            this.btnMeals.Name = "btnMeals";
            this.btnMeals.Size = new System.Drawing.Size(178, 73);
            this.btnMeals.TabIndex = 2;
            this.btnMeals.Text = "All meals";
            this.btnMeals.UseVisualStyleBackColor = true;
            this.btnMeals.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblConnStat
            // 
            this.lblConnStat.AutoSize = true;
            this.lblConnStat.Location = new System.Drawing.Point(815, 12);
            this.lblConnStat.Name = "lblConnStat";
            this.lblConnStat.Size = new System.Drawing.Size(0, 20);
            this.lblConnStat.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(467, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(907, 84);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnInsrtMealsWeek
            // 
            this.btnInsrtMealsWeek.Location = new System.Drawing.Point(815, 444);
            this.btnInsrtMealsWeek.Name = "btnInsrtMealsWeek";
            this.btnInsrtMealsWeek.Size = new System.Drawing.Size(239, 29);
            this.btnInsrtMealsWeek.TabIndex = 5;
            this.btnInsrtMealsWeek.Text = "Insert meals for the week";
            this.btnInsrtMealsWeek.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1929, 1033);
            this.Controls.Add(this.btnInsrtMealsWeek);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblConnStat);
            this.Controls.Add(this.btnMeals);
            this.Controls.Add(this.label2);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMeals;
        private System.Windows.Forms.Label lblConnStat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInsrtMealsWeek;
    }
}

