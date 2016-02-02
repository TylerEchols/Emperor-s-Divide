namespace BudgeterSuite
{
    partial class NewEnvelope
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.payOutBox = new System.Windows.Forms.TextBox();
            this.balanceBox = new System.Windows.Forms.TextBox();
            this.newEnvButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Envelope Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pay Day Payout: $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Starting Balance: $";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(120, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(152, 20);
            this.nameBox.TabIndex = 3;
            // 
            // payOutBox
            // 
            this.payOutBox.Location = new System.Drawing.Point(120, 45);
            this.payOutBox.Name = "payOutBox";
            this.payOutBox.Size = new System.Drawing.Size(63, 20);
            this.payOutBox.TabIndex = 4;
            this.payOutBox.Text = "0.00";
            // 
            // balanceBox
            // 
            this.balanceBox.Location = new System.Drawing.Point(120, 76);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(63, 20);
            this.balanceBox.TabIndex = 5;
            this.balanceBox.Text = "0.00";
            // 
            // newEnvButton
            // 
            this.newEnvButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEnvButton.Location = new System.Drawing.Point(94, 113);
            this.newEnvButton.Name = "newEnvButton";
            this.newEnvButton.Size = new System.Drawing.Size(101, 69);
            this.newEnvButton.TabIndex = 6;
            this.newEnvButton.Text = "Make the Envelope";
            this.newEnvButton.UseVisualStyleBackColor = true;
            this.newEnvButton.Click += new System.EventHandler(this.newEnvButton_Click);
            // 
            // NewEnvelope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.Controls.Add(this.newEnvButton);
            this.Controls.Add(this.balanceBox);
            this.Controls.Add(this.payOutBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewEnvelope";
            this.Text = "NewEnvelope";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox payOutBox;
        private System.Windows.Forms.TextBox balanceBox;
        private System.Windows.Forms.Button newEnvButton;
    }
}