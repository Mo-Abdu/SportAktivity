
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SportAktivity
{
    public partial class Form2 : Form
    {

        MySqlConnection conn = new MySqlConnection
            ("SERVER=LOCALHOST ;DATABASE=club_aktivities ;UID=app_user ;PASSWORD=13579");

        public object textPlayerID { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void showgrid_bt_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from players", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }

        }

        private void ensertGrid_button_Click(object sender, EventArgs e)
        {

            try
            {

                string insertQuery = "INSERT INTO players(player_name, age, email, adress, phone) " +
                    "VALUES(@PlayerName, @Age, @Email, @Adress, @Phone)";

                using (MySqlConnection conn = new MySqlConnection
                ("SERVER=LOCALHOST ;DATABASE=club_aktivities ;UID=app_user ;PASSWORD=13579"))
                {
                    conn.Open();

                    using (MySqlCommand command = new MySqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@PlayerName", textBox1.Text);
                        command.Parameters.AddWithValue("@Age", textBox2.Text);
                        command.Parameters.AddWithValue("@Email", textBox3.Text);
                        command.Parameters.AddWithValue("@Adress", textBox4.Text);
                        command.Parameters.AddWithValue("@Phone", textBox5.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected == 1)
                        {
                            MessageBox.Show("Inserted are successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Inserted are not succesfully!");
                        }

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateGrid_bt_Click(object sender, EventArgs e)
        {
            try
            {
               //int player_idToUpdate = -1;

                if (dataGridView1.SelectedRows.Count > 0)
                {

                    int player_idToUpdate = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    string updateQuery = "UPDATE players SET player_name = @PlayerName, age = @Age, email = @Email, adress = @Adress, phone = @Phone " +
                        "WHERE player_id = @PlayerID";

                    using (MySqlConnection conn = new MySqlConnection("SERVER=LOCALHOST ;DATABASE=club_aktivities ;UID=app_user ;PASSWORD=13579"))
                    {
                        conn.Open();

                        using (MySqlCommand command = new MySqlCommand(updateQuery, conn))
                        {
                            command.Parameters.AddWithValue("@PlayerID", player_idToUpdate);
                            command.Parameters.AddWithValue("@PlayerName", textBox1.Text);


                            if (int.TryParse(textBox2.Text, out int ageValue))
                            {
                                command.Parameters.AddWithValue("@Age", ageValue);
                            }
                            else 
                            {
                                MessageBox.Show("Pleace enter a valid integer for 'age'.");
                                return;
                            }
                
                            command.Parameters.AddWithValue("@Email", textBox3.Text);
                            command.Parameters.AddWithValue("@Adress", textBox4.Text);
                            command.Parameters.AddWithValue("@Phone", textBox5.Text);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected == 1)
                            {
                                MessageBox.Show("Update successful!");
                            }
                            else
                            {
                                MessageBox.Show("Update Not successful!");
                            }
                        }

                    }

                }

                else 
                {
                    MessageBox.Show("No row selected for update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.ToString());
            }
        }

        private void deleteGrid_bt_Click(object sender, EventArgs e)
            {   
            

                try
                {

                    if (dataGridView1.SelectedRows.Count > 0)
                    {

                        int player_idToDelete = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                        string deleteQuery = "DELETE FROM players WHERE player_id = @PlayerID";


                        using (MySqlConnection conn = new MySqlConnection
                               ("SERVER=LOCALHOST ;DATABASE=club_aktivities ;UID=app_user ;PASSWORD=13579"))
                        {

                            conn.Open();


                            using (MySqlCommand command = new MySqlCommand(deleteQuery, conn))
                            {

                                command.Parameters.AddWithValue("@PlayerID", player_idToDelete);

                                int rowsAffected = command.ExecuteNonQuery();
                                if (rowsAffected == 1)
                                {
                                    MessageBox.Show("You have been succeed!");
                                }
                                else
                                {
                                    MessageBox.Show("Not Successful!");
                                }

                            }

                        }

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("ex");
                }


            }

        private void goToReferee_bt_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}    

