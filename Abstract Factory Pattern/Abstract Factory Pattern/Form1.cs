using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_Factory_Pattern
{
    public partial class Form1 : Form
    {
        private CreateDish factory;
        private Dish newDish;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Pasta_Click(object sender, EventArgs e)
        {
            factory = new CreatePasta(txtPasta.Text, txtSauce.Text, txtMeat.Text, txtExtra.Text, txtSideP.Text);
            newDish = factory.createDish();
            txtOrder.Text += newDish.getOrder() + "\n \n";
        }

        private void btn_Sandwich_Click(object sender, EventArgs e)
        {
            factory = new CreateSandwich(txtSub.Text, txtBread.Text, txtCheese.Text, txtTopp.Text, txtSideS.Text);
            newDish = factory.createDish();
            txtOrder.Text += newDish.getOrder() + "\n \n";
        }

    }
}
