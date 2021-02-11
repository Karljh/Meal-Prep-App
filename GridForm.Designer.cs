namespace MealPrepApp
{
    partial class GridForm
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
            this.btnToAddForm = new System.Windows.Forms.Button();
            this.btnGridFrom_Refresh = new System.Windows.Forms.Button();
            this.btnDeletemeal = new System.Windows.Forms.Button();
            this.txtbxDeleteMeal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(575, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(682, 671);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // btnToAddForm
            // 
            this.btnToAddForm.Location = new System.Drawing.Point(1559, 124);
            this.btnToAddForm.Name = "btnToAddForm";
            this.btnToAddForm.Size = new System.Drawing.Size(132, 61);
            this.btnToAddForm.TabIndex = 1;
            this.btnToAddForm.Text = "Add new meal";
            this.btnToAddForm.UseVisualStyleBackColor = true;
            this.btnToAddForm.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // btnGridFrom_Refresh
            // 
            this.btnGridFrom_Refresh.Location = new System.Drawing.Point(857, 803);
            this.btnGridFrom_Refresh.Name = "btnGridFrom_Refresh";
            this.btnGridFrom_Refresh.Size = new System.Drawing.Size(94, 29);
            this.btnGridFrom_Refresh.TabIndex = 2;
            this.btnGridFrom_Refresh.Text = "Refresh";
            this.btnGridFrom_Refresh.UseVisualStyleBackColor = true;
            this.btnGridFrom_Refresh.Click += new System.EventHandler(this.btnGridFrom_Refresh_Click);
            // 
            // btnDeletemeal
            // 
            this.btnDeletemeal.Location = new System.Drawing.Point(1697, 220);
            this.btnDeletemeal.Name = "btnDeletemeal";
            this.btnDeletemeal.Size = new System.Drawing.Size(107, 27);
            this.btnDeletemeal.TabIndex = 3;
            this.btnDeletemeal.Text = "Delete meal";
            this.btnDeletemeal.UseVisualStyleBackColor = true;
            this.btnDeletemeal.Click += new System.EventHandler(this.btnDeletemeal_Click);
            // 
            // txtbxDeleteMeal
            // 
            this.txtbxDeleteMeal.Location = new System.Drawing.Point(1559, 220);
            this.txtbxDeleteMeal.Name = "txtbxDeleteMeal";
            this.txtbxDeleteMeal.Size = new System.Drawing.Size(132, 27);
            this.txtbxDeleteMeal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1572, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Meal to delete";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(72, 803);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(94, 29);
            this.btnGoBack.TabIndex = 6;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1470, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Meal name";
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxDeleteMeal);
            this.Controls.Add(this.btnDeletemeal);
            this.Controls.Add(this.btnGridFrom_Refresh);
            this.Controls.Add(this.btnToAddForm);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GridForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GridForm";
            this.Load += new System.EventHandler(this.GridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnToAddForm;
        private System.Windows.Forms.Button btnGridFrom_Refresh;
        private System.Windows.Forms.Button btnDeletemeal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxDeleteMeal;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label label2;
    }
}