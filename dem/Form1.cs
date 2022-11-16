using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dem
{
    public partial class Form1 : Form
    {
        BazaEntities conn = new BazaEntities();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = conn.Users.ToList() ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int adm = conn.Users.Where(c => c.Name == textBox1.Text && c.Provider == textBox2.Text).Count();
            if (adm == 1)
            {
                Users select = conn.Users.Where(c => c.Name == textBox1.Text).First();
                int User_ID = select.ID_User;
                Form2 form2 = new Form2(User_ID);
                
                form2.Show();
            }


        }
    }
}
