namespace Reyes_BSIT3B
{
    partial class QeueingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCashier = new Button();
            lblQeue = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCashier.Location = new Point(30, 30);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(138, 108);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQeue
            // 
            lblQeue.AutoSize = true;
            lblQeue.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblQeue.Location = new Point(210, 83);
            lblQeue.Name = "lblQeue";
            lblQeue.Size = new Size(146, 55);
            lblQeue.TabIndex = 1;
            lblQeue.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(228, 43);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 2;
            label1.Text = "Position in Qeue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(30, 150);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 3;
            label2.Text = "*Click to get a number";
            // 
            // QeueingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 205);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblQeue);
            Controls.Add(btnCashier);
            Name = "QeueingForm";
            Text = "QueuingForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label lblQeue;
        private Label label1;
        private Label label2;
    }
}