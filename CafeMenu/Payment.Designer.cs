namespace CafeMenu
{
    partial class Payment
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
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.radioButtonCard = new System.Windows.Forms.RadioButton();
            this.radioButtonQr = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.labelNamaCafe = new System.Windows.Forms.Label();
            this.groupBoxCard = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.labelExpiredDate = new System.Windows.Forms.Label();
            this.labelCVV = new System.Windows.Forms.Label();
            this.textBoxCardNum = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelCardNum = new System.Windows.Forms.Label();
            this.labelNameCardHolder = new System.Windows.Forms.Label();
            this.buttonConfirmPay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxQr = new System.Windows.Forms.PictureBox();
            this.groupBoxPayment.SuspendLayout();
            this.groupBoxCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQr)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.radioButtonCard);
            this.groupBoxPayment.Controls.Add(this.radioButtonQr);
            this.groupBoxPayment.Controls.Add(this.radioButtonCash);
            this.groupBoxPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPayment.ForeColor = System.Drawing.Color.Black;
            this.groupBoxPayment.Location = new System.Drawing.Point(163, 173);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(1146, 226);
            this.groupBoxPayment.TabIndex = 3;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Payment Method";
            // 
            // radioButtonCard
            // 
            this.radioButtonCard.AutoSize = true;
            this.radioButtonCard.Location = new System.Drawing.Point(31, 145);
            this.radioButtonCard.Name = "radioButtonCard";
            this.radioButtonCard.Size = new System.Drawing.Size(76, 29);
            this.radioButtonCard.TabIndex = 2;
            this.radioButtonCard.TabStop = true;
            this.radioButtonCard.Text = "Card";
            this.radioButtonCard.UseVisualStyleBackColor = true;
            this.radioButtonCard.CheckedChanged += new System.EventHandler(this.radioButtonCard_CheckedChanged_1);
            // 
            // radioButtonQr
            // 
            this.radioButtonQr.AutoSize = true;
            this.radioButtonQr.Location = new System.Drawing.Point(31, 90);
            this.radioButtonQr.Name = "radioButtonQr";
            this.radioButtonQr.Size = new System.Drawing.Size(101, 29);
            this.radioButtonQr.TabIndex = 1;
            this.radioButtonQr.TabStop = true;
            this.radioButtonQr.Text = "QR Pay";
            this.radioButtonQr.UseVisualStyleBackColor = true;
            this.radioButtonQr.CheckedChanged += new System.EventHandler(this.radioButtonQr_CheckedChanged_1);
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(31, 36);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(119, 29);
            this.radioButtonCash.TabIndex = 0;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Cash Pay";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            this.radioButtonCash.CheckedChanged += new System.EventHandler(this.radioButtonCash_CheckedChanged);
            // 
            // labelNamaCafe
            // 
            this.labelNamaCafe.AutoSize = true;
            this.labelNamaCafe.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaCafe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelNamaCafe.Location = new System.Drawing.Point(579, 64);
            this.labelNamaCafe.Name = "labelNamaCafe";
            this.labelNamaCafe.Size = new System.Drawing.Size(380, 49);
            this.labelNamaCafe.TabIndex = 4;
            this.labelNamaCafe.Text = "PAYMENT METHOD";
            // 
            // groupBoxCard
            // 
            this.groupBoxCard.Controls.Add(this.dateTimePicker1);
            this.groupBoxCard.Controls.Add(this.textBoxCVV);
            this.groupBoxCard.Controls.Add(this.labelExpiredDate);
            this.groupBoxCard.Controls.Add(this.labelCVV);
            this.groupBoxCard.Controls.Add(this.textBoxCardNum);
            this.groupBoxCard.Controls.Add(this.textBoxName);
            this.groupBoxCard.Controls.Add(this.labelCardNum);
            this.groupBoxCard.Controls.Add(this.labelNameCardHolder);
            this.groupBoxCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCard.Location = new System.Drawing.Point(192, 461);
            this.groupBoxCard.Name = "groupBoxCard";
            this.groupBoxCard.Size = new System.Drawing.Size(1057, 248);
            this.groupBoxCard.TabIndex = 11;
            this.groupBoxCard.TabStop = false;
            this.groupBoxCard.Text = "Card";
            this.groupBoxCard.Visible = false;
            this.groupBoxCard.Enter += new System.EventHandler(this.groupBoxCard_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(270, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Location = new System.Drawing.Point(270, 130);
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(195, 30);
            this.textBoxCVV.TabIndex = 11;
            // 
            // labelExpiredDate
            // 
            this.labelExpiredDate.AutoSize = true;
            this.labelExpiredDate.Location = new System.Drawing.Point(38, 172);
            this.labelExpiredDate.Name = "labelExpiredDate";
            this.labelExpiredDate.Size = new System.Drawing.Size(123, 25);
            this.labelExpiredDate.TabIndex = 10;
            this.labelExpiredDate.Text = "Expiry Date";
            // 
            // labelCVV
            // 
            this.labelCVV.AutoSize = true;
            this.labelCVV.Location = new System.Drawing.Point(38, 137);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Size = new System.Drawing.Size(58, 25);
            this.labelCVV.TabIndex = 9;
            this.labelCVV.Text = "CVV";
            // 
            // textBoxCardNum
            // 
            this.textBoxCardNum.Location = new System.Drawing.Point(270, 87);
            this.textBoxCardNum.Name = "textBoxCardNum";
            this.textBoxCardNum.Size = new System.Drawing.Size(538, 30);
            this.textBoxCardNum.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(270, 43);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(538, 30);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelCardNum
            // 
            this.labelCardNum.AutoSize = true;
            this.labelCardNum.Location = new System.Drawing.Point(38, 87);
            this.labelCardNum.Name = "labelCardNum";
            this.labelCardNum.Size = new System.Drawing.Size(140, 25);
            this.labelCardNum.TabIndex = 6;
            this.labelCardNum.Text = "Card Number";
            // 
            // labelNameCardHolder
            // 
            this.labelNameCardHolder.AutoSize = true;
            this.labelNameCardHolder.Location = new System.Drawing.Point(38, 43);
            this.labelNameCardHolder.Name = "labelNameCardHolder";
            this.labelNameCardHolder.Size = new System.Drawing.Size(190, 25);
            this.labelNameCardHolder.TabIndex = 5;
            this.labelNameCardHolder.Text = "Card Holder Name";
            // 
            // buttonConfirmPay
            // 
            this.buttonConfirmPay.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonConfirmPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmPay.Location = new System.Drawing.Point(644, 802);
            this.buttonConfirmPay.Name = "buttonConfirmPay";
            this.buttonConfirmPay.Size = new System.Drawing.Size(164, 56);
            this.buttonConfirmPay.TabIndex = 12;
            this.buttonConfirmPay.Text = "Confirm Payment";
            this.buttonConfirmPay.UseVisualStyleBackColor = false;
            this.buttonConfirmPay.Visible = false;
            this.buttonConfirmPay.Click += new System.EventHandler(this.buttonConfirmPay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(534, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(469, 45);
            this.label4.TabIndex = 16;
            this.label4.Text = "Please pay at the counter";
            // 
            // pictureBoxQr
            // 
            this.pictureBoxQr.Image = global::CafeMenu.Properties.Resources.Untitled_design;
            this.pictureBoxQr.Location = new System.Drawing.Point(588, 442);
            this.pictureBoxQr.Name = "pictureBoxQr";
            this.pictureBoxQr.Size = new System.Drawing.Size(334, 310);
            this.pictureBoxQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQr.TabIndex = 21;
            this.pictureBoxQr.TabStop = false;
            this.pictureBoxQr.Click += new System.EventHandler(this.pictureBoxQr_Click_1);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1487, 1055);
            this.Controls.Add(this.pictureBoxQr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonConfirmPay);
            this.Controls.Add(this.groupBoxCard);
            this.Controls.Add(this.labelNamaCafe);
            this.Controls.Add(this.groupBoxPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Method";
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.groupBoxCard.ResumeLayout(false);
            this.groupBoxCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.Label labelNamaCafe;
        private System.Windows.Forms.GroupBox groupBoxCard;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.Label labelExpiredDate;
        private System.Windows.Forms.Label labelCVV;
        private System.Windows.Forms.TextBox textBoxCardNum;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelCardNum;
        private System.Windows.Forms.Label labelNameCardHolder;
        private System.Windows.Forms.Button buttonConfirmPay;
        private System.Windows.Forms.RadioButton radioButtonCard;
        private System.Windows.Forms.RadioButton radioButtonQr;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBoxQr;
    }
}