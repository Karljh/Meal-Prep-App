using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MealPrepApp
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form GridForm = new GridForm();
            this.Hide();
            GridForm.Show();
           
        }

        public void PopulateGridForm()
        {
            //Fills the DataGrid View
            string constr = @"Data Source=Karl-PC;Initial Catalog=MealsDB;Integrated Security=True";
            string slctAllQry2 = "select * from Weeks_Meals";

            using SqlConnection sqlCon = new SqlConnection(constr);
            using SqlDataAdapter sqlAdapter = new SqlDataAdapter(slctAllQry2, constr);
            DataTable table = new DataTable();
            sqlAdapter.Fill(table);
            this.dataGridView1.DataSource = table;
        }


        //Tests the connection to the database and catches an exception aswell as Changes a Label if connected or not.
        private SqlConnection connection;
        public void CheckConnection()
        {
            try
            {
                connection = new SqlConnection(@"Data Source=Karl-PC;Initial Catalog=MealsDB;Integrated Security=True");
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    lblConnStat.Text = "Database Connected";
                    lblConnStat.ForeColor = System.Drawing.Color.Green;
                }
                connection.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                lblConnStat.Text = "Database Not Connected";
                lblConnStat.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateGridForm();
            CheckConnection();
            PopulateComboBox();
        }

        public void PopulateComboBox()
        {
            string constr = @"Data Source=Karl-PC;Initial Catalog=MealsDB;Integrated Security=True";
            string slctMealQry = "select MealName from Meals";

            using SqlConnection sqlCon = new SqlConnection(constr);
            using SqlDataAdapter sqlAdapter = new SqlDataAdapter(slctMealQry, constr);
            DataTable table = new DataTable();
            sqlAdapter.Fill(table);

            cmbxMon.DataSource = table;
            cmbxMon.DisplayMember = "MealName";
            cmbxMon.ValueMember = "MealName";

            cmbxTue.DataSource = table;
            cmbxTue.DisplayMember = "MealName";
            cmbxTue.ValueMember = "MealName";

            cmbxWed.DataSource = table;
            cmbxWed.DisplayMember = "MealName";
            cmbxWed.ValueMember = "MealName";

            cmbxThur.DataSource = table;
            cmbxThur.DisplayMember = "MealName";
            cmbxThur.ValueMember = "MealName";

            cmbxFri.DataSource = table;
            cmbxFri.DisplayMember = "MealName";
            cmbxFri.ValueMember = "MealName";

            cmbxSat.DataSource = table;
            cmbxSat.DisplayMember = "MealName";
            cmbxSat.ValueMember = "MealName";

            cmbxSun.DataSource = table;
            cmbxSun.DisplayMember = "MealName";
            cmbxSun.ValueMember = "MealName";

        }

        private void btnInsrtMealsWeek_Click(object sender, EventArgs e)
        {
            //Fills the DataGrid View
            string constr = @"Data Source=Karl-PC;Initial Catalog=MealsDB;Integrated Security=True";
            string insrtQry = "INSERT INTO Weeks_Meals (Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday)" +
                                "VALUES('" + cmbxMon.Text + "','" + cmbxTue.Text + "','" + cmbxWed.Text + "','" + cmbxThur.Text + "','" + cmbxFri.Text + "','" + cmbxSat.Text + "','" + cmbxSun.Text + "')"; ;

            using SqlConnection sqlCon = new SqlConnection(constr);
            using SqlDataAdapter sqlAdapter = new SqlDataAdapter(insrtQry, constr);
            DataTable table = new DataTable();
            sqlAdapter.Fill(table);
            this.dataGridView1.DataSource = table;
        }
    }
}
