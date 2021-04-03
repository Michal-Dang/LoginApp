using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void ButtonZaloguj_Click(object sender, EventArgs e)
        {
           
             SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mdrag\OneDrive\Pulpit\LoginApp\BazaDanych.mdf;Integrated Security=True;Connect Timeout=30");
            string Konto = "Select * from TblUser where Login ='" + txtLogin.Text.Trim() + "' and Hasło = '" + txtHaslo.Text.Trim() + "'";
            SqlDataAdapter Sda = new SqlDataAdapter(Konto, Connect);
            DataTable Dt = new DataTable();
            Sda.Fill(Dt);

            if (Dt.Rows.Count == 1)
            {
                Main objMain = new Main();
                this.Hide();
                objMain.Show();
            }
            else
            {
                MessageBox.Show("Zła nazwa użytkownika lub hasło");
            }
        }

        private void ButtonWyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
