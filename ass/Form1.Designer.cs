﻿namespace ass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.option3Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option1Button = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.Label();
            this.option3 = new System.Windows.Forms.Label();
            this.option2 = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // option3Button
            // 
            this.option3Button.Location = new System.Drawing.Point(70, 645);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(75, 23);
            this.option3Button.TabIndex = 16;
            this.option3Button.Text = ">";
            this.option3Button.UseVisualStyleBackColor = true;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.Location = new System.Drawing.Point(70, 598);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(75, 23);
            this.option2Button.TabIndex = 15;
            this.option2Button.Text = ">";
            this.option2Button.UseVisualStyleBackColor = true;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option1Button
            // 
            this.option1Button.Location = new System.Drawing.Point(70, 551);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(75, 23);
            this.option1Button.TabIndex = 14;
            this.option1Button.Text = ">";
            this.option1Button.UseVisualStyleBackColor = true;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(12, 9);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(984, 82);
            this.outputBox.TabIndex = 13;
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Location = new System.Drawing.Point(170, 650);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(0, 13);
            this.option3.TabIndex = 12;
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Location = new System.Drawing.Point(170, 603);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(0, 13);
            this.option2.TabIndex = 11;
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Location = new System.Drawing.Point(170, 556);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(0, 13);
            this.option1.TabIndex = 10;
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(12, 107);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(984, 410);
            this.imageBox.TabIndex = 9;
            this.imageBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1008, 749);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.imageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Haunted House";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Label outputBox;
        private System.Windows.Forms.Label option3;
        private System.Windows.Forms.Label option2;
        private System.Windows.Forms.Label option1;
        private System.Windows.Forms.PictureBox imageBox;
    }
}

