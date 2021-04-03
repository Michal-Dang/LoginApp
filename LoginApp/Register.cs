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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (txtImie.Text == "" || txtNazwisko.Text == "" || txtLogin.Text == "" || txtHaslo.Text == "" || txtPowtorzHaslo.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Nie wszystkie pola wypełnione!");
            }
            else if(txtHaslo.Text!=txtPowtorzHaslo.Text)
             {
                MessageBox.Show("Hasła są NIEZGODNE!");
            }
            else
            {
                using (SqlConnection Connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mdrag\OneDrive\Pulpit\LoginApp\BazaDanych.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    Connect.Open();
                    SqlCommand Sqlcmd = new SqlCommand("UserAdd", Connect);
                    Sqlcmd.CommandType = CommandType.StoredProcedure;
                    Sqlcmd.Parameters.AddWithValue("@Imię", txtImie.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@Nazwisko", txtNazwisko.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@Login", txtLogin.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@Hasło", txtHaslo.Text.Trim());
                    Sqlcmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    Sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Udało ci się zarejestrować");
                    txtImie.Text = txtNazwisko.Text = txtLogin.Text = txtHaslo.Text =txtPowtorzHaslo.Text = txtEmail.Text = "";

                }
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }
        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        public void TxtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
