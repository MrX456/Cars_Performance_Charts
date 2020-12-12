namespace System.CPC.App
{
    partial class FrmCarsNew
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
            this.components = new System.ComponentModel.Container();
            this.panFields = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtMaxSpeed = new System.Windows.Forms.TextBox();
            this.lblMaxSpeed = new System.Windows.Forms.Label();
            this.txtTorque = new System.Windows.Forms.TextBox();
            this.lblTorque = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.lblPower = new System.Windows.Forms.Label();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.lblEngine = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblContry = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtMaker = new System.Windows.Forms.TextBox();
            this.lblMaker = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFields
            // 
            this.panFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panFields.Controls.Add(this.btnClearAll);
            this.panFields.Controls.Add(this.btnAddCar);
            this.panFields.Controls.Add(this.txtPrice);
            this.panFields.Controls.Add(this.lblPrice);
            this.panFields.Controls.Add(this.txtMaxSpeed);
            this.panFields.Controls.Add(this.lblMaxSpeed);
            this.panFields.Controls.Add(this.txtTorque);
            this.panFields.Controls.Add(this.lblTorque);
            this.panFields.Controls.Add(this.txtPower);
            this.panFields.Controls.Add(this.lblPower);
            this.panFields.Controls.Add(this.txtEngine);
            this.panFields.Controls.Add(this.lblEngine);
            this.panFields.Controls.Add(this.txtYear);
            this.panFields.Controls.Add(this.lblYear);
            this.panFields.Controls.Add(this.txtCountry);
            this.panFields.Controls.Add(this.lblContry);
            this.panFields.Controls.Add(this.txtModel);
            this.panFields.Controls.Add(this.lblModel);
            this.panFields.Controls.Add(this.txtMaker);
            this.panFields.Controls.Add(this.lblMaker);
            this.panFields.Location = new System.Drawing.Point(205, 12);
            this.panFields.Name = "panFields";
            this.panFields.Size = new System.Drawing.Size(863, 626);
            this.panFields.TabIndex = 0;
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAll.Location = new System.Drawing.Point(462, 365);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(129, 23);
            this.btnClearAll.TabIndex = 23;
            this.btnClearAll.Text = "Clear All";
            this.toolTip.SetToolTip(this.btnClearAll, "Clear all fields");
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCar.Location = new System.Drawing.Point(305, 365);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(129, 23);
            this.btnAddCar.TabIndex = 22;
            this.btnAddCar.Text = "Add Car";
            this.toolTip.SetToolTip(this.btnAddCar, "Add car to database");
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(509, 301);
            this.txtPrice.MaxLength = 11;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(208, 22);
            this.txtPrice.TabIndex = 17;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(506, 282);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 16);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price :";
            // 
            // txtMaxSpeed
            // 
            this.txtMaxSpeed.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMaxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxSpeed.Location = new System.Drawing.Point(172, 301);
            this.txtMaxSpeed.MaxLength = 3;
            this.txtMaxSpeed.Name = "txtMaxSpeed";
            this.txtMaxSpeed.Size = new System.Drawing.Size(208, 22);
            this.txtMaxSpeed.TabIndex = 15;
            this.toolTip.SetToolTip(this.txtMaxSpeed, "Speed(mph)");
            this.txtMaxSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxSpeed_KeyPress);
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.AutoSize = true;
            this.lblMaxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxSpeed.Location = new System.Drawing.Point(169, 282);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(83, 16);
            this.lblMaxSpeed.TabIndex = 14;
            this.lblMaxSpeed.Text = "Max Speed :";
            // 
            // txtTorque
            // 
            this.txtTorque.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTorque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTorque.Location = new System.Drawing.Point(509, 248);
            this.txtTorque.MaxLength = 4;
            this.txtTorque.Name = "txtTorque";
            this.txtTorque.Size = new System.Drawing.Size(208, 22);
            this.txtTorque.TabIndex = 13;
            this.toolTip.SetToolTip(this.txtTorque, "Torque(Nm)");
            this.txtTorque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTorque_KeyPress);
            // 
            // lblTorque
            // 
            this.lblTorque.AutoSize = true;
            this.lblTorque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTorque.Location = new System.Drawing.Point(506, 229);
            this.lblTorque.Name = "lblTorque";
            this.lblTorque.Size = new System.Drawing.Size(58, 16);
            this.lblTorque.TabIndex = 12;
            this.lblTorque.Text = "Torque :";
            // 
            // txtPower
            // 
            this.txtPower.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPower.Location = new System.Drawing.Point(172, 248);
            this.txtPower.MaxLength = 4;
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(208, 22);
            this.txtPower.TabIndex = 11;
            this.toolTip.SetToolTip(this.txtPower, "Power(hp)");
            this.txtPower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPower_KeyPress);
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.Location = new System.Drawing.Point(169, 229);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(52, 16);
            this.lblPower.TabIndex = 10;
            this.lblPower.Text = "Power :";
            // 
            // txtEngine
            // 
            this.txtEngine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEngine.Location = new System.Drawing.Point(509, 197);
            this.txtEngine.MaxLength = 5;
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(208, 22);
            this.txtEngine.TabIndex = 9;
            this.toolTip.SetToolTip(this.txtEngine, "Size(cc)");
            this.txtEngine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEngine_KeyPress);
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngine.Location = new System.Drawing.Point(506, 178);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(85, 16);
            this.lblEngine.TabIndex = 8;
            this.lblEngine.Text = "Engine Size :";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(172, 197);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(208, 22);
            this.txtYear.TabIndex = 7;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(169, 178);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(43, 16);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Year :";
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(172, 144);
            this.txtCountry.MaxLength = 20;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(313, 22);
            this.txtCountry.TabIndex = 5;
            // 
            // lblContry
            // 
            this.lblContry.AutoSize = true;
            this.lblContry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContry.Location = new System.Drawing.Point(169, 125);
            this.lblContry.Name = "lblContry";
            this.lblContry.Size = new System.Drawing.Size(59, 16);
            this.lblContry.TabIndex = 4;
            this.lblContry.Text = "Country :";
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(172, 94);
            this.txtModel.MaxLength = 30;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(545, 22);
            this.txtModel.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(169, 75);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 16);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model :";
            // 
            // txtMaker
            // 
            this.txtMaker.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaker.Location = new System.Drawing.Point(172, 45);
            this.txtMaker.MaxLength = 30;
            this.txtMaker.Name = "txtMaker";
            this.txtMaker.Size = new System.Drawing.Size(545, 22);
            this.txtMaker.TabIndex = 1;
            // 
            // lblMaker
            // 
            this.lblMaker.AutoSize = true;
            this.lblMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaker.Location = new System.Drawing.Point(169, 26);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(52, 16);
            this.lblMaker.TabIndex = 0;
            this.lblMaker.Text = "Maker :";
            // 
            // FrmCarsNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1274, 661);
            this.Controls.Add(this.panFields);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCarsNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Car";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panFields.ResumeLayout(false);
            this.panFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.Panel panFields;
        private Windows.Forms.TextBox txtMaker;
        private Windows.Forms.Label lblMaker;
        private Windows.Forms.TextBox txtCountry;
        private Windows.Forms.Label lblContry;
        private Windows.Forms.TextBox txtModel;
        private Windows.Forms.Label lblModel;
        private Windows.Forms.TextBox txtPrice;
        private Windows.Forms.Label lblPrice;
        private Windows.Forms.TextBox txtMaxSpeed;
        private Windows.Forms.Label lblMaxSpeed;
        private Windows.Forms.TextBox txtTorque;
        private Windows.Forms.Label lblTorque;
        private Windows.Forms.TextBox txtPower;
        private Windows.Forms.Label lblPower;
        private Windows.Forms.TextBox txtEngine;
        private Windows.Forms.Label lblEngine;
        private Windows.Forms.TextBox txtYear;
        private Windows.Forms.Label lblYear;
        private Windows.Forms.Button btnAddCar;
        private Windows.Forms.ToolTip toolTip;
        private Windows.Forms.Button btnClearAll;
    }
}