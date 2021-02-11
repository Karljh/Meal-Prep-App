namespace MealPrepApp
{
    partial class AddMealFrom
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
            this.lblAdd_MealName = new System.Windows.Forms.Label();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.lblAdd_Calories = new System.Windows.Forms.Label();
            this.lblAdd_Servings = new System.Windows.Forms.Label();
            this.lblAdd_Cost = new System.Windows.Forms.Label();
            this.txtbxAdd_MealName = new System.Windows.Forms.TextBox();
            this.txtbxAdd_Calories = new System.Windows.Forms.TextBox();
            this.txtbxAdd_Servings = new System.Windows.Forms.TextBox();
            this.txtbxAdd_Cost = new System.Windows.Forms.TextBox();
            this.lblAdd_Ingridients = new System.Windows.Forms.Label();
            this.txtbxAdd_Ingridients = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAdd_MealName
            // 
            this.lblAdd_MealName.AutoSize = true;
            this.lblAdd_MealName.Location = new System.Drawing.Point(69, 61);
            this.lblAdd_MealName.Name = "lblAdd_MealName";
            this.lblAdd_MealName.Size = new System.Drawing.Size(86, 20);
            this.lblAdd_MealName.TabIndex = 0;
            this.lblAdd_MealName.Text = "Meal Name";
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Location = new System.Drawing.Point(329, 371);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(154, 29);
            this.btnAddMeal.TabIndex = 1;
            this.btnAddMeal.Text = "Add This Meal";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // lblAdd_Calories
            // 
            this.lblAdd_Calories.AutoSize = true;
            this.lblAdd_Calories.Location = new System.Drawing.Point(69, 104);
            this.lblAdd_Calories.Name = "lblAdd_Calories";
            this.lblAdd_Calories.Size = new System.Drawing.Size(62, 20);
            this.lblAdd_Calories.TabIndex = 2;
            this.lblAdd_Calories.Text = "Calories";
            // 
            // lblAdd_Servings
            // 
            this.lblAdd_Servings.AutoSize = true;
            this.lblAdd_Servings.Location = new System.Drawing.Point(69, 150);
            this.lblAdd_Servings.Name = "lblAdd_Servings";
            this.lblAdd_Servings.Size = new System.Drawing.Size(64, 20);
            this.lblAdd_Servings.TabIndex = 3;
            this.lblAdd_Servings.Text = "Servings";
            // 
            // lblAdd_Cost
            // 
            this.lblAdd_Cost.AutoSize = true;
            this.lblAdd_Cost.Location = new System.Drawing.Point(69, 196);
            this.lblAdd_Cost.Name = "lblAdd_Cost";
            this.lblAdd_Cost.Size = new System.Drawing.Size(38, 20);
            this.lblAdd_Cost.TabIndex = 4;
            this.lblAdd_Cost.Text = "Cost";
            // 
            // txtbxAdd_MealName
            // 
            this.txtbxAdd_MealName.Location = new System.Drawing.Point(215, 58);
            this.txtbxAdd_MealName.Name = "txtbxAdd_MealName";
            this.txtbxAdd_MealName.Size = new System.Drawing.Size(125, 27);
            this.txtbxAdd_MealName.TabIndex = 5;
            // 
            // txtbxAdd_Calories
            // 
            this.txtbxAdd_Calories.Location = new System.Drawing.Point(215, 101);
            this.txtbxAdd_Calories.Name = "txtbxAdd_Calories";
            this.txtbxAdd_Calories.Size = new System.Drawing.Size(125, 27);
            this.txtbxAdd_Calories.TabIndex = 5;
            // 
            // txtbxAdd_Servings
            // 
            this.txtbxAdd_Servings.Location = new System.Drawing.Point(215, 147);
            this.txtbxAdd_Servings.Name = "txtbxAdd_Servings";
            this.txtbxAdd_Servings.Size = new System.Drawing.Size(125, 27);
            this.txtbxAdd_Servings.TabIndex = 5;
            // 
            // txtbxAdd_Cost
            // 
            this.txtbxAdd_Cost.Location = new System.Drawing.Point(215, 193);
            this.txtbxAdd_Cost.Name = "txtbxAdd_Cost";
            this.txtbxAdd_Cost.Size = new System.Drawing.Size(125, 27);
            this.txtbxAdd_Cost.TabIndex = 5;
            // 
            // lblAdd_Ingridients
            // 
            this.lblAdd_Ingridients.AutoSize = true;
            this.lblAdd_Ingridients.Location = new System.Drawing.Point(69, 241);
            this.lblAdd_Ingridients.Name = "lblAdd_Ingridients";
            this.lblAdd_Ingridients.Size = new System.Drawing.Size(79, 20);
            this.lblAdd_Ingridients.TabIndex = 6;
            this.lblAdd_Ingridients.Text = "Ingridients";
            // 
            // txtbxAdd_Ingridients
            // 
            this.txtbxAdd_Ingridients.Location = new System.Drawing.Point(215, 238);
            this.txtbxAdd_Ingridients.Name = "txtbxAdd_Ingridients";
            this.txtbxAdd_Ingridients.Size = new System.Drawing.Size(125, 27);
            this.txtbxAdd_Ingridients.TabIndex = 7;
            // 
            // AddMealFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.txtbxAdd_Ingridients);
            this.Controls.Add(this.lblAdd_Ingridients);
            this.Controls.Add(this.txtbxAdd_Cost);
            this.Controls.Add(this.txtbxAdd_Servings);
            this.Controls.Add(this.txtbxAdd_Calories);
            this.Controls.Add(this.txtbxAdd_MealName);
            this.Controls.Add(this.lblAdd_Cost);
            this.Controls.Add(this.lblAdd_Servings);
            this.Controls.Add(this.lblAdd_Calories);
            this.Controls.Add(this.btnAddMeal);
            this.Controls.Add(this.lblAdd_MealName);
            this.Name = "AddMealFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMealFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd_MealName;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.Label lblAdd_Calories;
        private System.Windows.Forms.Label lblAdd_Servings;
        private System.Windows.Forms.Label lblAdd_Cost;
        private System.Windows.Forms.TextBox txtbxAdd_MealName;
        private System.Windows.Forms.TextBox txtbxAdd_Calories;
        private System.Windows.Forms.TextBox txtbxAdd_Servings;
        private System.Windows.Forms.TextBox txtbxAdd_Cost;
        private System.Windows.Forms.Label bl;
        private System.Windows.Forms.Label lblAdd_Ingridients;
        private System.Windows.Forms.TextBox txtbxAdd_Ingridients;
    }
}