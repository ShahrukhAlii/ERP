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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

            
        }
       
       
        //Customer Info
        private void rectangleShape2_Click(object sender, EventArgs e)
        {
            fm1.Show();
            fm1.Hide();
        }
        Form6 fm1 = new Form6();

        //customer something
        private void rectangleShape3_Click(object sender, EventArgs e)
        {
            fm2.Show();
            this.Hide();

        }
        Form7 fm2 = new Form7();
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape8_Click(object sender, EventArgs e)
        {

        }

        //Vendor Info
        private void rectangleShape1_Click_1(object sender, EventArgs e)
        {
            
        }

        Form4 fm = new Form4();
        //Vendor info label
        private void label2_Click_1(object sender, EventArgs e)

        {


           
           // fm.Show();
            //this.Hide();
        }
        //customer info label
        private void label3_Click(object sender, EventArgs e)
        {
            fm1.Show();
            this.Hide();

        }

        //customer somthing label

        private void label4_Click(object sender, EventArgs e)
        {

            fm2.Show();
            this.Hide();
        }
        //PO
        private void rectangleShape4_Click(object sender, EventArgs e)
        {

        }

        Form8 fm3 = new Form8();

        //PO label

        private void label5_Click(object sender, EventArgs e)
        {

            fm3.Show();
            this.Hide();
        }
        //GRN Form
        private void rectangleShape5_Click(object sender, EventArgs e)
        {

        }
        Form9 fm4 = new Form9();

        //GRN label
        private void label6_Click(object sender, EventArgs e)
        {

            fm4.Show();
            this.Hide();
        }
        //Invoice form here
        private void rectangleShape6_Click(object sender, EventArgs e)
        {

        }
        Form9 fm5 = new Form9();


        //Invoice label
        private void label7_Click(object sender, EventArgs e)
        {
            fm5.Show();
            this.Hide();


        }
        //vender picture
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f2 = new Form4();
            f2.Show();
        }


    }
}
