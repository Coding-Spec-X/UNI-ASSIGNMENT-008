namespace ATM_Simulator
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
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.balanceLabelForBalance = new System.Windows.Forms.Label();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.atmLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(287, 238);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(119, 73);
            this.depositButton.TabIndex = 0;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(412, 238);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(113, 73);
            this.withdrawButton.TabIndex = 1;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(287, 317);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(238, 31);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // balanceLabelForBalance
            // 
            this.balanceLabelForBalance.AutoSize = true;
            this.balanceLabelForBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.balanceLabelForBalance.Location = new System.Drawing.Point(317, 142);
            this.balanceLabelForBalance.Name = "balanceLabelForBalance";
            this.balanceLabelForBalance.Size = new System.Drawing.Size(60, 16);
            this.balanceLabelForBalance.TabIndex = 3;
            this.balanceLabelForBalance.Text = "Balance:";
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(391, 189);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(100, 22);
            this.depositTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(323, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Deposit";
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(391, 139);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.ReadOnly = true;
            this.balanceTextBox.Size = new System.Drawing.Size(100, 22);
            this.balanceTextBox.TabIndex = 7;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(287, 354);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(238, 31);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // atmLabel
            // 
            this.atmLabel.AutoSize = true;
            this.atmLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.atmLabel.Font = new System.Drawing.Font("Microsoft Uighur", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atmLabel.Location = new System.Drawing.Point(264, 50);
            this.atmLabel.Name = "atmLabel";
            this.atmLabel.Size = new System.Drawing.Size(249, 56);
            this.atmLabel.TabIndex = 9;
            this.atmLabel.Text = "ATM Simulator";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.atmLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.depositTextBox);
            this.Controls.Add(this.balanceLabelForBalance);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label balanceLabelForBalance;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label atmLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

