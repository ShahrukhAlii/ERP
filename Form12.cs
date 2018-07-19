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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from PO where POID = '" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = dr["VID"].ToString();
                textBox2.Text = dr["VName"].ToString();
                dateTimePicker2.Text = dr["DDate"].ToString();
                //textBox3.Text = dr["DDate"].ToString();

            }


            OleDbDataAdapter da = new OleDbDataAdapter("Select  *from POProducts  ", conn.oleDbConnection1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.oleDbConnection1.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Insert into GRN(GRNID,POID,VName,GRDate,DDate,VID)values(@GRNID,@POID,@VName,@GRDate,@DDate,@VID)", conn.oleDbConnection1);
            cmd.Parameters.AddWithValue("@GRNID", textBox4.Text);
            cmd.Parameters.AddWithValue("@POID", comboBox1.Text);
            //cmd.Parameters.AddWithValue("@Status", "CLOSE");
            cmd.Parameters.AddWithValue("@VName", textBox2.Text);
            cmd.Parameters.AddWithValue("@GRDate", dateTimePicker1);
            cmd.Parameters.AddWithValue("@DDate", dateTimePicker2);
            cmd.Parameters.AddWithValue("@VID", textBox1.Text);
            cmd.ExecuteNonQuery();
            OleDbCommand cnd = new OleDbCommand("Update PO set Status='CLOSE' where POID = @PID");
            conn.oleDbConnection1.Close();
            MessageBox.Show("GRN OK");
        }
    }
}
