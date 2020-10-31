namespace LunchOrder
{
    partial class Form1
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
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.gbxMainCourse = new System.Windows.Forms.GroupBox();
            this.rbSalad = new System.Windows.Forms.RadioButton();
            this.rbPizza = new System.Windows.Forms.RadioButton();
            this.rbHam = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.cbAdd3 = new System.Windows.Forms.CheckBox();
            this.cbAdd2 = new System.Windows.Forms.CheckBox();
            this.cbAdd1 = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            this.gbxMainCourse.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlaceOrder.Location = new System.Drawing.Point(265, 142);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(88, 23);
            this.btnPlaceOrder.TabIndex = 17;
            this.btnPlaceOrder.Text = "Place &Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblOrderTotal);
            this.GroupBox1.Controls.Add(this.lblSalesTax);
            this.GroupBox1.Controls.Add(this.lblSubtotal);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(17, 134);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(224, 104);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Order total";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderTotal.Location = new System.Drawing.Point(104, 72);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(88, 20);
            this.lblOrderTotal.TabIndex = 5;
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesTax.Location = new System.Drawing.Point(104, 48);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(88, 20);
            this.lblSalesTax.TabIndex = 4;
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point(104, 24);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(88, 20);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 72);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 16);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Order total:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Tax (7.75%):";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Subtotal:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxMainCourse
            // 
            this.gbxMainCourse.Controls.Add(this.rbSalad);
            this.gbxMainCourse.Controls.Add(this.rbPizza);
            this.gbxMainCourse.Controls.Add(this.rbHam);
            this.gbxMainCourse.Location = new System.Drawing.Point(17, 14);
            this.gbxMainCourse.Name = "gbxMainCourse";
            this.gbxMainCourse.Size = new System.Drawing.Size(144, 104);
            this.gbxMainCourse.TabIndex = 19;
            this.gbxMainCourse.TabStop = false;
            this.gbxMainCourse.Text = "Main course";
            // 
            // rbSalad
            // 
            this.rbSalad.AutoSize = true;
            this.rbSalad.Location = new System.Drawing.Point(7, 68);
            this.rbSalad.Name = "rbSalad";
            this.rbSalad.Size = new System.Drawing.Size(88, 17);
            this.rbSalad.TabIndex = 2;
            this.rbSalad.TabStop = true;
            this.rbSalad.Text = "Salad - $4.95";
            this.rbSalad.UseVisualStyleBackColor = true;
            this.rbSalad.CheckedChanged += new System.EventHandler(this.rbSalad_CheckedChanged);
            // 
            // rbPizza
            // 
            this.rbPizza.AutoSize = true;
            this.rbPizza.Location = new System.Drawing.Point(7, 44);
            this.rbPizza.Name = "rbPizza";
            this.rbPizza.Size = new System.Drawing.Size(86, 17);
            this.rbPizza.TabIndex = 1;
            this.rbPizza.TabStop = true;
            this.rbPizza.Text = "Pizza - $5.95";
            this.rbPizza.UseVisualStyleBackColor = true;
            this.rbPizza.CheckedChanged += new System.EventHandler(this.rbPizza_CheckedChanged);
            // 
            // rbHam
            // 
            this.rbHam.AutoSize = true;
            this.rbHam.Location = new System.Drawing.Point(7, 20);
            this.rbHam.Name = "rbHam";
            this.rbHam.Size = new System.Drawing.Size(113, 17);
            this.rbHam.TabIndex = 0;
            this.rbHam.TabStop = true;
            this.rbHam.Text = "Hamberger - $6.95";
            this.rbHam.UseVisualStyleBackColor = true;
            this.rbHam.CheckedChanged += new System.EventHandler(this.rbHam_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(265, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.cbAdd3);
            this.gbAdd.Controls.Add(this.cbAdd2);
            this.gbAdd.Controls.Add(this.cbAdd1);
            this.gbAdd.Location = new System.Drawing.Point(167, 14);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(198, 104);
            this.gbAdd.TabIndex = 22;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add-on items";
            // 
            // cbAdd3
            // 
            this.cbAdd3.AutoSize = true;
            this.cbAdd3.Location = new System.Drawing.Point(7, 68);
            this.cbAdd3.Name = "cbAdd3";
            this.cbAdd3.Size = new System.Drawing.Size(15, 14);
            this.cbAdd3.TabIndex = 2;
            this.cbAdd3.UseVisualStyleBackColor = true;
            // 
            // cbAdd2
            // 
            this.cbAdd2.AutoSize = true;
            this.cbAdd2.Location = new System.Drawing.Point(7, 44);
            this.cbAdd2.Name = "cbAdd2";
            this.cbAdd2.Size = new System.Drawing.Size(15, 14);
            this.cbAdd2.TabIndex = 1;
            this.cbAdd2.UseVisualStyleBackColor = true;
            // 
            // cbAdd1
            // 
            this.cbAdd1.AutoSize = true;
            this.cbAdd1.Location = new System.Drawing.Point(7, 20);
            this.cbAdd1.Name = "cbAdd1";
            this.cbAdd1.Size = new System.Drawing.Size(15, 14);
            this.cbAdd1.TabIndex = 0;
            this.cbAdd1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(377, 251);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.gbxMainCourse);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.GroupBox1.ResumeLayout(false);
            this.gbxMainCourse.ResumeLayout(false);
            this.gbxMainCourse.PerformLayout();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnPlaceOrder;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblOrderTotal;
        internal System.Windows.Forms.Label lblSalesTax;
        internal System.Windows.Forms.Label lblSubtotal;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox gbxMainCourse;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbSalad;
        private System.Windows.Forms.RadioButton rbPizza;
        private System.Windows.Forms.RadioButton rbHam;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.CheckBox cbAdd3;
        private System.Windows.Forms.CheckBox cbAdd2;
        private System.Windows.Forms.CheckBox cbAdd1;
    }
}

