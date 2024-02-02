using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SportAktivity
{
    public partial class Form3 : Form
    {
        MySqlConnection conn = new MySqlConnection
            ("SERVER=LOCALHOST ;DATABASE=club_aktivities ;UID=app_user ;PASSWORD=13579");
        public Form3()
        {
            InitializeComponent();
        }

        private void showGrid_bt_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from referee", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }
        }

        private void Referee_Load(object sender, EventArgs e)
        {
            
        }

        private void search_bt_Click(object sender, EventArgs e)
        {
            try 
            {
                string searchText = searchTextBox.Text;
                string query = "SELECT * FROM referee WHERE referee_name LIKE @searchText";

                if (int.TryParse(searchText, out _))
                {
                    query += " AND referee_name LIKE @searchText + '%'";
                }
                else if (searchText.Length == 1 && char.IsLetter(searchText[0])) 
                {
                    query += " AND referee_name LIKE @searchText + '%' ";
                }

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@searchText", searchText);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                dataGridView1.DataSource = ds.Tables[0];
                
            }
            catch (Exception ex ) 
            {
                MessageBox.Show(ex.Message);
            }
             
        }

        private void delete_bt_Click(object sender, EventArgs e)
        {

            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {

                    int player_idToDelete = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    string deleteQuery = "DELETE FROM referee WHERE referee_id = @RefereeID";


                    using (MySqlConnection conn = new MySqlConnection
                           ("SERVER=LOCALHOST ;DATABASE=club_aktivities ;UID=app_user ;PASSWORD=13579"))
                    {

                        conn.Open();


                        using (MySqlCommand command = new MySqlCommand(deleteQuery, conn))
                        {

                            command.Parameters.AddWithValue("@RefereeID", player_idToDelete);

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
    }
}
