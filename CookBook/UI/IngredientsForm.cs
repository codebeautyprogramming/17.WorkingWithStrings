using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class IngredientsForm : Form
    {
        public IngredientsForm()
        {
            InitializeComponent();
        }

        private void AddToFridgeBtn_Click(object sender, EventArgs e)
        {
            string message = NameTxt.Text
                + "\n" + TypeTxt.Text
                + "\n" + WeightNum.Value
                + "\n" + KcalPer100gNum.Value
                + "\n" + PricePer100gNum.Value;

            MessageBox.Show(message);
        }
    }
}
