using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Wishlist1 : Form
    {
        public Wishlist1()
        {
            InitializeComponent();
        }

        private void Wishlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionOutputBox1.Text = Wishlistbox.Text;
        }

        private void wishlistText_Click(object sender, EventArgs e)
        {

        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            Wishlistbox.Items.Add("iPhone 14 Pro Max Fully Paid");
            Wishlistbox.Items.Add("House and Lot");
            Wishlistbox.Items.Add("Travel around the world");
            Wishlistbox.Items.Add("Sports Car");
            Wishlistbox.Items.Add("$ 1,000,000");
            Wishlistbox.Items.Add("Wear luxury clothes");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Wishlistbox.Items.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            Wishlistbox.Sorted = true;
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            countOut.Text = Convert.ToString(Wishlistbox.Items.Count);
        }

        private void countOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectionOutputBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
