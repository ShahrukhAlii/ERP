using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ERP
{
    public partial class Form6 : Form
    {
        Connection conn = new Connection();
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into Vendor(VID,VName,VCity,PH1,CPName,VStatus) values(@VID,@VName,@VCity,@PH1,@CPName,@VStatus)", conn.oleDbConnection1);

            cmd.Parameters.AddWithValue("@VID", textBox1.Text);
            cmd.Parameters.AddWithValue("@VName", textBox2.Text);
            cmd.Parameters.AddWithValue("@VCity", textBox3.Text);
            cmd.Parameters.AddWithValue("@PH1", textBox4.Text);
            cmd.Parameters.AddWithValue("@CPName", textBox5.Text);
            cmd.Parameters.AddWithValue("@VStatus", textBox6.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Vendor has been send for Approval");
            conn.oleDbConnection1.Close();
           
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();

           

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
