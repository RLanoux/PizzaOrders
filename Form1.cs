using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IT151PizzaOrders
{
    public partial class frmMain : Form
    {
        // Declare globals
        Boolean mbMode = false; // False = order mode; true = delivery mode
        Queue<DeliveryOrder> mqOrders = new Queue<DeliveryOrder>();
        Int32 iSize = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void groupOrder_Enter(object sender, EventArgs e)
        {

        }

        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            if (mbMode)
            {
                mbMode = false;
                grpDelivery.Visible = false;
                grpOrder.Visible = true;
                btnSwitchMode.Text = "Switch to Delivery Mode";
                txtDeliveryAddress.Focus();
            }
            else
            {
                mbMode = true;
                grpDelivery.Visible = true;
                grpOrder.Visible = false;
                btnSwitchMode.Text = "Switch to Order Mode";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtDeliveryAddress.Text != String.Empty)
            {

                if (radioPersonal.Checked)
                {
                    iSize = 8;
                }
                else if (radioSmall.Checked)
                {
                    iSize = 10;
                }
                else if (radioMedium.Checked)
                {
                    iSize = 12;
                }
                else if (radioLarge.Checked)
                {
                    iSize = 14;
                }
                else
                {
                    iSize = 16;
                }

                // Create a new object of type DeliveryOrder with set parameters
                DeliveryOrder mdoCurrentOrder = new DeliveryOrder(txtDeliveryAddress.Text,
                iSize,
                chkXCheese.Checked,
                chkGrnBeef.Checked,
                chkItalSaus.Checked,
                chkPeproni.Checked,
                chkCanBac.Checked,
                chkOnions.Checked,
                chkGrnPprs.Checked,
                chkBlkOlvs.Checked,
                chkGrnOlvs.Checked,
                chkShrooms.Checked);

                // Add the order to queue, or "enqueue" it.
                mqOrders.Enqueue(mdoCurrentOrder);

                // Dispose of the current order object
                mdoCurrentOrder = null;

                // Clear the form
                ClearForm();
            }
        }

        private void ClearForm()
        {
            // Clear the form
            txtDeliveryAddress.Clear();
            chkXCheese.Checked = false;
            chkGrnBeef.Checked = false;
            chkItalSaus.Checked = false;
            chkPeproni.Checked = false;
            chkCanBac.Checked = false;
            chkOnions.Checked = false;
            chkGrnPprs.Checked = false;
            chkBlkOlvs.Checked = false;
            chkGrnOlvs.Checked = false;
            chkShrooms.Checked = false;
            radioPersonal.Checked = true;
            txtDeliveryAddress.Focus();
        }

        private void ClearDelivery()
        {
            txtNextDel.Clear();
            txtDelOrder.Clear();
            btnPullNextOrder.Focus();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtDeliveryAddress.Focus();
        }

        private void btnPullNextOrder_Click(object sender, EventArgs e)
        {
            DeliveryOrder doCurrent = null;
            try
            {
                doCurrent = mqOrders.Dequeue();
                txtNextDel.Text = doCurrent.GetAddress();
                Int32 iHowBigsDaSucker = doCurrent.GetSize();
                switch (iHowBigsDaSucker)
                {
                    case 8:
                        radioPersonal.Checked = true;
                        txtDelOrder.Text = "A Personal Pizza with" + Environment.NewLine;
                        break;
                    case 10:
                        radioSmall.Checked = true;
                        txtDelOrder.Text = "A Small Pizza with" + Environment.NewLine;
                        break;
                    case 12:
                        radioMedium.Checked = true;
                        txtDelOrder.Text = "A Medium Pizza with" + Environment.NewLine;
                        break;
                    case 14:
                        radioLarge.Checked = true;
                        txtDelOrder.Text = "A Large Pizza with" + Environment.NewLine;
                        break;
                    case 16:
                        radioLarge.Checked = true;
                        txtDelOrder.Text = "An Extra Large Pizza with" + Environment.NewLine;
                        break;
                    default:
                        break;
                }

                if (doCurrent.IsXch())
                {
                    chkXCheese.Checked = true;
                    txtDelOrder.Text += "Extra Cheese" + Environment.NewLine;
                }

                if (doCurrent.IsGrndBeef())
                {
                    chkGrnBeef.Checked = true;
                    txtDelOrder.Text += "Ground Beef\n" + Environment.NewLine;
                }

                if (doCurrent.IsItalian())
                {
                    chkItalSaus.Checked = true;
                    txtDelOrder.Text += "Italian Sausage\n" + Environment.NewLine;
                }

                if (doCurrent.IsPep())
                {
                    chkPeproni.Checked = true;
                    txtDelOrder.Text += "Pepperoni\n" + Environment.NewLine;
                }

                if (doCurrent.IsCanadian())
                {
                    chkCanBac.Checked = true;
                    txtDelOrder.Text += "Canadian Bacon\n" + Environment.NewLine;
                }

                if (doCurrent.IsOnions())
                {
                    chkOnions.Checked = true;
                    txtDelOrder.Text += "Onions\n" + Environment.NewLine;
                }

                if (doCurrent.IsGreenPep())
                {
                    chkGrnPprs.Checked = true;
                    txtDelOrder.Text += "Green Peppers" + Environment.NewLine;
                }

                if (doCurrent.IsBlkOlvs())
                {
                    chkBlkOlvs.Checked = true;
                    txtDelOrder.Text += "Black Olives\n" + Environment.NewLine;
                }

                if (doCurrent.IsGreen())
                {
                    chkGrnOlvs.Checked = true;
                    txtDelOrder.Text += "Green Olives\n" + Environment.NewLine;
                }

                if (doCurrent.IsShrooms())
                {
                    chkShrooms.Checked = true;
                    txtDelOrder.Text += "Mushrooms\n" + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There are no more orders in the queue.",
                    "Halbo's Pizza Parlor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            ClearDelivery();
        }
    }
}
