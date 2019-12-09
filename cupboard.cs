using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookSpaceOptimization
{
    public partial class cupboard : Form
    {
        
        List<cupboardClass> cupboards= new List<cupboardClass>();
        cupboardClass temp = new cupboardClass();
        
        public cupboard()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            for (int a = 1; a <= Convert.ToInt32(txtCupboard.Text); a++)
            {
                cupboardClass cupboard = new cupboardClass(Convert.ToInt32(txtCapacity.Text));
                cupboards.Add(cupboard);
            }
            book newbook = new book(cupboards);
            ActiveForm.Hide();
            newbook.Show();
            
        }

        private void LblOptimize_Click(object sender, EventArgs e)
        {

        }

        private void LblCapacity_Click(object sender, EventArgs e)
        {

        }

        private void Cupboard_Load(object sender, EventArgs e)
        {

        }
    }
}
