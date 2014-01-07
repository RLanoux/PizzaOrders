namespace IT151PizzaOrders
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.chkShrooms = new System.Windows.Forms.CheckBox();
            this.chkGrnOlvs = new System.Windows.Forms.CheckBox();
            this.chkBlkOlvs = new System.Windows.Forms.CheckBox();
            this.chkGrnPprs = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.chkCanBac = new System.Windows.Forms.CheckBox();
            this.chkPeproni = new System.Windows.Forms.CheckBox();
            this.chkItalSaus = new System.Windows.Forms.CheckBox();
            this.chkGrnBeef = new System.Windows.Forms.CheckBox();
            this.chkXCheese = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioXLarge = new System.Windows.Forms.RadioButton();
            this.radioLarge = new System.Windows.Forms.RadioButton();
            this.radioMedium = new System.Windows.Forms.RadioButton();
            this.radioSmall = new System.Windows.Forms.RadioButton();
            this.radioPersonal = new System.Windows.Forms.RadioButton();
            this.btnSwitchMode = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDelivery = new System.Windows.Forms.GroupBox();
            this.btnPullNextOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDelOrder = new System.Windows.Forms.TextBox();
            this.btnDelivered = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNextDel = new System.Windows.Forms.TextBox();
            this.grpOrder.SuspendLayout();
            this.grpDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.btnClear);
            this.grpOrder.Controls.Add(this.btnSubmit);
            this.grpOrder.Controls.Add(this.label3);
            this.grpOrder.Controls.Add(this.txtDeliveryAddress);
            this.grpOrder.Controls.Add(this.chkShrooms);
            this.grpOrder.Controls.Add(this.chkGrnOlvs);
            this.grpOrder.Controls.Add(this.chkBlkOlvs);
            this.grpOrder.Controls.Add(this.chkGrnPprs);
            this.grpOrder.Controls.Add(this.chkOnions);
            this.grpOrder.Controls.Add(this.chkCanBac);
            this.grpOrder.Controls.Add(this.chkPeproni);
            this.grpOrder.Controls.Add(this.chkItalSaus);
            this.grpOrder.Controls.Add(this.chkGrnBeef);
            this.grpOrder.Controls.Add(this.chkXCheese);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Controls.Add(this.label1);
            this.grpOrder.Controls.Add(this.radioXLarge);
            this.grpOrder.Controls.Add(this.radioLarge);
            this.grpOrder.Controls.Add(this.radioMedium);
            this.grpOrder.Controls.Add(this.radioSmall);
            this.grpOrder.Controls.Add(this.radioPersonal);
            this.grpOrder.Location = new System.Drawing.Point(12, 12);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(510, 252);
            this.grpOrder.TabIndex = 0;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Place Order";
            this.grpOrder.Enter += new System.EventHandler(this.groupOrder_Enter);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(332, 215);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 23);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(418, 215);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 23);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Delivery Address:";
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Location = new System.Drawing.Point(112, 189);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(386, 20);
            this.txtDeliveryAddress.TabIndex = 17;
            // 
            // chkShrooms
            // 
            this.chkShrooms.AutoSize = true;
            this.chkShrooms.Location = new System.Drawing.Point(418, 151);
            this.chkShrooms.Name = "chkShrooms";
            this.chkShrooms.Size = new System.Drawing.Size(80, 17);
            this.chkShrooms.TabIndex = 16;
            this.chkShrooms.Text = "Mushrooms";
            this.chkShrooms.UseVisualStyleBackColor = true;
            // 
            // chkGrnOlvs
            // 
            this.chkGrnOlvs.AutoSize = true;
            this.chkGrnOlvs.Location = new System.Drawing.Point(329, 151);
            this.chkGrnOlvs.Name = "chkGrnOlvs";
            this.chkGrnOlvs.Size = new System.Drawing.Size(87, 17);
            this.chkGrnOlvs.TabIndex = 15;
            this.chkGrnOlvs.Text = "Green Olives";
            this.chkGrnOlvs.UseVisualStyleBackColor = true;
            // 
            // chkBlkOlvs
            // 
            this.chkBlkOlvs.AutoSize = true;
            this.chkBlkOlvs.Location = new System.Drawing.Point(250, 151);
            this.chkBlkOlvs.Name = "chkBlkOlvs";
            this.chkBlkOlvs.Size = new System.Drawing.Size(85, 17);
            this.chkBlkOlvs.TabIndex = 14;
            this.chkBlkOlvs.Text = "Black Olives";
            this.chkBlkOlvs.UseVisualStyleBackColor = true;
            // 
            // chkGrnPprs
            // 
            this.chkGrnPprs.AutoSize = true;
            this.chkGrnPprs.Location = new System.Drawing.Point(145, 151);
            this.chkGrnPprs.Name = "chkGrnPprs";
            this.chkGrnPprs.Size = new System.Drawing.Size(97, 17);
            this.chkGrnPprs.TabIndex = 13;
            this.chkGrnPprs.Text = "Green Peppers";
            this.chkGrnPprs.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Location = new System.Drawing.Point(53, 151);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(59, 17);
            this.chkOnions.TabIndex = 12;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            // 
            // chkCanBac
            // 
            this.chkCanBac.AutoSize = true;
            this.chkCanBac.Location = new System.Drawing.Point(329, 128);
            this.chkCanBac.Name = "chkCanBac";
            this.chkCanBac.Size = new System.Drawing.Size(105, 17);
            this.chkCanBac.TabIndex = 11;
            this.chkCanBac.Text = "Canadian Bacon";
            this.chkCanBac.UseVisualStyleBackColor = true;
            // 
            // chkPeproni
            // 
            this.chkPeproni.AutoSize = true;
            this.chkPeproni.Location = new System.Drawing.Point(250, 128);
            this.chkPeproni.Name = "chkPeproni";
            this.chkPeproni.Size = new System.Drawing.Size(74, 17);
            this.chkPeproni.TabIndex = 10;
            this.chkPeproni.Text = "Pepperoni";
            this.chkPeproni.UseVisualStyleBackColor = true;
            // 
            // chkItalSaus
            // 
            this.chkItalSaus.AutoSize = true;
            this.chkItalSaus.Location = new System.Drawing.Point(145, 128);
            this.chkItalSaus.Name = "chkItalSaus";
            this.chkItalSaus.Size = new System.Drawing.Size(99, 17);
            this.chkItalSaus.TabIndex = 9;
            this.chkItalSaus.Text = "Italian Sausage";
            this.chkItalSaus.UseVisualStyleBackColor = true;
            // 
            // chkGrnBeef
            // 
            this.chkGrnBeef.AutoSize = true;
            this.chkGrnBeef.Location = new System.Drawing.Point(53, 128);
            this.chkGrnBeef.Name = "chkGrnBeef";
            this.chkGrnBeef.Size = new System.Drawing.Size(86, 17);
            this.chkGrnBeef.TabIndex = 8;
            this.chkGrnBeef.Text = "Ground Beef";
            this.chkGrnBeef.UseVisualStyleBackColor = true;
            // 
            // chkXCheese
            // 
            this.chkXCheese.AutoSize = true;
            this.chkXCheese.Location = new System.Drawing.Point(53, 105);
            this.chkXCheese.Name = "chkXCheese";
            this.chkXCheese.Size = new System.Drawing.Size(89, 17);
            this.chkXCheese.TabIndex = 7;
            this.chkXCheese.Text = "Extra Cheese";
            this.chkXCheese.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Toppings:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Size:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioXLarge
            // 
            this.radioXLarge.AutoSize = true;
            this.radioXLarge.Location = new System.Drawing.Point(307, 24);
            this.radioXLarge.Name = "radioXLarge";
            this.radioXLarge.Size = new System.Drawing.Size(62, 17);
            this.radioXLarge.TabIndex = 4;
            this.radioXLarge.TabStop = true;
            this.radioXLarge.Text = "X-Large";
            this.radioXLarge.UseVisualStyleBackColor = true;
            // 
            // radioLarge
            // 
            this.radioLarge.AutoSize = true;
            this.radioLarge.Location = new System.Drawing.Point(249, 24);
            this.radioLarge.Name = "radioLarge";
            this.radioLarge.Size = new System.Drawing.Size(52, 17);
            this.radioLarge.TabIndex = 3;
            this.radioLarge.TabStop = true;
            this.radioLarge.Text = "Large";
            this.radioLarge.UseVisualStyleBackColor = true;
            // 
            // radioMedium
            // 
            this.radioMedium.AutoSize = true;
            this.radioMedium.Location = new System.Drawing.Point(181, 24);
            this.radioMedium.Name = "radioMedium";
            this.radioMedium.Size = new System.Drawing.Size(62, 17);
            this.radioMedium.TabIndex = 2;
            this.radioMedium.TabStop = true;
            this.radioMedium.Text = "Medium";
            this.radioMedium.UseVisualStyleBackColor = true;
            // 
            // radioSmall
            // 
            this.radioSmall.AutoSize = true;
            this.radioSmall.Location = new System.Drawing.Point(125, 24);
            this.radioSmall.Name = "radioSmall";
            this.radioSmall.Size = new System.Drawing.Size(50, 17);
            this.radioSmall.TabIndex = 1;
            this.radioSmall.TabStop = true;
            this.radioSmall.Text = "Small";
            this.radioSmall.UseVisualStyleBackColor = true;
            // 
            // radioPersonal
            // 
            this.radioPersonal.AutoSize = true;
            this.radioPersonal.Checked = true;
            this.radioPersonal.Location = new System.Drawing.Point(53, 24);
            this.radioPersonal.Name = "radioPersonal";
            this.radioPersonal.Size = new System.Drawing.Size(66, 17);
            this.radioPersonal.TabIndex = 0;
            this.radioPersonal.TabStop = true;
            this.radioPersonal.Text = "Personal";
            this.radioPersonal.UseVisualStyleBackColor = true;
            // 
            // btnSwitchMode
            // 
            this.btnSwitchMode.Location = new System.Drawing.Point(181, 270);
            this.btnSwitchMode.Name = "btnSwitchMode";
            this.btnSwitchMode.Size = new System.Drawing.Size(166, 24);
            this.btnSwitchMode.TabIndex = 1;
            this.btnSwitchMode.Text = "Switch to Delivery Mode";
            this.btnSwitchMode.UseVisualStyleBackColor = true;
            this.btnSwitchMode.Click += new System.EventHandler(this.btnSwitchMode_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(430, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "E&xit System";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpDelivery
            // 
            this.grpDelivery.Controls.Add(this.btnPullNextOrder);
            this.grpDelivery.Controls.Add(this.label5);
            this.grpDelivery.Controls.Add(this.txtDelOrder);
            this.grpDelivery.Controls.Add(this.btnDelivered);
            this.grpDelivery.Controls.Add(this.label4);
            this.grpDelivery.Controls.Add(this.txtNextDel);
            this.grpDelivery.Location = new System.Drawing.Point(12, 12);
            this.grpDelivery.Name = "grpDelivery";
            this.grpDelivery.Size = new System.Drawing.Size(510, 252);
            this.grpDelivery.TabIndex = 21;
            this.grpDelivery.TabStop = false;
            this.grpDelivery.Text = "Delivery";
            this.grpDelivery.Visible = false;
            // 
            // btnPullNextOrder
            // 
            this.btnPullNextOrder.Location = new System.Drawing.Point(286, 51);
            this.btnPullNextOrder.Name = "btnPullNextOrder";
            this.btnPullNextOrder.Size = new System.Drawing.Size(95, 23);
            this.btnPullNextOrder.TabIndex = 23;
            this.btnPullNextOrder.Text = "Next Delivery";
            this.btnPullNextOrder.UseVisualStyleBackColor = true;
            this.btnPullNextOrder.Click += new System.EventHandler(this.btnPullNextOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Pizza Order:";
            // 
            // txtDelOrder
            // 
            this.txtDelOrder.BackColor = System.Drawing.SystemColors.Info;
            this.txtDelOrder.Location = new System.Drawing.Point(96, 86);
            this.txtDelOrder.Multiline = true;
            this.txtDelOrder.Name = "txtDelOrder";
            this.txtDelOrder.ReadOnly = true;
            this.txtDelOrder.Size = new System.Drawing.Size(386, 138);
            this.txtDelOrder.TabIndex = 21;
            // 
            // btnDelivered
            // 
            this.btnDelivered.Location = new System.Drawing.Point(387, 51);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Size = new System.Drawing.Size(95, 23);
            this.btnDelivered.TabIndex = 20;
            this.btnDelivered.Text = "Delivered";
            this.btnDelivered.UseVisualStyleBackColor = true;
            this.btnDelivered.Click += new System.EventHandler(this.btnDelivered_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Next Delivery:";
            // 
            // txtNextDel
            // 
            this.txtNextDel.Location = new System.Drawing.Point(96, 25);
            this.txtNextDel.Name = "txtNextDel";
            this.txtNextDel.Size = new System.Drawing.Size(386, 20);
            this.txtNextDel.TabIndex = 18;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 301);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSwitchMode);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grpDelivery);
            this.Name = "frmMain";
            this.Text = "Halbo\'s Pizza Parlor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.grpDelivery.ResumeLayout(false);
            this.grpDelivery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioXLarge;
        private System.Windows.Forms.RadioButton radioLarge;
        private System.Windows.Forms.RadioButton radioMedium;
        private System.Windows.Forms.RadioButton radioSmall;
        private System.Windows.Forms.RadioButton radioPersonal;
        private System.Windows.Forms.CheckBox chkShrooms;
        private System.Windows.Forms.CheckBox chkGrnOlvs;
        private System.Windows.Forms.CheckBox chkBlkOlvs;
        private System.Windows.Forms.CheckBox chkGrnPprs;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.CheckBox chkCanBac;
        private System.Windows.Forms.CheckBox chkPeproni;
        private System.Windows.Forms.CheckBox chkItalSaus;
        private System.Windows.Forms.CheckBox chkGrnBeef;
        private System.Windows.Forms.CheckBox chkXCheese;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Button btnSwitchMode;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpDelivery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDelOrder;
        private System.Windows.Forms.Button btnDelivered;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNextDel;
        private System.Windows.Forms.Button btnPullNextOrder;
        private System.Windows.Forms.Button btnClear;
    }
}

