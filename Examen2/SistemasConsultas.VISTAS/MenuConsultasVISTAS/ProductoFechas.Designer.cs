namespace SistemasConsultas.VISTAS.MenuConsultasVISTAS
{
    partial class ProductoFechas
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 20);
            label1.Name = "label1";
            label1.Size = new Size(213, 20);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTOS DE LA EMPRESAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 57);
            label2.Name = "label2";
            label2.Size = new Size(267, 20);
            label2.TabIndex = 1;
            label2.Text = "PRODUCTOS QUE ESTAN POR EXPIRAR";
            // 
            // button1
            // 
            button1.Location = new Point(26, 129);
            button1.Name = "button1";
            button1.Size = new Size(123, 54);
            button1.TabIndex = 2;
            button1.Text = "VEGETALES";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(180, 129);
            button2.Name = "button2";
            button2.Size = new Size(118, 54);
            button2.TabIndex = 3;
            button2.Text = "FRUTAS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(463, 129);
            button3.Name = "button3";
            button3.Size = new Size(117, 54);
            button3.TabIndex = 4;
            button3.Text = "CARNES";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(329, 129);
            button4.Name = "button4";
            button4.Size = new Size(114, 54);
            button4.TabIndex = 5;
            button4.Text = "BEBIDAS";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(604, 129);
            button5.Name = "button5";
            button5.Size = new Size(133, 54);
            button5.TabIndex = 6;
            button5.Text = "LACTEOS";
            button5.UseVisualStyleBackColor = true;
            // 
            // ProductoFechas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductoFechas";
            Text = "ProductoFechas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}