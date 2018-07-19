using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from GRN where GRNID = '" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                textBox10.Text = dr["GRDate"].ToString();
                textBox3.Text = dr["POID"].ToString();
                textBox4.Text = dr["VID"].ToString();
                textBox5.Text = dr["VName"].ToString();

            }
            OleDbCommand cmd1 = new OleDbCommand("Select TotalAmount from POProducts where POID = '" + textBox3.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {

                textBox6.Text = dr1["TPPRICE"].ToString();
                textBox2.Text = dr1["Pid"].ToString();
                textBox7.Text = dr1["PQty"].ToString();



            }
            conn.oleDbConnection1.Close();



        }
    }
}
