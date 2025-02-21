using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelIndicator4.ForeColor = System.Drawing.Color.Red;
            labelIndicator1.ForeColor = System.Drawing.Color.Black;
            labelIndicator2.ForeColor = System.Drawing.Color.Black;
            labelIndicator3.ForeColor = System.Drawing.Color.Black;

            panel4.Visible = true;
            //panel3.Visible = false;
            //panel2.Visible = false;
            //panel1.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelIndicator1.ForeColor = System.Drawing.Color.Red;
            labelIndicator2.ForeColor = System.Drawing.Color.Black;
            labelIndicator3.ForeColor = System.Drawing.Color.Black;
            labelIndicator4.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            labelIndicator2.ForeColor = System.Drawing.Color.Red;
            labelIndicator1.ForeColor = System.Drawing.Color.Black;
            labelIndicator3.ForeColor = System.Drawing.Color.Black;
            labelIndicator4.ForeColor = System.Drawing.Color.Black;

            //panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void btnFullHistory_Click(object sender, EventArgs e)
        {
            labelIndicator3.ForeColor = System.Drawing.Color.Red;
            labelIndicator4.ForeColor = System.Drawing.Color.Black;
            labelIndicator1.ForeColor = System.Drawing.Color.Black;
            labelIndicator2.ForeColor = System.Drawing.Color.Black;

            panel3.Visible = true;
            //panel1.Visible = false;
            //panel2.Visible = false;
            //panel4.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=hospital;Integrated Security=True;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from AddPatient inner join PatientMore on AddPatient.pid = PatientMore.pid";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView2.DataSource = DS.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //panel1.Visible = false;
            //panel2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //private void btnSave_Click(object sender, EventArgs e)
        //{
        //    String name = txtName.Text;
        //    String address = txtAddress.Text;
        //    Int64 contact = Convert.ToInt64(txtContact.Text);
        //    int age = Convert.ToInt32(txtAge.Text);
        //    String gender = comboGender.Text;
        //    String blood = txtBlood.Text;
        //    string any = txtAny.Text;
        //    int pid = Convert.ToInt32(txtPid.Text);

        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = "data source = (localdb)\\MsSqlLocalDb;Initial Catalog=hospital;Integrated Security=true;MultipleActiveResultSets=true";
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;

        //    cmd.CommandText = "insert into AddPatient values('" + name + "','" + address + "','" + contact + "','" + age + "','" + gender + "','" + blood + "','" + any + "','" + pid + "');


        //    SqlDataAdapter DA = new SqlDataAdapter(cmd);
        //    DataSet DS = new DataSet();
        //    DA.Fill(DS);
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Retrieve input values from the form controls
            string name = txtName.Text;
            string Full_Address = txtAddress.Text;
            Int64 contact = Convert.ToInt64(txtContact.Text);
            int age = Convert.ToInt32(txtAge.Text);
            string gender = comboGender.Text;
            string Blood_Group = txtBlood.Text;
            string Major_Disease = txtAny.Text;
            int pid = Convert.ToInt32(txtPid.Text);

            // Adjust the connection string as needed for your environment and database name
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=hospital;Integrated Security=True;";

            // Create and open the SQL connection within a using block for proper disposal
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Prepare a parameterized INSERT query
                string query = "INSERT INTO AddPatient (Name, Full_Address, Contact, Age, Gender, Blood_Group, Major_Disease, pid) " +
                               "VALUES (@Name, @Full_Address, @Contact, @Age, @Gender, @Blood_Group, @Major_Disease, @pid)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters and assign values
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Full_Address", Full_Address);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Blood_Group", Blood_Group);
                    cmd.Parameters.AddWithValue("@Major_Disease", Major_Disease);
                    cmd.Parameters.AddWithValue("@pid", pid);

                    try
                    {
                        // Open the connection
                        con.Open();

                        // Execute the query; ExecuteNonQuery returns the number of rows affected
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data saved successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No data was inserted.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Display any errors that occur during insertion
                        MessageBox.Show("Error: " + ex.Message);
                    }

                    txtName.Clear();
                    txtAddress.Clear();
                    txtContact.Clear();
                    txtAge.Clear();
                    comboGender.ResetText();
                    txtBlood.Clear();
                    txtAny.Clear();
                    txtPid.Clear();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                int pid = Convert.ToInt32(textBox1.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=hospital;Integrated Security=True;";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddPatient where pid = " + pid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(textBox1.Text);
                String sympt = txtBxSymptoms.Text;
                String diag = txtBxDiagonosis.Text;
                String medicine = txtBxMedicines.Text;
                String ward = comboBxWard.Text;
                String wardType = comboBxWardType.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=hospital;Integrated Security=True;";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into PatientMore values (" + pid + ",'" + sympt + "','" + diag + "','" + medicine + "','" + ward + "','" + wardType + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

            }
            catch (Exception)
            {
                MessageBox.Show("Any field is empty 'OR' Data is in wrong format.");
            }
            MessageBox.Show("Data Saved");

            textBox1.Clear();
            txtBxDiagonosis.Clear();
            txtBxMedicines.Clear();
            txtBxSymptoms.Clear();
            comboBxWard.ResetText();
            comboBxWardType.ResetText();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
