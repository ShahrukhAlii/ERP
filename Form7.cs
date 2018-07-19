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
    public partial class Form7 : Form
    {
        Connection conn = new Connection();
        public Form7()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Update Vendor set VName=@VName,PH1=@PH1,CPName=@CPName, VStatus=@VStatus where VID=@VID", conn.oleDbConnection1);

            cmd.Parameters.AddWithValue("@VName", textBox1.Text);
            cmd.Parameters.AddWithValue("@VCity", textBox2.Text);
            cmd.Parameters.AddWithValue("@PH1", textBox3.Text);
            cmd.Parameters.AddWithValue("@VStatus", textBox4.Text);
            cmd.Parameters.AddWithValue("@VID", comboBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Issue accured in Approving Vendor");
            this.button3.Visible = true;
            conn.oleDbConnection1.Close();



        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.button3.Visible = false;
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select VID from Vendor where VStatus = 'SFA' ", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["VID"]).ToString();
            }

            conn.oleDbConnection1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Update Vendor set VName=@VName,PH1=@PH1,CPName=@CPName, VStatus=@VStatus where VID=@VID", conn.oleDbConnection1);

            cmd.Parameters.AddWithValue("@VName", textBox1.Text);
            cmd.Parameters.AddWithValue("@VCity", textBox2.Text);
            cmd.Parameters.AddWithValue("@PH1", textBox3.Text);
            cmd.Parameters.AddWithValue("@VStatus", textBox4.Text);
            cmd.Parameters.AddWithValue("@VID", comboBox1.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Vendor has been Approved");
            this.button3.Visible = true;
            conn.oleDbConnection1.Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from Vendor where VID = '" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = dr["VName"].ToString();
                textBox2.Text = dr["PH1"].ToString();
                textBox3.Text = dr["CPName"].ToString();
                textBox4.Text = dr["VStatus"].ToString();

            }

            conn.oleDbConnection1.Close();
      

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 F8 = new Form8();
            F8.Show();
        }
    }
}
