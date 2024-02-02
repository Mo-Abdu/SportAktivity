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
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection
            ("SERVER=LOCALHOST ;DATABASE=club_aktivities ;UID=app_user ;PASSWORD=13579");
        public Form1()
        {
            InitializeComponent();
        }

        private void showGrid_bt_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("select * from game", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch(Exception x)
            {
                MessageBox.Show(x + "");
            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenForm2_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
          
        }
    }


}

