namespace projectCafe
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
            this.lblCafe = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxTel = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBxTake = new System.Windows.Forms.PictureBox();
            this.picBxDine = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBxTake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCafe
            // 
            this.lblCafe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCafe.AutoSize = true;
            this.lblCafe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCafe.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCafe.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblCafe.Location = new System.Drawing.Point(291, 97);
            this.lblCafe.Name = "lblCafe";
            this.lblCafe.Size = new System.Drawing.Size(367, 57);
            this.lblCafe.TabIndex = 0;
            this.lblCafe.Text = "Brot && Bohne Cafe";
            this.lblCafe.Click += new System.EventHandler(this.lblCafe_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(289, 192);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 46);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblTel
            // 
            this.lblTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(289, 240);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(147, 46);
            this.lblTel.TabIndex = 3;
            this.lblTel.Text = "Phone:";
            this.lblTel.Click += new System.EventHandler(this.lblTel_Click);
            // 
            // txtBxName
            // 
            this.txtBxName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxName.Location = new System.Drawing.Point(442, 204);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(200, 22);
            this.txtBxName.TabIndex = 4;
            // 
            // txtBxTel
            // 
            this.txtBxTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBxTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxTel.Location = new System.Drawing.Point(442, 252);
            this.txtBxTel.Name = "txtBxTel";
            this.txtBxTel.Size = new System.Drawing.Size(216, 22);
            this.txtBxTel.TabIndex = 5;
            this.txtBxTel.TextChanged += new System.EventHandler(this.txtBxTel_TextChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(385, 588);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(240, 38);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 31);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dine In";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 54);
            this.label2.TabIndex = 16;
            this.label2.Text = "Take Away";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // picBxTake
            // 
            this.picBxTake.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBxTake.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBxTake.Image = global::projectCafe.Properties.Resources.take;
            this.picBxTake.Location = new System.Drawing.Point(561, 320);
            this.picBxTake.Name = "picBxTake";
            this.picBxTake.Size = new System.Drawing.Size(250, 175);
            this.picBxTake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxTake.TabIndex = 14;
            this.picBxTake.TabStop = false;
            // 
            // picBxDine
            // 
            this.picBxDine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBxDine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBxDine.Image = global::projectCafe.Properties.Resources.dine;
            this.picBxDine.Location = new System.Drawing.Point(195, 320);
            this.picBxDine.Name = "picBxDine";
            this.picBxDine.Size = new System.Drawing.Size(250, 175);
            this.picBxDine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxDine.TabIndex = 13;
            this.picBxDine.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCafe);
            this.Controls.Add(this.picBxTake);
            this.Controls.Add(this.picBxDine);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtBxTel);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.picBxTake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCafe;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxTel;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBxDine;
        private System.Windows.Forms.PictureBox picBxTake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

