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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;
            conn.oleDbConnection1.Open();

            OleDbCommand cmdd = new OleDbCommand("select count(POID) from PO where VDept= '" + comboBox3.Text + "'", conn.oleDbConnection1);
            OleDbDataReader drr = cmdd.ExecuteReader();
            if (drr.Read())
            {
                c = Convert.ToInt32(drr[0]);
                c++;
            }

            textBox1.Text = comboBox3.Text + "-" + c.ToString() + "-" + System.DateTime.Today.Year;

            conn.oleDbConnection1.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
              conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from PO where VID = '" + comboBox1.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                // textBox1.Text = dr["VID"].ToString();
                textBox2.Text = dr["Vname"].ToString();
                textBox3.Text = dr["VDept"].ToString();
                textBox4.Text = dr["VCPPH"].ToString();

            }

            conn.oleDbConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
              //CREATE PO
            int s = 0;
            foreach (int p in pprice)
            {
                s += p + s;
            
            }

            conn.oleDbConnection1.Open();
            OleDbCommand cmd = new OleDbCommand("insert into PO(POID,PODate,VDept,VName,VID,VCPPH,PPRICE) values(@POID,@PODate,@VDept,@VName,@VID,@VCPPH,@PPRICE)", conn.oleDbConnection1);
          
            cmd.Parameters.AddWithValue("@POID",textBox1.Text);
            cmd.Parameters.AddWithValue("@PODate", dateTimePicker1);
            cmd.Parameters.AddWithValue("@VDept", textBox3.Text);
            cmd.Parameters.AddWithValue("@VName", textBox2.Text);
            cmd.Parameters.AddWithValue("@VID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@VCPPH", textBox4.Text);
            cmd.Parameters.AddWithValue("@PPRICE", s);
           // cmd.Parameters.AddWithValue("@PPRICE", textBox7.Text);
            cmd.ExecuteNonQuery();
           



            //conn.oleDbConnection1.Open();
            for (int i = 0; i < counter; i++)
            {
                OleDbCommand cmd1 = new OleDbCommand("insert into POProducts(POID,Pid,PQty,TPPRICE,PNAME,PMODEL) values(@POID,@Pid,@PQty,@TPPRICE,@PNAME,@PMODEL)", conn.oleDbConnection1);

                cmd1.Parameters.AddWithValue("@POID", textBox1.Text);
                cmd1.Parameters.AddWithValue("@Pid", pid[i]);
                cmd1.Parameters.AddWithValue("@PQty", qty[i]);
                cmd1.Parameters.AddWithValue("@TPPRICE", pprice[i]);
                cmd1.Parameters.AddWithValue("@PNAME", textBox6.Text);
                cmd1.Parameters.AddWithValue("@PMODEL", textBox5.Text);
                cmd1.ExecuteNonQuery();
                //counter++;
            }
            
            conn.oleDbConnection1.Close();
            

           

            MessageBox.Show("PLEASE TAKE YOUR PURCHASE ORDER SLIP");
          try{
        
            }
            catch (ArrayTypeMismatchException ax) 
          {
                MessageBox.Show(ax.Message);
            
            }
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
                    }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
             conn.oleDbConnection1.Open();
            OleDbCommand cd = new OleDbCommand("Select *from Products where Pid = '" + comboBox2.Text + "'", conn.oleDbConnection1);
            OleDbDataReader dnr = cd.ExecuteReader();

            if (dnr.Read())
            {
                textBox5.Text = dnr["ProductModel"].ToString();
                textBox6.Text = dnr["PName"].ToString();
                textBox7.Text = dnr["BasePrice"].ToString();
              

            }

            conn.oleDbConnection1.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
        

             textBox9.Text += label8.Text + " :  " + comboBox2.Text + Environment.NewLine;
            textBox9.Text += label11.Text + "  :  " + textBox5.Text + Environment.NewLine;
            textBox9.Text += label13.Text + "        :  " + textBox6.Text + Environment.NewLine;
            textBox9.Text += label12.Text + "         :  " + textBox7.Text + Environment.NewLine;
            textBox9.Text += label10.Text + " :  " + textBox8.Text + Environment.NewLine;
            //  conn.oleDbConnection1.Open();
          pid[counter] = comboBox2.Text;
           
          qty[counter] = Convert.ToInt32(textBox8.Text);
            pprice[counter] = Convert.ToInt32(textBox7.Text);
           counter++;

            
            //    MessageBox.Show("Transaction done!!");


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
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


        }

        }
    }
}
