namespace System.CPC.App
{
    partial class FrmCarsSearch
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
            this.picFilter = new System.Windows.Forms.PictureBox();
            this.lblFilterModel = new System.Windows.Forms.Label();
            this.txtFilterModel = new System.Windows.Forms.TextBox();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnUpdateCar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            this.SuspendLayout();
            // 
            // panFields
            // 
            this.panFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panFields.Controls.Add(this.picFilter);
            this.panFields.Controls.Add(this.lblFilterModel);
            this.panFields.Controls.Add(this.txtFilterModel);
            this.panFields.Controls.Add(this.dgvCars);
            this.panFields.Controls.Add(this.btnDeleteCar);
            this.panFields.Controls.Add(this.txtID);
            this.panFields.Controls.Add(this.lblID);
            this.panFields.Controls.Add(this.btnClearAll);
            this.panFields.Controls.Add(this.btnUpdateCar);
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
            this.panFields.Location = new System.Drawing.Point(201, 12);
            this.panFields.Name = "panFields";
            this.panFields.Size = new System.Drawing.Size(863, 626);
            this.panFields.TabIndex = 1;
            // 
            // picFilter
            // 
            this.picFilter.Image = global::System.CPC.App.Properties.Resources.search;
            this.picFilter.Location = new System.Drawing.Point(427, 354);
            this.picFilter.Name = "picFilter";
            this.picFilter.Size = new System.Drawing.Size(36, 31);
            this.picFilter.TabIndex = 30;
            this.picFilter.TabStop = false;
            // 
            // lblFilterModel
            // 
            this.lblFilterModel.AutoSize = true;
            this.lblFilterModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterModel.Location = new System.Drawing.Point(58, 344);
            this.lblFilterModel.Name = "lblFilterModel";
            this.lblFilterModel.Size = new System.Drawing.Size(103, 16);
            this.lblFilterModel.TabIndex = 29;
            this.lblFilterModel.Text = "Filter By Model :";
            this.toolTip.SetToolTip(this.lblFilterModel, "Type model to filter results");
            // 
            // txtFilterModel
            // 
            this.txtFilterModel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFilterModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterModel.Location = new System.Drawing.Point(59, 363);
            this.txtFilterModel.MaxLength = 30;
            this.txtFilterModel.Name = "txtFilterModel";
            this.txtFilterModel.Size = new System.Drawing.Size(362, 22);
            this.txtFilterModel.TabIndex = 28;
            this.txtFilterModel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilterModel_KeyUp);
            // 
            // dgvCars
            // 
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Location = new System.Drawing.Point(63, 396);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.Size = new System.Drawing.Size(739, 175);
            this.dgvCars.TabIndex = 27;
            this.dgvCars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCars_CellClick);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.BackColor = System.Drawing.Color.MistyRose;
            this.btnDeleteCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCar.Enabled = false;
            this.btnDeleteCar.Location = new System.Drawing.Point(560, 297);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(129, 23);
            this.btnDeleteCar.TabIndex = 26;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = false;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(61, 26);
            this.txtID.MaxLength = 4;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(90, 22);
            this.txtID.TabIndex = 25;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(58, 7);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 16);
            this.lblID.TabIndex = 24;
            this.lblID.Text = "ID :";
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAll.Location = new System.Drawing.Point(190, 297);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(129, 23);
            this.btnClearAll.TabIndex = 23;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdateCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCar.Enabled = false;
            this.btnUpdateCar.Location = new System.Drawing.Point(373, 297);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(129, 23);
            this.btnUpdateCar.TabIndex = 22;
            this.btnUpdateCar.Text = "Update Car";
            this.btnUpdateCar.UseVisualStyleBackColor = false;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(61, 242);
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
            this.lblPrice.Location = new System.Drawing.Point(58, 223);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(45, 16);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price :";
            // 
            // txtMaxSpeed
            // 
            this.txtMaxSpeed.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMaxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxSpeed.Location = new System.Drawing.Point(594, 183);
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
            this.lblMaxSpeed.Location = new System.Drawing.Point(591, 164);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(83, 16);
            this.lblMaxSpeed.TabIndex = 14;
            this.lblMaxSpeed.Text = "Max Speed :";
            // 
            // txtTorque
            // 
            this.txtTorque.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTorque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTorque.Location = new System.Drawing.Point(334, 183);
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
            this.lblTorque.Location = new System.Drawing.Point(331, 164);
            this.lblTorque.Name = "lblTorque";
            this.lblTorque.Size = new System.Drawing.Size(58, 16);
            this.lblTorque.TabIndex = 12;
            this.lblTorque.Text = "Torque :";
            // 
            // txtPower
            // 
            this.txtPower.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPower.Location = new System.Drawing.Point(61, 183);
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
            this.lblPower.Location = new System.Drawing.Point(58, 164);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(52, 16);
            this.lblPower.TabIndex = 10;
            this.lblPower.Text = "Power :";
            // 
            // txtEngine
            // 
            this.txtEngine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEngine.Location = new System.Drawing.Point(594, 128);
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
            this.lblEngine.Location = new System.Drawing.Point(591, 109);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(85, 16);
            this.lblEngine.TabIndex = 8;
            this.lblEngine.Text = "Engine Size :";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(343, 128);
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
            this.lblYear.Location = new System.Drawing.Point(340, 109);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(43, 16);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Year :";
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(61, 128);
            this.txtCountry.MaxLength = 20;
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(245, 22);
            this.txtCountry.TabIndex = 5;
            // 
            // lblContry
            // 
            this.lblContry.AutoSize = true;
            this.lblContry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContry.Location = new System.Drawing.Point(58, 109);
            this.lblContry.Name = "lblContry";
            this.lblContry.Size = new System.Drawing.Size(59, 16);
            this.lblContry.TabIndex = 4;
            this.lblContry.Text = "Country :";
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(440, 79);
            this.txtModel.MaxLength = 30;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(362, 22);
            this.txtModel.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(437, 60);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 16);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model :";
            // 
            // txtMaker
            // 
            this.txtMaker.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaker.Location = new System.Drawing.Point(61, 79);
            this.txtMaker.MaxLength = 30;
            this.txtMaker.Name = "txtMaker";
            this.txtMaker.Size = new System.Drawing.Size(362, 22);
            this.txtMaker.TabIndex = 1;
            // 
            // lblMaker
            // 
            this.lblMaker.AutoSize = true;
            this.lblMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaker.Location = new System.Drawing.Point(58, 60);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(52, 16);
            this.lblMaker.TabIndex = 0;
            this.lblMaker.Text = "Maker :";
            // 
            // FrmCarsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1264, 651);
            this.Controls.Add(this.panFields);
            this.Name = "FrmCarsSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Car";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCarsSearch_Load);
            this.panFields.ResumeLayout(false);
            this.panFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.Panel panFields;
        private Windows.Forms.Button btnClearAll;
        private Windows.Forms.Button btnUpdateCar;
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
        private Windows.Forms.TextBox txtCountry;
        private Windows.Forms.Label lblContry;
        private Windows.Forms.TextBox txtModel;
        private Windows.Forms.Label lblModel;
        private Windows.Forms.TextBox txtMaker;
        private Windows.Forms.Label lblMaker;
        private Windows.Forms.TextBox txtID;
        private Windows.Forms.Label lblID;
        private Windows.Forms.Button btnDeleteCar;
        private Windows.Forms.ToolTip toolTip;
        private Windows.Forms.DataGridView dgvCars;
        private Windows.Forms.PictureBox picFilter;
        private Windows.Forms.Label lblFilterModel;
        private Windows.Forms.TextBox txtFilterModel;
    }
}