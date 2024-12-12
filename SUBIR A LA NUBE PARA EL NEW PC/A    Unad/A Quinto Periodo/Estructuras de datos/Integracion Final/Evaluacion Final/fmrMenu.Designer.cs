namespace Evaluacion_Final
{
    partial class fmrMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrMenu));
            btn1 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            btn3 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(55, 225);
            btn1.Margin = new Padding(3, 4, 3, 4);
            btn1.Name = "btn1";
            btn1.Size = new Size(261, 55);
            btn1.TabIndex = 0;
            btn1.Text = "App Notas musicales ";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(512, 225);
            btn2.Margin = new Padding(3, 4, 3, 4);
            btn2.Name = "btn2";
            btn2.Size = new Size(303, 55);
            btn2.TabIndex = 1;
            btn2.Text = "App EPS Salvando Vidas";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(512, 374);
            btn5.Margin = new Padding(3, 4, 3, 4);
            btn5.Name = "btn5";
            btn5.Size = new Size(303, 55);
            btn5.TabIndex = 2;
            btn5.Text = "Salir";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click_1;
            // 
            // btn3
            // 
            btn3.Font = new Font("Sitka Display", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(55, 374);
            btn3.Margin = new Padding(3, 4, 3, 4);
            btn3.Name = "btn3";
            btn3.Size = new Size(261, 55);
            btn3.TabIndex = 3;
            btn3.Text = "App Crear Árbol Binario";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(344, 22);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(104, 198);
            label3.Name = "label3";
            label3.Size = new Size(166, 23);
            label3.TabIndex = 5;
            label3.Text = "Click abajo para ver ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(589, 198);
            label1.Name = "label1";
            label1.Size = new Size(166, 23);
            label1.TabIndex = 6;
            label1.Text = "Click abajo para ver ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(104, 347);
            label2.Name = "label2";
            label2.Size = new Size(166, 23);
            label2.TabIndex = 7;
            label2.Text = "Click abajo para ver ";
            // 
            // fmrMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(868, 559);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btn3);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fmrMenu";
            Text = "Menú Opciones";
            Load += fmrMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn5;
        private Button btn3;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label1;
        private Label label2;
    }
}