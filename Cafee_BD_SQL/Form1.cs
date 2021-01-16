using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafee_BD_SQL
{

    public partial class Form1 : Form
    {
        string str = "Data Source=DESKTOP-PTPI5LJ\\DESKTOPEGOR;Initial Catalog=Cafee_Base;Persist Security Info=True;User ID=sa;Password=123456";
        private SqlCommand cmd;
        private SqlConnection connection; 
        private DataSet ds;
        private SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
            GetPerson();
        }
        private void GetPerson()
        {
           string a = tabControl1.SelectedTab.Text.ToString();
            IDBox.Text = a;
            connection = new SqlConnection(str);
            try
            {
                connection.Open();
                da = new SqlDataAdapter("SELECT * FROM Postavshik", connection);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables["Postavshik"];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void Add_Button_Click(object sender, EventArgs e)
        {

            connection = new SqlConnection(str);

            try
            {
                connection.Open();
                cmd = new SqlCommand(String.Format(" INSERT INTO Postavshik (Name_POSTAVSHIK, SURNAME_POSTAVSHIK, PATRONYMIC_POSTAVSHIK, ID_Organisation_FK) VALUES ('{0}', '{1}','{2}', {3})", NameBox.Text, SurnameBox.Text, PatronimycBox.Text, OrganisationFKBox.Text), connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void AddOrganisation_Button_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);

            try
            {
                connection.Open();
                cmd = new SqlCommand(String.Format(" INSERT INTO Organisation (Name_Organisation, Adres_Organisation," +
               " Phone_Organisation) VALUES ('{0}', '{1}','{2}')", NameOfOrganisationBox.Text, AdresOfOrganisationBox.Text, PhoneOfOrganisationBox.Text), connection);
                cmd.ExecuteNonQuery();
                IDBox.Text = cmd.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                IDBox.Text = cmd.CommandText;
                connection.Close();
            }
            
        }
    }
}
