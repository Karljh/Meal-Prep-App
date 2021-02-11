using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MealPrepApp
{
    public partial class AddMealFrom : Form
    {
        public AddMealFrom()
        {
            InitializeComponent();
        }

        public void AddMeal()
        {
            try
            {
                string constr = @"Data Source=Karl-PC;Initial Catalog=MealsDB;Integrated Security=True";
                string addMealQry = "INSERT INTO Meals (MealName, Calories, Servings, Cost, Ingridients)" +
                                "VALUES('" + txtbxAdd_MealName.Text + "','" + txtbxAdd_Calories.Text + "','" + txtbxAdd_Servings.Text + "','" + txtbxAdd_Cost.Text + "','" + txtbxAdd_Ingridients.Text + "')";

                SqlConnection sqlCon = new SqlConnection(constr);
                sqlCon.Open();
                SqlCommand sqlCmd = sqlCon.CreateCommand();
                sqlCmd.CommandText = addMealQry;
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();

                
            }
            catch (Exception AddMeal_EX)
            {
                MessageBox.Show(AddMeal_EX.Message);
            }
            finally
            {
                InitializeComponent();
            }
            
        }

        public void btnAddMeal_Click(object sender, EventArgs e)
        {
            AddMeal();
            Form FAM = new AddMealFrom();
            this.Close();
            FAM.Show();
        }
    }
}
