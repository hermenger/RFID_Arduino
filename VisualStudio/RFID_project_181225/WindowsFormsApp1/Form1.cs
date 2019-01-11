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
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        MySqlConnection mysqlcon = new MySqlConnection("server=localhost;user id=root;database=rfid_db");
        public Form1()
        {
            InitializeComponent();
        }
        private void View()
        {
            DataTable View = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `rfid` WHERE 1 ", mysqlcon);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            da.Fill(View);
            dataGridView1.DataSource = View; 
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now);
            //textBox2.Text = DateTime.Now;
            LogMsg.AppendText(DateTime.Now + " | " + tbRFIDlabel.Text + " | " + tbName.Text + Environment.NewLine);
            mysqlcon.Open();
            MySqlCommand cmd = new MySqlCommand("insert into rfid(LogDate,LogTime,cardnumber,name) values('" + DateTime.Now.Date + "','" + DateTime.Now.TimeOfDay + "','" + tbRFIDlabel.Text + "','" + tbName.Text + "')", mysqlcon);
            cmd.ExecuteNonQuery();
            mysqlcon.Close();
            tbName.Text = "";
            tbRFIDlabel.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRFIDlabel_TextChanged(object sender, EventArgs e)
        {            
            //Thread.Sleep(1000); // put your time in millis here
            //LogMsg.AppendText(DateTime.Now + Environment.NewLine);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //LogMsg.AppendText(String.Compare(tbRFIDlabel.Text,"") + Environment.NewLine);
            tbRFIDlabel.Focus();
            tbRFIDlabel.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            if (tbRFIDlabel.Text.Length <= 5 || tbRFIDlabel.Text.Length > 10)
                tbRFIDlabel.Text = "";
            if (String.Compare(tbRFIDlabel.Text, "", true) == 0 ? false : true && tbRFIDlabel.Text.Length == 10)
            { 
                LogMsg.AppendText(DateTime.Now + " | " + tbRFIDlabel.Text + Environment.NewLine);
                //Console.WriteLine(DateTime.Now);
                //textBox2.Text = DateTime.Now;
                //LogMsg.AppendText(DateTime.Now + Environment.NewLine);
                mysqlcon.Open();
                MySqlCommand cmd = new MySqlCommand("insert into rfid(LogDate,LogTime,cardnumber,name) values('" + DateTime.Now.Date + "','" + DateTime.Now.TimeOfDay + "','" + tbRFIDlabel.Text + "','anonymous')", mysqlcon);
                cmd.ExecuteNonQuery();
                mysqlcon.Close();

                if (tbRFIDlabel.Text.Equals("2152538976")) //#Blue Lisa
                    serialPort1.Write("1");
                else if (tbRFIDlabel.Text.Equals("2771986960")) //#White Vincent
                    serialPort1.Write("2");
                else
                    serialPort1.Write("0");                               
                tbRFIDlabel.Text = "";
            }
        }

        private void btCLRlog_Click(object sender, EventArgs e)
        {
            View();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {            
            serialPort1.PortName = tbCOMnum.Text;
            serialPort1.Open();
            LogMsg.AppendText(DateTime.Now + " | " + "Opening Arduino Serial Port" + tbCOMnum.Text + Environment.NewLine);
            serialPort1.Write("3");
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            serialPort1.Write("9");
            serialPort1.Close();            
            LogMsg.AppendText(DateTime.Now + " | " + "Closed Arduino Serial Port" + Environment.NewLine);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogMsg.AppendText(DateTime.Now + " | " + "Serial Port TEST" + Environment.NewLine);
            serialPort1.Write("2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            serialPort1.PortName = "COM3";
            serialPort1.Open();
            LogMsg.AppendText(DateTime.Now + " | " + "Auto Mode On" + Environment.NewLine);
            serialPort1.Write("3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.Write("9");
            serialPort1.Close();
            timer1.Enabled = false;
            LogMsg.AppendText(DateTime.Now + " | " + "Auto Mode Off" + Environment.NewLine);
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogMsg.AppendText(DateTime.Now + " | " + "Save LOG to files" + Environment.NewLine);
        }
    }
}
