using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stream
{
    public partial class frmFileName : Form
    {
        public static String FileName;
        public frmFileName()
        {
            InitializeComponent();
        }
        public static String SetFileName() { 
            return FileName;
        }
        private void btnOkay_Click(object sender, EventArgs e)
        {
            String name = txtFileName.Text;
            FileName = name + ".txt";
            this.Close();
        }
    }
}
