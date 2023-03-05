namespace PaintClass
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.Label();
            this.txtPapel = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnPincel = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblTamanioPincel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cbLinea = new System.Windows.Forms.CheckBox();
            this.cbRectangulo = new System.Windows.Forms.CheckBox();
            this.cbCuadrado = new System.Windows.Forms.CheckBox();
            this.cbElipce = new System.Windows.Forms.CheckBox();
            this.cbEclipcell = new System.Windows.Forms.CheckBox();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.btnForma = new System.Windows.Forms.Button();
            this.lblCoordenadas = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPapel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(43, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(76, 11);
            this.trackBar1.Maximum = 40;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(161, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "R";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(40, 52);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(34, 23);
            this.txtR.TabIndex = 4;
            this.txtR.Text = "0";
            this.txtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(40, 93);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(34, 23);
            this.txtG.TabIndex = 6;
            this.txtG.Text = "0";
            this.txtG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "G";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(40, 138);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(34, 23);
            this.txtB.TabIndex = 8;
            this.txtB.Text = "0";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(14, 139);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(14, 15);
            this.B.TabIndex = 7;
            this.B.Text = "B";
            // 
            // txtPapel
            // 
            this.txtPapel.BackColor = System.Drawing.Color.White;
            this.txtPapel.Location = new System.Drawing.Point(119, 55);
            this.txtPapel.Name = "txtPapel";
            this.txtPapel.Size = new System.Drawing.Size(975, 522);
            this.txtPapel.TabIndex = 9;
            this.txtPapel.TabStop = false;
            this.txtPapel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPapel_MouseClick);
            this.txtPapel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtPapel_MouseDown);
            this.txtPapel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtPapel_MouseMove);
            this.txtPapel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtPapel_MouseUp);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(17, 223);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(17, 267);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnPincel
            // 
            this.btnPincel.Location = new System.Drawing.Point(17, 310);
            this.btnPincel.Name = "btnPincel";
            this.btnPincel.Size = new System.Drawing.Size(75, 23);
            this.btnPincel.TabIndex = 12;
            this.btnPincel.Text = "Pincel";
            this.btnPincel.UseVisualStyleBackColor = true;
            this.btnPincel.Click += new System.EventHandler(this.btnPincel_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(17, 350);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblTamanioPincel
            // 
            this.lblTamanioPincel.AutoSize = true;
            this.lblTamanioPincel.Location = new System.Drawing.Point(246, 22);
            this.lblTamanioPincel.Name = "lblTamanioPincel";
            this.lblTamanioPincel.Size = new System.Drawing.Size(13, 15);
            this.lblTamanioPincel.TabIndex = 14;
            this.lblTamanioPincel.Text = "3";
            // 
            // cbLinea
            // 
            this.cbLinea.AutoSize = true;
            this.cbLinea.Location = new System.Drawing.Point(17, 388);
            this.cbLinea.Name = "cbLinea";
            this.cbLinea.Size = new System.Drawing.Size(54, 19);
            this.cbLinea.TabIndex = 15;
            this.cbLinea.Text = "Linea";
            this.cbLinea.UseVisualStyleBackColor = true;
            // 
            // cbRectangulo
            // 
            this.cbRectangulo.AutoSize = true;
            this.cbRectangulo.Location = new System.Drawing.Point(17, 413);
            this.cbRectangulo.Name = "cbRectangulo";
            this.cbRectangulo.Size = new System.Drawing.Size(86, 19);
            this.cbRectangulo.TabIndex = 16;
            this.cbRectangulo.Text = "Rectangulo";
            this.cbRectangulo.UseVisualStyleBackColor = true;
            // 
            // cbCuadrado
            // 
            this.cbCuadrado.AutoSize = true;
            this.cbCuadrado.Location = new System.Drawing.Point(17, 438);
            this.cbCuadrado.Name = "cbCuadrado";
            this.cbCuadrado.Size = new System.Drawing.Size(78, 19);
            this.cbCuadrado.TabIndex = 17;
            this.cbCuadrado.Text = "Cuadrado";
            this.cbCuadrado.UseVisualStyleBackColor = true;
            // 
            // cbElipce
            // 
            this.cbElipce.AutoSize = true;
            this.cbElipce.Location = new System.Drawing.Point(17, 463);
            this.cbElipce.Name = "cbElipce";
            this.cbElipce.Size = new System.Drawing.Size(57, 19);
            this.cbElipce.TabIndex = 18;
            this.cbElipce.Text = "Elipce";
            this.cbElipce.UseVisualStyleBackColor = true;
            // 
            // cbEclipcell
            // 
            this.cbEclipcell.AutoSize = true;
            this.cbEclipcell.Location = new System.Drawing.Point(17, 488);
            this.cbEclipcell.Name = "cbEclipcell";
            this.cbEclipcell.Size = new System.Drawing.Size(86, 19);
            this.cbEclipcell.TabIndex = 19;
            this.cbEclipcell.Text = "Elipce lleno";
            this.cbEclipcell.UseVisualStyleBackColor = true;
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(17, 513);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(71, 19);
            this.cbRandom.TabIndex = 20;
            this.cbRandom.Text = "Random";
            this.cbRandom.UseVisualStyleBackColor = true;
            // 
            // btnForma
            // 
            this.btnForma.Location = new System.Drawing.Point(7, 538);
            this.btnForma.Name = "btnForma";
            this.btnForma.Size = new System.Drawing.Size(96, 23);
            this.btnForma.TabIndex = 21;
            this.btnForma.Text = "Agregar Figura";
            this.btnForma.UseVisualStyleBackColor = true;
            this.btnForma.Click += new System.EventHandler(this.btnForma_Click);
            // 
            // lblCoordenadas
            // 
            this.lblCoordenadas.AutoSize = true;
            this.lblCoordenadas.Location = new System.Drawing.Point(848, 28);
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(77, 15);
            this.lblCoordenadas.TabIndex = 22;
            this.lblCoordenadas.Text = "Coordenadas";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(7, 178);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(96, 27);
            this.btnColor.TabIndex = 23;
            this.btnColor.Text = "Cambiar color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 589);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblCoordenadas);
            this.Controls.Add(this.btnForma);
            this.Controls.Add(this.cbRandom);
            this.Controls.Add(this.cbEclipcell);
            this.Controls.Add(this.cbElipce);
            this.Controls.Add(this.cbCuadrado);
            this.Controls.Add(this.cbRectangulo);
            this.Controls.Add(this.cbLinea);
            this.Controls.Add(this.lblTamanioPincel);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnPincel);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPapel);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.B);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPapel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TrackBar trackBar1;
        private Label label1;
        private TextBox txtR;
        private TextBox txtG;
        private Label label2;
        private TextBox txtB;
        private Label B;
        private PictureBox txtPapel;
        private Button btnGuardar;
        private Button btnAgregar;
        private Button btnPincel;
        private Button btnBorrar;
        private Label lblTamanioPincel;
        private ColorDialog colorDialog1;
        private SaveFileDialog saveFileDialog1;
        private CheckBox cbLinea;
        private CheckBox cbRectangulo;
        private CheckBox cbCuadrado;
        private CheckBox cbElipce;
        private CheckBox cbEclipcell;
        private CheckBox cbRandom;
        private Button btnForma;
        private Label lblCoordenadas;
        private Button btnColor;
    }
}