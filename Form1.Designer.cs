namespace winFormsWheelSpin
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
            pictureBox1=new PictureBox();
            label1=new Label();
            button1=new Button();
            pictureBox2=new PictureBox();
            label2=new Label();
            label3=new Label();
            pictureBox3=new PictureBox();
            label4=new Label();
            numericUpDown1=new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image=Properties.Resources.Spin_the_Wheel_Logo;
            pictureBox1.Location=new Point(621, 51);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(167, 159);
            pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex=0;
            pictureBox1.TabStop=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(632, 238);
            label1.Name="label1";
            label1.Size=new Size(146, 15);
            label1.TabIndex=1;
            label1.Text="Choose the Winning value";
            // 
            // button1
            // 
            button1.BackColor=Color.Gray;
            button1.Location=new Point(651, 315);
            button1.Name="button1";
            button1.Size=new Size(108, 57);
            button1.TabIndex=2;
            button1.Text="Spin To Win";
            button1.UseVisualStyleBackColor=false;
            button1.Click+=button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image=Properties.Resources.Wheel_Test5;
            pictureBox2.Location=new Point(33, 51);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(366, 367);
            pictureBox2.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex=3;
            pictureBox2.TabStop=false;
            
            // label2
            // 
            label2.AutoSize=true;
            label2.ForeColor=Color.Teal;
            label2.Location=new Point(708, 393);
            label2.Name="label2";
            label2.Size=new Size(38, 15);
            label2.TabIndex=4;
            label2.Text="label2";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.ForeColor=Color.Black;
            label3.Location=new Point(600, 389);
            label3.Name="label3";
            label3.Size=new Size(28, 15);
            label3.TabIndex=5;
            label3.Text="Win";
            // 
            // pictureBox3
            // 
            pictureBox3.Image=Properties.Resources.arrow;
            pictureBox3.Location=new Point(246, 12);
            pictureBox3.Name="pictureBox3";
            pictureBox3.Size=new Size(40, 42);
            pictureBox3.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex=6;
            pictureBox3.TabStop=false;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.ForeColor=Color.Chartreuse;
            label4.Location=new Point(425, 389);
            label4.Name="label4";
            label4.Size=new Size(169, 15);
            label4.TabIndex=7;
            label4.Text="Congtratulations yu have won ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment=new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Location=new Point(639, 272);
            numericUpDown1.Maximum=new decimal(new int[] { 200000, 0, 0, 0 });
            numericUpDown1.Name="numericUpDown1";
            numericUpDown1.Size=new Size(120, 23);
            numericUpDown1.TabIndex=9;
            numericUpDown1.Value=new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.ValueChanged+=numericUpDown1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.White;
            ClientSize=new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor=Color.Gold;
            Name="Form1";
            Text="Form1";
            Load+=Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label4;
        private NumericUpDown numericUpDown1;
    }
}