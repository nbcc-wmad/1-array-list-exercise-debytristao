using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        ArrayList word = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            word.Clear();

            word.Add("I");
            word.Add("love");
            word.Add("programming");
            word.Add("so");
            word.Add("much");

            foreach(object item in word)
            {
                lblMessage.Text += item + " ";
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;


            word.Reverse();

            foreach (object item in word)
            {
                lblMessage.Text += item + " ";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string adicional = txtSecondPos.Text.Trim();

            lblMessage.Text = string.Empty;

            word.Insert(1, adicional);

            foreach (object item in word)
            {
                lblMessage.Text += item + " ";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;

            word.RemoveAt(1);

            foreach (object item in word)
            {
                lblMessage.Text += item + " ";
            }

        }
    }
}
