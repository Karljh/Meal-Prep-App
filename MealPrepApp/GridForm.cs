using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace MealPrepApp
{
    public partial class GridForm : Form
    {
        public GridForm()
        { 
            InitializeComponent();
        }

        public void PopulateGridForm()
        {
            //Fills the DataGrid View
            string constr = @"Data Source=Karl-PC;Initial Catalog=MealsDB;Integrated Security=True";
            string slctAllQry = "select * from Meals";

            using SqlConnection sqlCon = new SqlConnection(constr);
            using SqlDataAdapter sqlAdapter = new SqlDataAdapter(slctAllQry, constr);
            DataTable table = new DataTable();
            sqlAdapter.Fill(table);
            this.dataGridView1.DataSource = table;
        }

        public void GridForm_Load(object sender, EventArgs e)
        {
            PopulateGridForm();
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            Form addMealForm = new AddMealFrom();
            addMealForm.Show();
        }


        private void btnGridFrom_Refresh_Click(object sender, EventArgs e)
        {
            Form GridForm = new GridForm();
            this.Close();
            GridForm.Show();
            PopulateGridForm();
        }

        private void btnDeletemeal_Click(object sender, EventArgs e)
        {
            try
            {
                string constr = @"Data Source=Karl-PC;Initial Catalog=MealsDB;Integrated Security=True";
                string deleteMealQry = "delete from Meals where MealName= '" + txtbxDeleteMeal.Text + "'";
                                

                SqlConnection sqlCon = new SqlConnection(constr);
                sqlCon.Open();
                SqlCommand sqlCmd = sqlCon.CreateCommand();
                sqlCmd.CommandText = deleteMealQry;
                sqlCmd.ExecuteNonQuery();
                sqlCon.Close();

                btnGridFrom_Refresh_Click(sender, e);
            }
            catch (Exception DeletMeal_EX)
            {
                MessageBox.Show(DeletMeal_EX.Message);
            }
            finally
            {
                InitializeComponent();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form HomePage = new HomePage();
            HomePage.Show();
        }
    }
}
