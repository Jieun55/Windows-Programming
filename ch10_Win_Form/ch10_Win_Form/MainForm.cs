using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch10_Win_Form
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            //버튼 클릭시에 해야할 일을 작성함
            txtResult.Text = txtName.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtName.Text = "";
        }
    }
}
