namespace MY_Class_Project.Forms
{
    partial class BookingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersons = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDrinkCalculate = new System.Windows.Forms.Button();
            this.lblDrinkCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWaterQty = new System.Windows.Forms.TextBox();
            this.txtWaterPrice = new System.Windows.Forms.TextBox();
            this.txtJuiceQty = new System.Windows.Forms.TextBox();
            this.txtJuicePrice = new System.Windows.Forms.TextBox();
            this.txtSpriteQty = new System.Windows.Forms.TextBox();
            this.txtSpritePrice = new System.Windows.Forms.TextBox();
            this.txt7upQty = new System.Windows.Forms.TextBox();
            this.txt7upPrice = new System.Windows.Forms.TextBox();
            this.txtColaQty = new System.Windows.Forms.TextBox();
            this.txtColaPrice = new System.Windows.Forms.TextBox();
            this.chkWater = new System.Windows.Forms.CheckBox();
            this.chkJuice = new System.Windows.Forms.CheckBox();
            this.chkSprite = new System.Windows.Forms.CheckBox();
            this.chk7up = new System.Windows.Forms.CheckBox();
            this.chkCola = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFoodCalculate = new System.Windows.Forms.Button();
            this.lblFoodCost = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKebabQty = new System.Windows.Forms.TextBox();
            this.txtKebabPrice = new System.Windows.Forms.TextBox();
            this.txtBiryaniQty = new System.Windows.Forms.TextBox();
            this.txtBiryaniPrice = new System.Windows.Forms.TextBox();
            this.txtFishQty = new System.Windows.Forms.TextBox();
            this.txtFishPrice = new System.Windows.Forms.TextBox();
            this.txtChickenQty = new System.Windows.Forms.TextBox();
            this.txtChickenPrice = new System.Windows.Forms.TextBox();
            this.txtMuttonQty = new System.Windows.Forms.TextBox();
            this.txtMuttonPrice = new System.Windows.Forms.TextBox();
            this.chkKebab = new System.Windows.Forms.CheckBox();
            this.chkBiryani = new System.Windows.Forms.CheckBox();
            this.chkFish = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkMutton = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.txtOtherCharges = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 41);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "Booking";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 31);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(306, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Time";
            // 
            // cmbTime
            // 
            this.cmbTime.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.cmbTime.Location = new System.Drawing.Point(388, 59);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(118, 32);
            this.cmbTime.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(516, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "NO Person";
            // 
            // txtPersons
            // 
            this.txtPersons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPersons.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersons.Location = new System.Drawing.Point(679, 53);
            this.txtPersons.Multiline = true;
            this.txtPersons.Name = "txtPersons";
            this.txtPersons.Size = new System.Drawing.Size(97, 36);
            this.txtPersons.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDrinkCalculate);
            this.groupBox1.Controls.Add(this.lblDrinkCost);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtWaterQty);
            this.groupBox1.Controls.Add(this.txtWaterPrice);
            this.groupBox1.Controls.Add(this.txtJuiceQty);
            this.groupBox1.Controls.Add(this.txtJuicePrice);
            this.groupBox1.Controls.Add(this.txtSpriteQty);
            this.groupBox1.Controls.Add(this.txtSpritePrice);
            this.groupBox1.Controls.Add(this.txt7upQty);
            this.groupBox1.Controls.Add(this.txt7upPrice);
            this.groupBox1.Controls.Add(this.txtColaQty);
            this.groupBox1.Controls.Add(this.txtColaPrice);
            this.groupBox1.Controls.Add(this.chkWater);
            this.groupBox1.Controls.Add(this.chkJuice);
            this.groupBox1.Controls.Add(this.chkSprite);
            this.groupBox1.Controls.Add(this.chk7up);
            this.groupBox1.Controls.Add(this.chkCola);
            this.groupBox1.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Location = new System.Drawing.Point(77, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 386);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beverages";
            // 
            // btnDrinkCalculate
            // 
            this.btnDrinkCalculate.BackColor = System.Drawing.Color.White;
            this.btnDrinkCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrinkCalculate.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnDrinkCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrinkCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinkCalculate.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnDrinkCalculate.Location = new System.Drawing.Point(89, 341);
            this.btnDrinkCalculate.Name = "btnDrinkCalculate";
            this.btnDrinkCalculate.Size = new System.Drawing.Size(117, 32);
            this.btnDrinkCalculate.TabIndex = 33;
            this.btnDrinkCalculate.Text = "Claculate";
            this.btnDrinkCalculate.UseVisualStyleBackColor = false;
            this.btnDrinkCalculate.Click += new System.EventHandler(this.btnDrinkCalculate_Click);
            // 
            // lblDrinkCost
            // 
            this.lblDrinkCost.AutoSize = true;
            this.lblDrinkCost.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinkCost.ForeColor = System.Drawing.Color.LightCoral;
            this.lblDrinkCost.Location = new System.Drawing.Point(212, 341);
            this.lblDrinkCost.Name = "lblDrinkCost";
            this.lblDrinkCost.Size = new System.Drawing.Size(145, 32);
            this.lblDrinkCost.TabIndex = 30;
            this.lblDrinkCost.Text = "DrinkCost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightCoral;
            this.label6.Location = new System.Drawing.Point(199, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 32);
            this.label6.TabIndex = 29;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(305, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 32);
            this.label5.TabIndex = 28;
            this.label5.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(58, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Items";
            // 
            // txtWaterQty
            // 
            this.txtWaterQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWaterQty.Location = new System.Drawing.Point(311, 280);
            this.txtWaterQty.Multiline = true;
            this.txtWaterQty.Name = "txtWaterQty";
            this.txtWaterQty.Size = new System.Drawing.Size(103, 37);
            this.txtWaterQty.TabIndex = 26;
            // 
            // txtWaterPrice
            // 
            this.txtWaterPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWaterPrice.Location = new System.Drawing.Point(189, 280);
            this.txtWaterPrice.Multiline = true;
            this.txtWaterPrice.Name = "txtWaterPrice";
            this.txtWaterPrice.Size = new System.Drawing.Size(103, 37);
            this.txtWaterPrice.TabIndex = 25;
            // 
            // txtJuiceQty
            // 
            this.txtJuiceQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJuiceQty.Location = new System.Drawing.Point(311, 237);
            this.txtJuiceQty.Multiline = true;
            this.txtJuiceQty.Name = "txtJuiceQty";
            this.txtJuiceQty.Size = new System.Drawing.Size(103, 37);
            this.txtJuiceQty.TabIndex = 22;
            // 
            // txtJuicePrice
            // 
            this.txtJuicePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJuicePrice.Location = new System.Drawing.Point(189, 237);
            this.txtJuicePrice.Multiline = true;
            this.txtJuicePrice.Name = "txtJuicePrice";
            this.txtJuicePrice.Size = new System.Drawing.Size(103, 37);
            this.txtJuicePrice.TabIndex = 21;
            // 
            // txtSpriteQty
            // 
            this.txtSpriteQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpriteQty.Location = new System.Drawing.Point(311, 194);
            this.txtSpriteQty.Multiline = true;
            this.txtSpriteQty.Name = "txtSpriteQty";
            this.txtSpriteQty.Size = new System.Drawing.Size(103, 37);
            this.txtSpriteQty.TabIndex = 20;
            // 
            // txtSpritePrice
            // 
            this.txtSpritePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpritePrice.Location = new System.Drawing.Point(189, 194);
            this.txtSpritePrice.Multiline = true;
            this.txtSpritePrice.Name = "txtSpritePrice";
            this.txtSpritePrice.Size = new System.Drawing.Size(103, 37);
            this.txtSpritePrice.TabIndex = 19;
            // 
            // txt7upQty
            // 
            this.txt7upQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt7upQty.Location = new System.Drawing.Point(311, 151);
            this.txt7upQty.Multiline = true;
            this.txt7upQty.Name = "txt7upQty";
            this.txt7upQty.Size = new System.Drawing.Size(103, 37);
            this.txt7upQty.TabIndex = 18;
            // 
            // txt7upPrice
            // 
            this.txt7upPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt7upPrice.Location = new System.Drawing.Point(189, 151);
            this.txt7upPrice.Multiline = true;
            this.txt7upPrice.Name = "txt7upPrice";
            this.txt7upPrice.Size = new System.Drawing.Size(103, 37);
            this.txt7upPrice.TabIndex = 17;
            // 
            // txtColaQty
            // 
            this.txtColaQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColaQty.Location = new System.Drawing.Point(311, 108);
            this.txtColaQty.Multiline = true;
            this.txtColaQty.Name = "txtColaQty";
            this.txtColaQty.Size = new System.Drawing.Size(103, 37);
            this.txtColaQty.TabIndex = 16;
            // 
            // txtColaPrice
            // 
            this.txtColaPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColaPrice.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColaPrice.Location = new System.Drawing.Point(189, 108);
            this.txtColaPrice.Multiline = true;
            this.txtColaPrice.Name = "txtColaPrice";
            this.txtColaPrice.Size = new System.Drawing.Size(103, 37);
            this.txtColaPrice.TabIndex = 15;
            // 
            // chkWater
            // 
            this.chkWater.AutoSize = true;
            this.chkWater.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkWater.Location = new System.Drawing.Point(33, 276);
            this.chkWater.Name = "chkWater";
            this.chkWater.Size = new System.Drawing.Size(113, 36);
            this.chkWater.TabIndex = 5;
            this.chkWater.Text = "Water";
            this.chkWater.UseVisualStyleBackColor = true;
            // 
            // chkJuice
            // 
            this.chkJuice.AutoSize = true;
            this.chkJuice.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkJuice.Location = new System.Drawing.Point(33, 235);
            this.chkJuice.Name = "chkJuice";
            this.chkJuice.Size = new System.Drawing.Size(101, 36);
            this.chkJuice.TabIndex = 3;
            this.chkJuice.Text = "Juice";
            this.chkJuice.UseVisualStyleBackColor = true;
            // 
            // chkSprite
            // 
            this.chkSprite.AutoSize = true;
            this.chkSprite.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkSprite.Location = new System.Drawing.Point(33, 193);
            this.chkSprite.Name = "chkSprite";
            this.chkSprite.Size = new System.Drawing.Size(115, 36);
            this.chkSprite.TabIndex = 2;
            this.chkSprite.Text = "Sprite";
            this.chkSprite.UseVisualStyleBackColor = true;
            // 
            // chk7up
            // 
            this.chk7up.AutoSize = true;
            this.chk7up.ForeColor = System.Drawing.Color.DarkGreen;
            this.chk7up.Location = new System.Drawing.Point(33, 151);
            this.chk7up.Name = "chk7up";
            this.chk7up.Size = new System.Drawing.Size(88, 36);
            this.chk7up.TabIndex = 1;
            this.chk7up.Text = "7UP";
            this.chk7up.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            this.chkCola.AutoSize = true;
            this.chkCola.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkCola.Location = new System.Drawing.Point(33, 109);
            this.chkCola.Name = "chkCola";
            this.chkCola.Size = new System.Drawing.Size(96, 36);
            this.chkCola.TabIndex = 0;
            this.chkCola.Text = "Cola";
            this.chkCola.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFoodCalculate);
            this.groupBox2.Controls.Add(this.lblFoodCost);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtKebabQty);
            this.groupBox2.Controls.Add(this.txtKebabPrice);
            this.groupBox2.Controls.Add(this.txtBiryaniQty);
            this.groupBox2.Controls.Add(this.txtBiryaniPrice);
            this.groupBox2.Controls.Add(this.txtFishQty);
            this.groupBox2.Controls.Add(this.txtFishPrice);
            this.groupBox2.Controls.Add(this.txtChickenQty);
            this.groupBox2.Controls.Add(this.txtChickenPrice);
            this.groupBox2.Controls.Add(this.txtMuttonQty);
            this.groupBox2.Controls.Add(this.txtMuttonPrice);
            this.groupBox2.Controls.Add(this.chkKebab);
            this.groupBox2.Controls.Add(this.chkBiryani);
            this.groupBox2.Controls.Add(this.chkFish);
            this.groupBox2.Controls.Add(this.chkChicken);
            this.groupBox2.Controls.Add(this.chkMutton);
            this.groupBox2.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox2.Location = new System.Drawing.Point(655, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 386);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dishes";
            // 
            // btnFoodCalculate
            // 
            this.btnFoodCalculate.BackColor = System.Drawing.Color.White;
            this.btnFoodCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodCalculate.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnFoodCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodCalculate.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnFoodCalculate.Location = new System.Drawing.Point(76, 338);
            this.btnFoodCalculate.Name = "btnFoodCalculate";
            this.btnFoodCalculate.Size = new System.Drawing.Size(117, 32);
            this.btnFoodCalculate.TabIndex = 35;
            this.btnFoodCalculate.Text = "Claculate";
            this.btnFoodCalculate.UseVisualStyleBackColor = false;
            this.btnFoodCalculate.Click += new System.EventHandler(this.btnFoodCalculate_Click);
            // 
            // lblFoodCost
            // 
            this.lblFoodCost.AutoSize = true;
            this.lblFoodCost.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodCost.ForeColor = System.Drawing.Color.LightCoral;
            this.lblFoodCost.Location = new System.Drawing.Point(199, 338);
            this.lblFoodCost.Name = "lblFoodCost";
            this.lblFoodCost.Size = new System.Drawing.Size(142, 32);
            this.lblFoodCost.TabIndex = 34;
            this.lblFoodCost.Text = "FoodCost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightCoral;
            this.label10.Location = new System.Drawing.Point(199, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 32);
            this.label10.TabIndex = 29;
            this.label10.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightCoral;
            this.label11.Location = new System.Drawing.Point(305, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 32);
            this.label11.TabIndex = 28;
            this.label11.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightCoral;
            this.label12.Location = new System.Drawing.Point(58, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 32);
            this.label12.TabIndex = 27;
            this.label12.Text = "Items";
            // 
            // txtKebabQty
            // 
            this.txtKebabQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKebabQty.Location = new System.Drawing.Point(311, 280);
            this.txtKebabQty.Multiline = true;
            this.txtKebabQty.Name = "txtKebabQty";
            this.txtKebabQty.Size = new System.Drawing.Size(103, 37);
            this.txtKebabQty.TabIndex = 26;
            // 
            // txtKebabPrice
            // 
            this.txtKebabPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKebabPrice.Location = new System.Drawing.Point(189, 280);
            this.txtKebabPrice.Multiline = true;
            this.txtKebabPrice.Name = "txtKebabPrice";
            this.txtKebabPrice.Size = new System.Drawing.Size(103, 37);
            this.txtKebabPrice.TabIndex = 25;
            // 
            // txtBiryaniQty
            // 
            this.txtBiryaniQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBiryaniQty.Location = new System.Drawing.Point(311, 237);
            this.txtBiryaniQty.Multiline = true;
            this.txtBiryaniQty.Name = "txtBiryaniQty";
            this.txtBiryaniQty.Size = new System.Drawing.Size(103, 37);
            this.txtBiryaniQty.TabIndex = 22;
            // 
            // txtBiryaniPrice
            // 
            this.txtBiryaniPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBiryaniPrice.Location = new System.Drawing.Point(189, 237);
            this.txtBiryaniPrice.Multiline = true;
            this.txtBiryaniPrice.Name = "txtBiryaniPrice";
            this.txtBiryaniPrice.Size = new System.Drawing.Size(103, 37);
            this.txtBiryaniPrice.TabIndex = 21;
            // 
            // txtFishQty
            // 
            this.txtFishQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFishQty.Location = new System.Drawing.Point(311, 194);
            this.txtFishQty.Multiline = true;
            this.txtFishQty.Name = "txtFishQty";
            this.txtFishQty.Size = new System.Drawing.Size(103, 37);
            this.txtFishQty.TabIndex = 20;
            // 
            // txtFishPrice
            // 
            this.txtFishPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFishPrice.Location = new System.Drawing.Point(189, 194);
            this.txtFishPrice.Multiline = true;
            this.txtFishPrice.Name = "txtFishPrice";
            this.txtFishPrice.Size = new System.Drawing.Size(103, 37);
            this.txtFishPrice.TabIndex = 19;
            // 
            // txtChickenQty
            // 
            this.txtChickenQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChickenQty.Location = new System.Drawing.Point(311, 151);
            this.txtChickenQty.Multiline = true;
            this.txtChickenQty.Name = "txtChickenQty";
            this.txtChickenQty.Size = new System.Drawing.Size(103, 37);
            this.txtChickenQty.TabIndex = 18;
            // 
            // txtChickenPrice
            // 
            this.txtChickenPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChickenPrice.Location = new System.Drawing.Point(189, 151);
            this.txtChickenPrice.Multiline = true;
            this.txtChickenPrice.Name = "txtChickenPrice";
            this.txtChickenPrice.Size = new System.Drawing.Size(103, 37);
            this.txtChickenPrice.TabIndex = 17;
            // 
            // txtMuttonQty
            // 
            this.txtMuttonQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMuttonQty.Location = new System.Drawing.Point(311, 108);
            this.txtMuttonQty.Multiline = true;
            this.txtMuttonQty.Name = "txtMuttonQty";
            this.txtMuttonQty.Size = new System.Drawing.Size(103, 37);
            this.txtMuttonQty.TabIndex = 16;
            // 
            // txtMuttonPrice
            // 
            this.txtMuttonPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMuttonPrice.Location = new System.Drawing.Point(189, 108);
            this.txtMuttonPrice.Multiline = true;
            this.txtMuttonPrice.Name = "txtMuttonPrice";
            this.txtMuttonPrice.Size = new System.Drawing.Size(103, 37);
            this.txtMuttonPrice.TabIndex = 15;
            // 
            // chkKebab
            // 
            this.chkKebab.AutoSize = true;
            this.chkKebab.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkKebab.Location = new System.Drawing.Point(33, 276);
            this.chkKebab.Name = "chkKebab";
            this.chkKebab.Size = new System.Drawing.Size(116, 36);
            this.chkKebab.TabIndex = 5;
            this.chkKebab.Text = "Kebab";
            this.chkKebab.UseVisualStyleBackColor = true;
            // 
            // chkBiryani
            // 
            this.chkBiryani.AutoSize = true;
            this.chkBiryani.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkBiryani.Location = new System.Drawing.Point(33, 235);
            this.chkBiryani.Name = "chkBiryani";
            this.chkBiryani.Size = new System.Drawing.Size(134, 36);
            this.chkBiryani.TabIndex = 3;
            this.chkBiryani.Text = "Biryani";
            this.chkBiryani.UseVisualStyleBackColor = true;
            // 
            // chkFish
            // 
            this.chkFish.AutoSize = true;
            this.chkFish.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkFish.Location = new System.Drawing.Point(33, 193);
            this.chkFish.Name = "chkFish";
            this.chkFish.Size = new System.Drawing.Size(94, 36);
            this.chkFish.TabIndex = 2;
            this.chkFish.Text = "Fish";
            this.chkFish.UseVisualStyleBackColor = true;
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkChicken.Location = new System.Drawing.Point(33, 151);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(140, 36);
            this.chkChicken.TabIndex = 1;
            this.chkChicken.Text = "Chicken";
            this.chkChicken.UseVisualStyleBackColor = true;
            // 
            // chkMutton
            // 
            this.chkMutton.AutoSize = true;
            this.chkMutton.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkMutton.Location = new System.Drawing.Point(33, 109);
            this.chkMutton.Name = "chkMutton";
            this.chkMutton.Size = new System.Drawing.Size(127, 36);
            this.chkMutton.TabIndex = 0;
            this.chkMutton.Text = "Motton";
            this.chkMutton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCalculateTotal);
            this.groupBox3.Controls.Add(this.txtBalance);
            this.groupBox3.Controls.Add(this.txtGrandTotal);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtAdvance);
            this.groupBox3.Controls.Add(this.txtOtherCharges);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox26);
            this.groupBox3.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox3.Location = new System.Drawing.Point(88, 509);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1007, 200);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payments";
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.BackColor = System.Drawing.Color.White;
            this.btnCalculateTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateTotal.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnCalculateTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCalculateTotal.Location = new System.Drawing.Point(460, 159);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(160, 35);
            this.btnCalculateTotal.TabIndex = 38;
            this.btnCalculateTotal.Text = "CalculateTotal";
            this.btnCalculateTotal.UseVisualStyleBackColor = false;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBalance.Location = new System.Drawing.Point(815, 98);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(145, 37);
            this.txtBalance.TabIndex = 37;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrandTotal.Location = new System.Drawing.Point(815, 46);
            this.txtGrandTotal.Multiline = true;
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(145, 37);
            this.txtGrandTotal.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightCoral;
            this.label15.Location = new System.Drawing.Point(615, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 32);
            this.label15.TabIndex = 35;
            this.label15.Text = "Balance";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightCoral;
            this.label16.Location = new System.Drawing.Point(615, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 32);
            this.label16.TabIndex = 34;
            this.label16.Text = "GrdTotal";
            // 
            // txtAdvance
            // 
            this.txtAdvance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdvance.Location = new System.Drawing.Point(315, 98);
            this.txtAdvance.Multiline = true;
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(145, 37);
            this.txtAdvance.TabIndex = 33;
            // 
            // txtOtherCharges
            // 
            this.txtOtherCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtherCharges.Location = new System.Drawing.Point(315, 46);
            this.txtOtherCharges.Multiline = true;
            this.txtOtherCharges.Name = "txtOtherCharges";
            this.txtOtherCharges.Size = new System.Drawing.Size(145, 37);
            this.txtOtherCharges.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.LightCoral;
            this.label14.Location = new System.Drawing.Point(107, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 32);
            this.label14.TabIndex = 29;
            this.label14.Text = "Advance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightCoral;
            this.label13.Location = new System.Drawing.Point(107, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 32);
            this.label13.TabIndex = 28;
            this.label13.Text = "Other Charges";
            // 
            // textBox26
            // 
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox26.Location = new System.Drawing.Point(311, 323);
            this.textBox26.Multiline = true;
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(103, 37);
            this.textBox26.TabIndex = 26;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.BackColor = System.Drawing.Color.White;
            this.btnAddBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBooking.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnAddBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooking.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAddBooking.Location = new System.Drawing.Point(345, 739);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(160, 35);
            this.btnAddBooking.TabIndex = 32;
            this.btnAddBooking.Text = "AddBooking";
            this.btnAddBooking.UseVisualStyleBackColor = false;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(540, 739);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 35);
            this.button1.TabIndex = 33;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboCustomer
            // 
            this.comboCustomer.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Location = new System.Drawing.Point(903, 55);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(118, 32);
            this.comboCustomer.TabIndex = 35;
            this.comboCustomer.SelectionChangeCommitted += new System.EventHandler(this.comboCustomer_SelectionChangeCommitted);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkGreen;
            this.label17.Location = new System.Drawing.Point(788, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 32);
            this.label17.TabIndex = 34;
            this.label17.Text = "Cust ID";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCustomerName.Location = new System.Drawing.Point(1031, 55);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(146, 32);
            this.lblCustomerName.TabIndex = 36;
            this.lblCustomerName.Text = "CustName";
            // 
            // btnButton
            // 
            this.btnButton.BackColor = System.Drawing.Color.White;
            this.btnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnButton.Location = new System.Drawing.Point(737, 739);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(160, 35);
            this.btnButton.TabIndex = 39;
            this.btnButton.Text = "Home";
            this.btnButton.UseVisualStyleBackColor = false;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 804);
            this.Controls.Add(this.btnButton);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.comboCustomer);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPersons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Harrington", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCola;
        private System.Windows.Forms.CheckBox chkJuice;
        private System.Windows.Forms.CheckBox chkSprite;
        private System.Windows.Forms.CheckBox chk7up;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWaterQty;
        private System.Windows.Forms.TextBox txtWaterPrice;
        private System.Windows.Forms.TextBox txtJuiceQty;
        private System.Windows.Forms.TextBox txtJuicePrice;
        private System.Windows.Forms.TextBox txtSpriteQty;
        private System.Windows.Forms.TextBox txtSpritePrice;
        private System.Windows.Forms.TextBox txt7upQty;
        private System.Windows.Forms.TextBox txt7upPrice;
        private System.Windows.Forms.TextBox txtColaQty;
        private System.Windows.Forms.TextBox txtColaPrice;
        private System.Windows.Forms.CheckBox chkWater;
        private System.Windows.Forms.Label lblDrinkCost;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKebabQty;
        private System.Windows.Forms.TextBox txtKebabPrice;
        private System.Windows.Forms.TextBox txtBiryaniQty;
        private System.Windows.Forms.TextBox txtBiryaniPrice;
        private System.Windows.Forms.TextBox txtFishQty;
        private System.Windows.Forms.TextBox txtFishPrice;
        private System.Windows.Forms.TextBox txtChickenQty;
        private System.Windows.Forms.TextBox txtChickenPrice;
        private System.Windows.Forms.TextBox txtMuttonQty;
        private System.Windows.Forms.TextBox txtMuttonPrice;
        private System.Windows.Forms.CheckBox chkKebab;
        private System.Windows.Forms.CheckBox chkBiryani;
        private System.Windows.Forms.CheckBox chkFish;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkMutton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.TextBox txtOtherCharges;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnDrinkCalculate;
        private System.Windows.Forms.Button btnFoodCalculate;
        private System.Windows.Forms.Label lblFoodCost;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnButton;
    }
}