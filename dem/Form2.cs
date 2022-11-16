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
    public partial class Form2 : Form
    {
        public int ID_User;
        public Form2( int User_ID)
        {
            InitializeComponent();

            ID_User = User_ID;

        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(ID_User);
        }
    }
}
