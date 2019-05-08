using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validation;

namespace Validation_two
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Validation.Validation v = new Validation.Validation();
            if (!v.required(txtName.Text))
            {
                label3.Text = "Field is required ";
            }
            
            if(!v.PhoneValidation(TxtPhone.Text))
            {
                label4.Text = "This phone number is not valid";
            }
                















            
                
        }
    }
}
