namespace ProyectoIván
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_HL = new System.Windows.Forms.TrackBar();
            this.trackBar_SL = new System.Windows.Forms.TrackBar();
            this.trackBar_VL = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numeric_HL = new System.Windows.Forms.NumericUpDown();
            this.numeric_SL = new System.Windows.Forms.NumericUpDown();
            this.numeric_VL = new System.Windows.Forms.NumericUpDown();
            this.numeric_VH = new System.Windows.Forms.NumericUpDown();
            this.numeric_SH = new System.Windows.Forms.NumericUpDown();
            this.numeric_HH = new System.Windows.Forms.NumericUpDown();
            this.trackBar_VH = new System.Windows.Forms.TrackBar();
            this.trackBar_SH = new System.Windows.Forms.TrackBar();
            this.trackBar_HH = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox_EH = new System.Windows.Forms.CheckBox();
            this.checkBox_ES = new System.Windows.Forms.CheckBox();
            this.checkBox_EV = new System.Windows.Forms.CheckBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_HL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_VL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_HL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_SL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_VL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_VH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_SH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_HH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_VH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_HH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.imageBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(877, 243);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // imageBox1
            // 
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.Location = new System.Drawing.Point(3, 3);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(432, 237);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox2.Location = new System.Drawing.Point(441, 3);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(433, 237);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            this.imageBox2.Click += new System.EventHandler(this.imageBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "HSV:";
            // 
            // trackBar_HL
            // 
            this.trackBar_HL.Location = new System.Drawing.Point(407, 305);
            this.trackBar_HL.Maximum = 255;
            this.trackBar_HL.Name = "trackBar_HL";
            this.trackBar_HL.RightToLeftLayout = true;
            this.trackBar_HL.Size = new System.Drawing.Size(199, 45);
            this.trackBar_HL.TabIndex = 3;
            this.trackBar_HL.ValueChanged += new System.EventHandler(this.trackbar_Low_ValueChanged);
            // 
            // trackBar_SL
            // 
            this.trackBar_SL.Location = new System.Drawing.Point(407, 345);
            this.trackBar_SL.Maximum = 255;
            this.trackBar_SL.Name = "trackBar_SL";
            this.trackBar_SL.Size = new System.Drawing.Size(199, 45);
            this.trackBar_SL.TabIndex = 4;
            this.trackBar_SL.ValueChanged += new System.EventHandler(this.trackbar_Low_ValueChanged);
            // 
            // trackBar_VL
            // 
            this.trackBar_VL.Location = new System.Drawing.Point(407, 386);
            this.trackBar_VL.Maximum = 255;
            this.trackBar_VL.Name = "trackBar_VL";
            this.trackBar_VL.Size = new System.Drawing.Size(199, 45);
            this.trackBar_VL.TabIndex = 5;
            this.trackBar_VL.ValueChanged += new System.EventHandler(this.trackbar_Low_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "H:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "S:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "V:";
            // 
            // numeric_HL
            // 
            this.numeric_HL.Location = new System.Drawing.Point(612, 315);
            this.numeric_HL.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_HL.Name = "numeric_HL";
            this.numeric_HL.Size = new System.Drawing.Size(45, 20);
            this.numeric_HL.TabIndex = 9;
            this.numeric_HL.ValueChanged += new System.EventHandler(this.numeric_Low_ValueChanged);
            // 
            // numeric_SL
            // 
            this.numeric_SL.Location = new System.Drawing.Point(612, 354);
            this.numeric_SL.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_SL.Name = "numeric_SL";
            this.numeric_SL.Size = new System.Drawing.Size(45, 20);
            this.numeric_SL.TabIndex = 10;
            this.numeric_SL.ValueChanged += new System.EventHandler(this.numeric_Low_ValueChanged);
            // 
            // numeric_VL
            // 
            this.numeric_VL.Location = new System.Drawing.Point(612, 396);
            this.numeric_VL.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_VL.Name = "numeric_VL";
            this.numeric_VL.Size = new System.Drawing.Size(45, 20);
            this.numeric_VL.TabIndex = 11;
            this.numeric_VL.ValueChanged += new System.EventHandler(this.numeric_Low_ValueChanged);
            // 
            // numeric_VH
            // 
            this.numeric_VH.Location = new System.Drawing.Point(663, 396);
            this.numeric_VH.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_VH.Name = "numeric_VH";
            this.numeric_VH.Size = new System.Drawing.Size(45, 20);
            this.numeric_VH.TabIndex = 14;
            this.numeric_VH.ValueChanged += new System.EventHandler(this.numeric_High_ValueChanged);
            // 
            // numeric_SH
            // 
            this.numeric_SH.Location = new System.Drawing.Point(663, 354);
            this.numeric_SH.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_SH.Name = "numeric_SH";
            this.numeric_SH.Size = new System.Drawing.Size(45, 20);
            this.numeric_SH.TabIndex = 13;
            this.numeric_SH.ValueChanged += new System.EventHandler(this.numeric_High_ValueChanged);
            // 
            // numeric_HH
            // 
            this.numeric_HH.Location = new System.Drawing.Point(663, 315);
            this.numeric_HH.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_HH.Name = "numeric_HH";
            this.numeric_HH.Size = new System.Drawing.Size(45, 20);
            this.numeric_HH.TabIndex = 12;
            this.numeric_HH.ValueChanged += new System.EventHandler(this.numeric_High_ValueChanged);
            // 
            // trackBar_VH
            // 
            this.trackBar_VH.Location = new System.Drawing.Point(714, 386);
            this.trackBar_VH.Maximum = 255;
            this.trackBar_VH.Name = "trackBar_VH";
            this.trackBar_VH.Size = new System.Drawing.Size(199, 45);
            this.trackBar_VH.TabIndex = 17;
            this.trackBar_VH.ValueChanged += new System.EventHandler(this.trackBar_High_ValueChanged);
            // 
            // trackBar_SH
            // 
            this.trackBar_SH.Location = new System.Drawing.Point(714, 345);
            this.trackBar_SH.Maximum = 255;
            this.trackBar_SH.Name = "trackBar_SH";
            this.trackBar_SH.Size = new System.Drawing.Size(199, 45);
            this.trackBar_SH.TabIndex = 16;
            this.trackBar_SH.ValueChanged += new System.EventHandler(this.trackBar_High_ValueChanged);
            // 
            // trackBar_HH
            // 
            this.trackBar_HH.Location = new System.Drawing.Point(714, 305);
            this.trackBar_HH.Maximum = 255;
            this.trackBar_HH.Name = "trackBar_HH";
            this.trackBar_HH.Size = new System.Drawing.Size(199, 45);
            this.trackBar_HH.TabIndex = 15;
            this.trackBar_HH.ValueChanged += new System.EventHandler(this.trackBar_High_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(793, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Max";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cargar Imagen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox_EH
            // 
            this.checkBox_EH.AutoSize = true;
            this.checkBox_EH.Location = new System.Drawing.Point(358, 305);
            this.checkBox_EH.Name = "checkBox_EH";
            this.checkBox_EH.Size = new System.Drawing.Size(15, 14);
            this.checkBox_EH.TabIndex = 22;
            this.checkBox_EH.UseVisualStyleBackColor = true;
            // 
            // checkBox_ES
            // 
            this.checkBox_ES.AutoSize = true;
            this.checkBox_ES.Location = new System.Drawing.Point(358, 345);
            this.checkBox_ES.Name = "checkBox_ES";
            this.checkBox_ES.Size = new System.Drawing.Size(15, 14);
            this.checkBox_ES.TabIndex = 23;
            this.checkBox_ES.UseVisualStyleBackColor = true;
            // 
            // checkBox_EV
            // 
            this.checkBox_EV.AutoSize = true;
            this.checkBox_EV.Location = new System.Drawing.Point(358, 386);
            this.checkBox_EV.Name = "checkBox_EV";
            this.checkBox_EV.Size = new System.Drawing.Size(15, 14);
            this.checkBox_EV.TabIndex = 24;
            this.checkBox_EV.UseVisualStyleBackColor = true;
            // 
            // imageBox3
            // 
            this.imageBox3.Location = new System.Drawing.Point(15, 261);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(329, 255);
            this.imageBox3.TabIndex = 2;
            this.imageBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 528);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.checkBox_EV);
            this.Controls.Add(this.checkBox_ES);
            this.Controls.Add(this.checkBox_EH);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar_VH);
            this.Controls.Add(this.trackBar_SH);
            this.Controls.Add(this.trackBar_HH);
            this.Controls.Add(this.numeric_VH);
            this.Controls.Add(this.numeric_SH);
            this.Controls.Add(this.numeric_HH);
            this.Controls.Add(this.numeric_VL);
            this.Controls.Add(this.numeric_SL);
            this.Controls.Add(this.numeric_HL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar_VL);
            this.Controls.Add(this.trackBar_SL);
            this.Controls.Add(this.trackBar_HL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_HL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_VL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_HL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_SL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_VL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_VH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_SH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_HH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_VH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_HH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_HL;
        private System.Windows.Forms.TrackBar trackBar_SL;
        private System.Windows.Forms.TrackBar trackBar_VL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numeric_HL;
        private System.Windows.Forms.NumericUpDown numeric_SL;
        private System.Windows.Forms.NumericUpDown numeric_VL;
        private System.Windows.Forms.NumericUpDown numeric_VH;
        private System.Windows.Forms.NumericUpDown numeric_SH;
        private System.Windows.Forms.NumericUpDown numeric_HH;
        private System.Windows.Forms.TrackBar trackBar_VH;
        private System.Windows.Forms.TrackBar trackBar_SH;
        private System.Windows.Forms.TrackBar trackBar_HH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.CheckBox checkBox_EH;
        private System.Windows.Forms.CheckBox checkBox_ES;
        private System.Windows.Forms.CheckBox checkBox_EV;
        private Emgu.CV.UI.ImageBox imageBox3;
    }
}

