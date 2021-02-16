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
            this.lblMon = new System.Windows.Forms.Label();
            this.lblTue = new System.Windows.Forms.Label();
            this.lblWed = new System.Windows.Forms.Label();
            this.lblThur = new System.Windows.Forms.Label();
            this.lblFri = new System.Windows.Forms.Label();
            this.lblSun = new System.Windows.Forms.Label();
            this.lblSat = new System.Windows.Forms.Label();
            this.cmbxMon = new System.Windows.Forms.ComboBox();
            this.cmbxTue = new System.Windows.Forms.ComboBox();
            this.cmbxWed = new System.Windows.Forms.ComboBox();
            this.cmbxThur = new System.Windows.Forms.ComboBox();
            this.cmbxFri = new System.Windows.Forms.ComboBox();
            this.cmbxSun = new System.Windows.Forms.ComboBox();
            this.cmbxSat = new System.Windows.Forms.ComboBox();
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(449, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(947, 84);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnInsrtMealsWeek
            // 
            this.btnInsrtMealsWeek.Location = new System.Drawing.Point(802, 606);
            this.btnInsrtMealsWeek.Name = "btnInsrtMealsWeek";
            this.btnInsrtMealsWeek.Size = new System.Drawing.Size(239, 29);
            this.btnInsrtMealsWeek.TabIndex = 5;
            this.btnInsrtMealsWeek.Text = "Insert meals for the week";
            this.btnInsrtMealsWeek.UseVisualStyleBackColor = true;
            this.btnInsrtMealsWeek.Click += new System.EventHandler(this.btnInsrtMealsWeek_Click);
            // 
            // lblMon
            // 
            this.lblMon.AutoSize = true;
            this.lblMon.Location = new System.Drawing.Point(347, 484);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(63, 20);
            this.lblMon.TabIndex = 7;
            this.lblMon.Text = "Monday";
            // 
            // lblTue
            // 
            this.lblTue.AutoSize = true;
            this.lblTue.Location = new System.Drawing.Point(539, 484);
            this.lblTue.Name = "lblTue";
            this.lblTue.Size = new System.Drawing.Size(63, 20);
            this.lblTue.TabIndex = 8;
            this.lblTue.Text = "Tuesday";
            // 
            // lblWed
            // 
            this.lblWed.AutoSize = true;
            this.lblWed.Location = new System.Drawing.Point(705, 484);
            this.lblWed.Name = "lblWed";
            this.lblWed.Size = new System.Drawing.Size(85, 20);
            this.lblWed.TabIndex = 9;
            this.lblWed.Text = "Wednesday";
            // 
            // lblThur
            // 
            this.lblThur.AutoSize = true;
            this.lblThur.Location = new System.Drawing.Point(891, 484);
            this.lblThur.Name = "lblThur";
            this.lblThur.Size = new System.Drawing.Size(68, 20);
            this.lblThur.TabIndex = 10;
            this.lblThur.Text = "Thursday";
            // 
            // lblFri
            // 
            this.lblFri.AutoSize = true;
            this.lblFri.Location = new System.Drawing.Point(1077, 484);
            this.lblFri.Name = "lblFri";
            this.lblFri.Size = new System.Drawing.Size(49, 20);
            this.lblFri.TabIndex = 11;
            this.lblFri.Text = "Friday";
            // 
            // lblSun
            // 
            this.lblSun.AutoSize = true;
            this.lblSun.Location = new System.Drawing.Point(1251, 484);
            this.lblSun.Name = "lblSun";
            this.lblSun.Size = new System.Drawing.Size(57, 20);
            this.lblSun.TabIndex = 12;
            this.lblSun.Text = "Sunday";
            // 
            // lblSat
            // 
            this.lblSat.AutoSize = true;
            this.lblSat.Location = new System.Drawing.Point(1423, 484);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(67, 20);
            this.lblSat.TabIndex = 13;
            this.lblSat.Text = "Saturday";
            // 
            // cmbxMon
            // 
            this.cmbxMon.DataSource = this.lblSat.Controls;
            this.cmbxMon.FormattingEnabled = true;
            this.cmbxMon.Location = new System.Drawing.Point(304, 507);
            this.cmbxMon.Name = "cmbxMon";
            this.cmbxMon.Size = new System.Drawing.Size(151, 28);
            this.cmbxMon.TabIndex = 14;
            // 
            // cmbxTue
            // 
            this.cmbxTue.FormattingEnabled = true;
            this.cmbxTue.Location = new System.Drawing.Point(494, 507);
            this.cmbxTue.Name = "cmbxTue";
            this.cmbxTue.Size = new System.Drawing.Size(151, 28);
            this.cmbxTue.TabIndex = 15;
            // 
            // cmbxWed
            // 
            this.cmbxWed.FormattingEnabled = true;
            this.cmbxWed.Location = new System.Drawing.Point(673, 507);
            this.cmbxWed.Name = "cmbxWed";
            this.cmbxWed.Size = new System.Drawing.Size(151, 28);
            this.cmbxWed.TabIndex = 16;
            // 
            // cmbxThur
            // 
            this.cmbxThur.FormattingEnabled = true;
            this.cmbxThur.Location = new System.Drawing.Point(848, 507);
            this.cmbxThur.Name = "cmbxThur";
            this.cmbxThur.Size = new System.Drawing.Size(151, 28);
            this.cmbxThur.TabIndex = 17;
            // 
            // cmbxFri
            // 
            this.cmbxFri.FormattingEnabled = true;
            this.cmbxFri.Location = new System.Drawing.Point(1019, 507);
            this.cmbxFri.Name = "cmbxFri";
            this.cmbxFri.Size = new System.Drawing.Size(151, 28);
            this.cmbxFri.TabIndex = 18;
            // 
            // cmbxSun
            // 
            this.cmbxSun.FormattingEnabled = true;
            this.cmbxSun.Location = new System.Drawing.Point(1202, 507);
            this.cmbxSun.Name = "cmbxSun";
            this.cmbxSun.Size = new System.Drawing.Size(151, 28);
            this.cmbxSun.TabIndex = 19;
            // 
            // cmbxSat
            // 
            this.cmbxSat.FormattingEnabled = true;
            this.cmbxSat.Location = new System.Drawing.Point(1380, 507);
            this.cmbxSat.Name = "cmbxSat";
            this.cmbxSat.Size = new System.Drawing.Size(151, 28);
            this.cmbxSat.TabIndex = 20;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1929, 1033);
            this.Controls.Add(this.cmbxSat);
            this.Controls.Add(this.cmbxSun);
            this.Controls.Add(this.cmbxFri);
            this.Controls.Add(this.cmbxThur);
            this.Controls.Add(this.cmbxWed);
            this.Controls.Add(this.cmbxTue);
            this.Controls.Add(this.cmbxMon);
            this.Controls.Add(this.lblSat);
            this.Controls.Add(this.lblSun);
            this.Controls.Add(this.lblFri);
            this.Controls.Add(this.lblThur);
            this.Controls.Add(this.lblWed);
            this.Controls.Add(this.lblTue);
            this.Controls.Add(this.lblMon);
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
        private System.Windows.Forms.Label lblMon;
        private System.Windows.Forms.Label lblTue;
        private System.Windows.Forms.Label lblWed;
        private System.Windows.Forms.Label lblThur;
        private System.Windows.Forms.Label lblFri;
        private System.Windows.Forms.Label lblSun;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.ComboBox cmbxWed;
        private System.Windows.Forms.ComboBox cmbxThur;
        private System.Windows.Forms.ComboBox cmbxFri;
        private System.Windows.Forms.ComboBox cmbxSun;
        private System.Windows.Forms.ComboBox cmbxSat;
        public System.Windows.Forms.ComboBox cmbxMon;
        public System.Windows.Forms.ComboBox cmbxTue;
    }
}

