namespace UnitConversion
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            modeOutput = new Label();
            valueOutput = new Label();
            modeInput = new TextBox();
            valueInput = new TextBox();
            conversionOutput = new Label();
            convertButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(134, 30);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 0;
            label1.Text = "Linear Conversion";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(163, 79);
            label2.Name = "label2";
            label2.Size = new Size(147, 18);
            label2.TabIndex = 1;
            label2.Text = "1. Inches to Centimetres";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(163, 106);
            label3.Name = "label3";
            label3.Size = new Size(147, 18);
            label3.TabIndex = 2;
            label3.Text = "2. Feet to Centimetres";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(163, 133);
            label4.Name = "label4";
            label4.Size = new Size(147, 18);
            label4.TabIndex = 3;
            label4.Text = "3. Yard to Metres";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(163, 159);
            label5.Name = "label5";
            label5.Size = new Size(147, 18);
            label5.TabIndex = 4;
            label5.Text = "4. Miles to Kilometres";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modeOutput
            // 
            modeOutput.BackColor = Color.Transparent;
            modeOutput.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modeOutput.ForeColor = Color.Black;
            modeOutput.Location = new Point(83, 215);
            modeOutput.Name = "modeOutput";
            modeOutput.Size = new Size(193, 18);
            modeOutput.TabIndex = 5;
            modeOutput.Text = "Enter conversion choice (1-4):";
            modeOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // valueOutput
            // 
            valueOutput.BackColor = Color.Transparent;
            valueOutput.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            valueOutput.ForeColor = Color.Black;
            valueOutput.Location = new Point(83, 254);
            valueOutput.Name = "valueOutput";
            valueOutput.Size = new Size(193, 18);
            valueOutput.TabIndex = 6;
            valueOutput.Text = "Enter value to be converted:";
            valueOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // modeInput
            // 
            modeInput.Location = new Point(282, 215);
            modeInput.Name = "modeInput";
            modeInput.Size = new Size(100, 23);
            modeInput.TabIndex = 7;
            // 
            // valueInput
            // 
            valueInput.Location = new Point(282, 254);
            valueInput.Name = "valueInput";
            valueInput.Size = new Size(100, 23);
            valueInput.TabIndex = 8;
            // 
            // conversionOutput
            // 
            conversionOutput.BackColor = Color.Transparent;
            conversionOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            conversionOutput.ForeColor = Color.Black;
            conversionOutput.Location = new Point(83, 329);
            conversionOutput.Name = "conversionOutput";
            conversionOutput.Size = new Size(299, 25);
            conversionOutput.TabIndex = 9;
            conversionOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(134, 292);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(205, 23);
            convertButton.TabIndex = 10;
            convertButton.Text = "Convert";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 380);
            Controls.Add(convertButton);
            Controls.Add(conversionOutput);
            Controls.Add(valueInput);
            Controls.Add(modeInput);
            Controls.Add(valueOutput);
            Controls.Add(modeOutput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Unit Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label modeOutput;
        private Label valueOutput;
        private TextBox modeInput;
        private TextBox valueInput;
        private Label conversionOutput;
        private Button convertButton;
    }
}
