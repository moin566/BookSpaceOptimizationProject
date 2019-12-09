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
    public partial class book : Form
    {
        List<int> books= new List<int>();
        List<string> names = new List<string>();
        List<cupboardClass> c2=new List<cupboardClass>();
        public book()
        {
            InitializeComponent();
        }
        public book(List<cupboardClass> c1)
        {
            c2 = c1;
            InitializeComponent();
        }

        private void LblCapacity_Click(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            while(i < books.Count && j < c2.Count)
            {
                if (books[i] <= c2[j].capacity)
                {
                    c2[j].addBook(names[i], books[i]);
                    if (c2[j].capacity == 0)
                    {
                        j++;
                    }
                    i++;
                }
                else
                //(books[i] >= cupboards[j].capacity);
                {
                    int rem = books[i] - c2[j].capacity;
                    c2[j].addBook(names[i], c2[j].capacity);
                    j++;
                    while (rem > 0 && j < c2.Count())
                    {
                        int nrem = rem - c2[j].capacity;
                        if (nrem < 0)
                        {
                            c2[j].addBook(names[i], rem);
                            j++;
                            rem = 0;
                        }
                        else
                        {
                            int crem = rem - c2[j].capacity;
                            c2[j].addBook(names[i], rem - crem);
                            j++;
                            rem = crem;
                        }
                    }
                    i++;
                }
            }
            displayData();
        }

        void displayData()
        {
            for ( int i=0; i< c2.Count; i++)
            {
                for (int j=0; j<c2[i].category.Count; j++)
                {
                    dataGridView1.Rows.Add(i , c2[i].category[j], c2[i].books[j]);
                }
            }
        }
        private void Book_Load(object sender, EventArgs e)
        {
            btnNext.Enabled = false;
        }

        private void BtnSequence_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            books.Add(Convert.ToInt32(txtQuantity.Text));
            names.Add(txtName.Text);
            txtQuantity.Text = "";
            txtName.Text = "";
            if (books.Count>=Convert.ToInt32(txtCategory.Text))
            {
                button1.Enabled = false;
                btnNext.Enabled = true;
            }
        }
    }
}
