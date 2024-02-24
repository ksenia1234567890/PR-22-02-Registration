using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PR_22_02_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reg_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=cxNTVJas;Database= Database");
                string query = "select login from registration where surname=@surname and name=@name and login=@login and password=@password";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                cmd.Parameters.AddWithValue("@surname", Tsurname.Text);
                cmd.Parameters.AddWithValue("@name", Tname.Text);
                cmd.Parameters.AddWithValue("@login", Tlogin.Text);
                cmd.Parameters.AddWithValue("@password", Tpassword.Text);
                con.Open();
                string login = (string)cmd.ExecuteScalar();
                con.Close();

                if (login == Tlogin.Text)
                {
                    MessageBox.Show("Данный пользователь существует");
                }
                else
                {
                    string sql = "Insert into registration(surname,name,login,password) values (@surname,@name,@login,@password)";
                    cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@surname", Tsurname.Text);
                    cmd.Parameters.AddWithValue("@name", Tname.Text);
                    cmd.Parameters.AddWithValue("@login", Tlogin.Text);
                    cmd.Parameters.AddWithValue("@password", Tpassword.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
