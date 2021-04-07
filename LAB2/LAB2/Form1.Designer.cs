//Grading ID: R8206
//Lab #: 2
//Due Date: Jan 2, 2020
//CIS 199 Section: 01
//Description: This program calculates 15,18 and 20 percent tips from a input dollar amount from the user.

namespace LAB2
{
    partial class TipCalculator
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
            this.TxtBoxPrice = new System.Windows.Forms.TextBox();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.TiprateLow = new System.Windows.Forms.Label();
            this.TiprateMedium = new System.Windows.Forms.Label();
            this.TiprateHigh = new System.Windows.Forms.Label();
            this.TiprateCalculationButton = new System.Windows.Forms.Button();
            this.TiprateLowOutput = new System.Windows.Forms.Label();
            this.TiprateMediumOutput = new System.Windows.Forms.Label();
            this.TiprateHighOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBoxPrice
            // 
            this.TxtBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBoxPrice.Location = new System.Drawing.Point(128, 22);
            this.TxtBoxPrice.Name = "TxtBoxPrice";
            this.TxtBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxPrice.TabIndex = 0;
            this.TxtBoxPrice.TextChanged += new System.EventHandler(this.TxtBoxPrice_TextChanged);
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(22, 25);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(98, 13);
            this.LabelPrice.TabIndex = 1;
            this.LabelPrice.Text = "Enter price of meal:";
            this.LabelPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // TiprateLow
            // 
            this.TiprateLow.AutoSize = true;
            this.TiprateLow.Location = new System.Drawing.Point(92, 68);
            this.TiprateLow.Name = "TiprateLow";
            this.TiprateLow.Size = new System.Drawing.Size(30, 13);
            this.TiprateLow.TabIndex = 2;
            this.TiprateLow.Text = "15 %";
            // 
            // TiprateMedium
            // 
            this.TiprateMedium.AutoSize = true;
            this.TiprateMedium.Location = new System.Drawing.Point(92, 114);
            this.TiprateMedium.Name = "TiprateMedium";
            this.TiprateMedium.Size = new System.Drawing.Size(30, 13);
            this.TiprateMedium.TabIndex = 6;
            this.TiprateMedium.Text = "18 %";
            // 
            // TiprateHigh
            // 
            this.TiprateHigh.AutoSize = true;
            this.TiprateHigh.Location = new System.Drawing.Point(92, 158);
            this.TiprateHigh.Name = "TiprateHigh";
            this.TiprateHigh.Size = new System.Drawing.Size(30, 13);
            this.TiprateHigh.TabIndex = 7;
            this.TiprateHigh.Text = "20 %";
            // 
            // TiprateCalculationButton
            // 
            this.TiprateCalculationButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TiprateCalculationButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TiprateCalculationButton.Location = new System.Drawing.Point(128, 195);
            this.TiprateCalculationButton.Name = "TiprateCalculationButton";
            this.TiprateCalculationButton.Size = new System.Drawing.Size(100, 23);
            this.TiprateCalculationButton.TabIndex = 8;
            this.TiprateCalculationButton.Text = "Calculate Tip";
            this.TiprateCalculationButton.UseVisualStyleBackColor = false;
            this.TiprateCalculationButton.Click += new System.EventHandler(this.TiprateCalculation_Click);
            this.TiprateCalculationButton.Enter += new System.EventHandler(this.buttonfortipcalculation_Click);
            // 
            // TiprateLowOutput
            // 
            this.TiprateLowOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TiprateLowOutput.Location = new System.Drawing.Point(128, 67);
            this.TiprateLowOutput.Name = "TiprateLowOutput";
            this.TiprateLowOutput.Size = new System.Drawing.Size(100, 20);
            this.TiprateLowOutput.TabIndex = 9;
            this.TiprateLowOutput.Click += new System.EventHandler(this.TiprateLowOutput_Click);
            // 
            // TiprateMediumOutput
            // 
            this.TiprateMediumOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TiprateMediumOutput.Location = new System.Drawing.Point(128, 113);
            this.TiprateMediumOutput.Name = "TiprateMediumOutput";
            this.TiprateMediumOutput.Size = new System.Drawing.Size(100, 20);
            this.TiprateMediumOutput.TabIndex = 10;
            this.TiprateMediumOutput.Click += new System.EventHandler(this.TiprateMediumOutput_Click);
            // 
            // TiprateHighOutput
            // 
            this.TiprateHighOutput.BackColor = System.Drawing.SystemColors.Menu;
            this.TiprateHighOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TiprateHighOutput.Location = new System.Drawing.Point(128, 157);
            this.TiprateHighOutput.Name = "TiprateHighOutput";
            this.TiprateHighOutput.Size = new System.Drawing.Size(100, 20);
            this.TiprateHighOutput.TabIndex = 11;
            this.TiprateHighOutput.Click += new System.EventHandler(this.TiprateHighOutput_Click);
            // 
            // TipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TiprateHighOutput);
            this.Controls.Add(this.TiprateMediumOutput);
            this.Controls.Add(this.TiprateLowOutput);
            this.Controls.Add(this.TiprateCalculationButton);
            this.Controls.Add(this.TiprateHigh);
            this.Controls.Add(this.TiprateMedium);
            this.Controls.Add(this.TiprateLow);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.TxtBoxPrice);
            this.Name = "TipCalculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.buttonfortipcalculation_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxPrice;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label TiprateLow;
        private System.Windows.Forms.Label TiprateMedium;
        private System.Windows.Forms.Label TiprateHigh;
        private System.Windows.Forms.Button TiprateCalculationButton;
        private System.Windows.Forms.Label TiprateLowOutput;
        private System.Windows.Forms.Label TiprateMediumOutput;
        private System.Windows.Forms.Label TiprateHighOutput;
    }
}

