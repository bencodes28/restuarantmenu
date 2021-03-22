using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuarant_app
{
    public partial class Form1 : Form
    {
        const double price_cheeseB = 7.50;
        const double price_BaconB = 6.50;
        const double price_veggieb = 5.50;
        const double price_Roadhouse = 8.50;
        const double price_GrilledB = 6.50;
        const double price_SmokedB = 7.50;
        const double price_BBQB = 7.50;
        const double price_PizzaB = 10.50;
        const double price_Cinnamon = 2.50;
        const double price_RedV = 2.50;
        const double price_oreoShake = 2.50;
        const double price_IceCream = 4.50;
        const double price_CaramelP = 3.50;
        const double price_HiC = 1.50;
        const double price_chocolate = 1.50;
        const double price_pineapple = 1.50;
        const double price_appleJ = 1.50;
        const double price_Sprite = 2.50;
        const double price_Miller = 2.50;
        const double price_Slushie = 2.50;
        const double price_Taxes = 2.50;

        double tax, subTot, total;











        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are u sure u want to Exit?", "iii", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void resetcheckBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
     
            private void resetBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
                        func(Controls);
        }

        private void Enabletext()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        private void resetbutton(object sender, EventArgs e)
        {
            resetBoxes();
            resetcheckBoxes();
        }

        private void totals(object sender, EventArgs e)
        {
            double[] itemcost = new double[22];
            itemcost[0] = Convert.ToDouble(dublecheese.Text) * price_cheeseB;
            itemcost[1] = Convert.ToDouble(baconb.Text) * price_BaconB;
            itemcost[2] = Convert.ToDouble(vegb.Text) * price_veggieb;
            itemcost[3] = Convert.ToDouble(toadhb.Text) * price_Roadhouse;
            itemcost[4] = Convert.ToDouble(grilleds.Text) * price_GrilledB;
            itemcost[5] = Convert.ToDouble(bbqonion.Text) * price_BaconB;
            itemcost[6] = Convert.ToDouble(pizza.Text) * price_PizzaB;
            itemcost[7] = Convert.ToDouble(cinnamon.Text) * price_Cinnamon ;
            itemcost[8] = Convert.ToDouble(redvelvet.Text) * price_RedV;
            itemcost[9] = Convert.ToDouble(oreo.Text) * price_oreoShake;
            itemcost[10] = Convert.ToDouble(icecream.Text) * price_IceCream;
            itemcost[11] = Convert.ToDouble(carmelpudd.Text) * price_CaramelP;
            itemcost[12] = Convert.ToDouble(HIC.Text) * price_HiC;
            itemcost[13] = Convert.ToDouble(Chocomilk.Text) * price_chocolate;
            itemcost[14] = Convert.ToDouble(pineapplej.Text) * price_pineapple;
            itemcost[15] = Convert.ToDouble(applej.Text) * price_appleJ;
            itemcost[16] = Convert.ToDouble(sprite.Text) * price_Sprite;
            itemcost[17] = Convert.ToDouble(miller.Text) * price_Miller;
            itemcost[18] = Convert.ToDouble(fruite.Text) * price_Slushie;

            double cost, changes;
            if(cmdPayMethod.Text == "Cash")
            {
                subTot = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] +
                        itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] +
                        itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] +
                        itemcost[17] + itemcost[18];

                subtotallbl.Text = Convert.ToString(subTot);
                tax = (subTot * price_Taxes) / 100;
             taxlbl.Text = Convert.ToString(tax);
                total = (subTot + tax);
                totallbl.Text = Convert.ToString(total);
                changes = Convert.ToDouble(txtPaymentMeth.Text);
                cost = changes - (tax + total);
                changelbl.Text = Convert.ToString(cost);
               
            }
            else
            {
                subTot = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] +
                          itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] +
                          itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] +
                          itemcost[17] + itemcost[18];

                subtotallbl.Text = Convert.ToString(subTot);
                tax = (subTot * price_Taxes) / 100;
                taxlbl.Text = Convert.ToString(tax);
                total = (subTot + tax);
                totallbl.Text = Convert.ToString(total);
               
            }

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
           cmdPayMethod.Items.Add(" ");
            cmdPayMethod.Items.Add("Cash");
         
            cmdPayMethod.Items.Add("debit card");



        }

        private void cmdpayMethod(object sender, EventArgs e)
        {
            if(cmdPayMethod.Text== "Cash" || cmdPayMethod.Text == "debit card")
            {
                MessageBox.Show("Please enter you cash, or debit pin pleq.");
                txtPaymentMeth.Enabled = true;
                txtPaymentMeth.Text = " ";
                txtPaymentMeth.Focus();
            }
            else
            {
                txtPaymentMeth.Enabled = false;
                txtPaymentMeth.Text = "0";
            }
        }
    }
}
