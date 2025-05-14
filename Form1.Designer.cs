namespace _13_4_вариант
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
            textBoxT = new TextBox();
            textBoxX = new TextBox();
            btnCalculate = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // textBoxT
            // 
            textBoxT.Location = new Point(25, 36);
            textBoxT.Name = "textBoxT";
            textBoxT.Size = new Size(158, 23);
            textBoxT.TabIndex = 0;
            textBoxT.Text = "t";
            textBoxT.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(25, 75);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(158, 23);
            textBoxX.TabIndex = 1;
            textBoxX.Text = "x";
            textBoxX.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(25, 117);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(158, 29);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Вычислить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // labelResult
            // 
            labelResult.Location = new Point(25, 165);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(158, 42);
            labelResult.TabIndex = 3;
            labelResult.Text = "Ответ";
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 493);
            Controls.Add(labelResult);
            Controls.Add(btnCalculate);
            Controls.Add(textBoxX);
            Controls.Add(textBoxT);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxT;
        private TextBox textBoxX;
        private Button btnCalculate;
        private Label labelResult;
    }
}
