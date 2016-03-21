using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace MemoryGame
{
    public partial class PlayerName : Form
    {
        
        public PlayerName()
        {
            InitializeComponent();
        }

        public void PName()
        {
            var pn = new PlayerName();
            pn.Close(); 
        }

        public string MyScore { get; set; }
        public string MyTime { get; set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtName.Text == "")
                {
                    throw new ArgumentNullException();
                }

                else
                {
                    string connstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\MemoryGame\MemoryGame\EasyDatabase.mdf;Integrated Security=True";
                    using (SqlConnection connection = new SqlConnection(connstring))
                    {
                        connection.Open();
                        SqlCommand addPerson = new SqlCommand("INSERT INTO EasyPeople (Nickname, Score, Time)" + "VALUES (@Nickname, @Score, @Time)", connection);
                        addPerson.Parameters.AddWithValue("@Nickname", txtName.Text);
                        addPerson.Parameters.AddWithValue("@Score", MyScore);
                        addPerson.Parameters.AddWithValue("@Time", MyTime);

                        addPerson.ExecuteNonQuery();
                        this.Close();
                    }
                    this.Close();
                }

             
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("No nickname was written or datbase not founded");
            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        
    }

    

}
