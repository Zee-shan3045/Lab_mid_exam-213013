
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         private void Form1_Load(object sender, EventArgs e)
         {
          
             // Initialize prices for items
             double starterPrice = 5.99;
             double mainCoursePrice = 12.99;
             double sweetDishPrice = 7.99;

             // Set items in each group box with checkboxes
             AddMenuItem(groupBox1, "Starter 1", starterPrice);
             AddMenuItem(groupBox1, "Starter 2", starterPrice);

             AddMenuItem(groupBox1, "Main Course 1", mainCoursePrice);

             AddMenuItem(groupBox1, "Sweet Dish 1", sweetDishPrice);
             AddMenuItem(groupBox1, "Sweet Dish 2", sweetDishPrice);

             
             lb2.ReadOnly = true;
         }
         private void AddMenuItem(GroupBox groupBox, string itemName, double itemPrice)
         {
             CheckBox checkBox = new CheckBox();
             checkBox.Text = itemName + " ($" + itemPrice.ToString("0.00") + ")";
             checkBox.CheckedChanged += CalculateTotalBill;

             groupBox.Controls.Add(checkBox);
         }
        private void CalculateTotalBill(object sender, EventArgs e)
        {
            double totalBill = 0.0;

            foreach (Control groupBox in Controls)
            {
                if (groupBox is GroupBox)
                {
                    foreach (Control control in groupBox.Controls)
                    {
                        if (control is CheckBox)
                        {
                            CheckBox checkBox = control as CheckBox;
                            if (checkBox.Checked)
                            {
                                double price = double.Parse(checkBox.Text.Split('$')[1]);
                                totalBill += price;
                            }
                        }
                    }
                }
            }

            lb2.Text = totalBill.ToString("0.00");
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int totalbill =  250;
            MessageBox.Show("Total price is"+ totalbill);
        }
    }
}
