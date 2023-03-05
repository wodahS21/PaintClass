using System.Net.Mail;
using System.Windows.Forms;

namespace PaintClass
{
    public partial class Form1 : Form
    {

        private Point mouseDownLocation;
        Graphics papel;
        int x = 0;
        int y = 0;
        int R = 0;
        int G = 0;
        int b = 0;
        int m1x;
        int m1y;
        int tamanioPincel = 3;
        int width;
        int height;
        int m2x;
        int m2y;
        bool moviendo = false;
        Pen pen;
        bool pintar = false;
        bool borrar = false;

        public Form1()
        {
       
            InitializeComponent();
            
            txtPapel.Image = new Bitmap(txtPapel.Height, txtPapel.Width);
            papel = txtPapel.CreateGraphics();
            papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            tamanioPincel = trackBar1.Value;
            R = int.Parse(txtR.Text);
            G = int.Parse(txtG.Text);
            b = int.Parse(txtB.Text);
            pen = new Pen(Color.FromArgb(R, G, b), tamanioPincel);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            lblTamanioPincel.Text = trackBar1.Value.ToString();
        }

        private void txtPapel_MouseDown(object sender, MouseEventArgs e)
        {
            m1x = e.X; m1y = e.Y;
            moviendo = true;
            x = e.X;
            y = e.Y;
            txtPapel.Cursor = Cursors.Cross;

        }

        private void txtPapel_MouseMove(object sender, MouseEventArgs e)
        {
 
            if (moviendo && pintar )
            {
                cambiarValorPluma(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
            if (moviendo && borrar)
            {
                cambiarValorPluma(255, 255, 255);
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
            


        }
        private void txtPapel_MouseUp(object sender, MouseEventArgs e)
        {
            m2x = e.X; m2y = e.Y;
            moviendo = false;
            if (cbCuadrado.Checked! || cbEclipcell.Checked! || cbElipce.Checked! || cbLinea.Checked! || cbRandom.Checked! || cbRectangulo.Checked!)
            {
                
                forma();
            }
            }

        public void forma()
        {
            int cx = m1x;
            int cy = m1y;
            width = Math.Abs(m2x - m1x);
            height = Math.Abs(m2y - m1y);
            ColorDialog p = new ColorDialog();
            p.Color = pictureBox2.BackColor;
            Pen pl = new Pen(p.Color);
            SolidBrush brocha = new SolidBrush(p.Color);



            if (cbLinea.Checked)
            {

                using (Graphics papel = txtPapel.CreateGraphics())
                {
                    
                    papel.DrawLine(pl, cx, cy, width, height);

                }




            }
            if (cbRectangulo.Checked)
            {

                using (Graphics papel = txtPapel.CreateGraphics())
                {
                   
                    papel.DrawRectangle(pl, x, y, width, height);
                }


            }
            if (cbCuadrado.Checked)
            {

                using (Graphics papel = txtPapel.CreateGraphics())
                {
               
                    papel.DrawRectangle(pl, x, y, width, height);
                }
            }
            if (cbElipce.Checked)
            {

                using (Graphics papel = txtPapel.CreateGraphics())
                {
                 
                    papel.DrawEllipse(pl, x, y, width, height);
                }
            }


            if (cbEclipcell.Checked)
            {


                using (Graphics papel = txtPapel.CreateGraphics())
                {
                  
                    papel.FillEllipse(brocha, x, y, width, height);
                }

            }
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "Archivos de imagen (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp";

            if (guardarArchivo.ShowDialog() == DialogResult.OK)
            {
                txtPapel.Image.Save(guardarArchivo.FileName);
            }
            /* SaveFileDialog Guardar = new SaveFileDialog();
             Guardar.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
             Image Imagen = txtPapel.BackgroundImage;
             Guardar.ShowDialog();
             txtPapel.Image.Save(saveFileDialog1.FileName);
            */
            //Imagen.Save(Guardar.FileName);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog getimage = new OpenFileDialog();
            DialogResult result = getimage.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtPapel.Image = Image.FromFile(getimage.FileName);
            
            }
            


        }



        private void cambiarValorPluma(int R, int G, int b)
        {
            pen = new Pen(Color.FromArgb(R, G, b), trackBar1.Value);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void btnPincel_Click(object sender, EventArgs e)
        {
            pintar = true;
            borrar = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pintar = false;
            borrar = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtR.Text = colorDialog1.Color.R.ToString();
                txtG.Text = colorDialog1.Color.G.ToString();
                txtB.Text = colorDialog1.Color.B.ToString();
                pictureBox2.BackColor = colorDialog1.Color;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtR.Text = 0.ToString();
            txtG.Text = 0.ToString();
            txtB.Text = 0.ToString();
        }

        private void btnForma_Click(object sender, EventArgs e)
        {
            ColorDialog p = new ColorDialog();
            p.Color = pictureBox2.BackColor;
            Graphics papel = txtPapel.CreateGraphics();
            Pen lapiz = new Pen(p.Color);
            SolidBrush brocha = new SolidBrush(p.Color);

            if (cbLinea.Checked)
            {
                if (cbRandom.Checked)
                {

                    Random x1 = new Random();
                    int x = x1.Next(280);
                    Random y1 = new Random();
                    int y = y1.Next(300);
                    papel.DrawLine(lapiz, x, y, 100, 10);
                    cbLinea.Checked = !cbLinea.Checked;
                }
                else
                {
                    papel.DrawLine(lapiz, 10, 10, 100, 10);
                    cbLinea.Checked = !cbLinea.Checked;
                }

            }
            if (cbRectangulo.Checked)
            {
                if (cbRandom.Checked)
                {
                    Random x1 = new Random();
                    int x = x1.Next(280);
                    Random y1 = new Random();
                    int y = y1.Next(300);
                    papel.DrawRectangle(lapiz, x, y, 100, 50);
                    cbRectangulo.Checked = !cbRectangulo.Checked;
                }
                else
                {
                    papel.DrawRectangle(lapiz, 110, 10, 100, 50);
                    cbRectangulo.Checked = !cbRectangulo.Checked;
                }

            }
            if (cbCuadrado.Checked)
            {
                if (cbRandom.Checked)
                {
                    Random x1 = new Random();
                    int x = x1.Next(280);
                    Random y1 = new Random();
                    int y = y1.Next(300);
                    papel.DrawRectangle(lapiz, x, y, 50, 50);
                    cbCuadrado.Checked = !cbCuadrado.Checked;
                }
                else
                {
                    papel.DrawRectangle(lapiz, 220, 10, 50, 50);
                    cbCuadrado.Checked = !cbCuadrado.Checked;
                }
            }
            if (cbElipce.Checked)
            {
                if (cbRandom.Checked)
                {
                    Random x1 = new Random();
                    int x = x1.Next(280);
                    Random y1 = new Random();
                    int y = y1.Next(300);
                    papel.DrawEllipse(lapiz, x, y, 100, 50);
                    cbElipce.Checked = !cbElipce.Checked;
                }
                else
                {
                    papel.DrawEllipse(lapiz, 280, 10, 100, 50);
                    cbElipce.Checked = !cbElipce.Checked;
                }

            }
            if (cbEclipcell.Checked)
            {
                if (cbRandom.Checked)
                {
                    Random r = new Random();
                    int n = r.Next(5);
                    Random x1 = new Random();
                    int x = x1.Next(280);
                    Random y1 = new Random();
                    int y = y1.Next(300);
                    papel.FillEllipse(brocha, x, y, 100, 50);
                    cbEclipcell.Checked = !cbEclipcell.Checked;
                }
                else
                {
                    papel.FillEllipse(brocha, 10, 70, 100, 50);
                    cbEclipcell.Checked = !cbEclipcell.Checked;
                }

            }
        }
       
        private void txtPapel_MouseClick(object sender, MouseEventArgs e)
        {
            this.lblCoordenadas.Text = String.Format("Coordenadas: {0},{1}", e.X, e.Y);

           /* ColorDialog p = new ColorDialog();
            p.Color = pictureBox2.BackColor;
            Pen pl = new Pen(p.Color);
            SolidBrush brocha = new SolidBrush(p.Color);
            int h = ancho - e.X;
            int an = e.Y;

            if (cbLinea.Checked)
            {

                papel.DrawLine(pl, x, y, h, an);
                cbLinea.Checked = !cbLinea.Checked;


            }
            if (cbRectangulo.Checked)
            {
                papel.DrawRectangle(pl, e.X, e.Y, 100, 50);
                cbRectangulo.Checked = !cbRectangulo.Checked;


            }
            if (cbCuadrado.Checked)
            {

                papel.DrawRectangle(pl, e.X, e.Y, 50, 50);
                cbCuadrado.Checked = !cbCuadrado.Checked;

            }
            if (cbElipce.Checked)
            {
                papel.DrawEllipse(pl, e.X, e.Y, 100, 50);
                cbElipce.Checked = !cbElipce.Checked;


            }
            if (cbEclipcell.Checked)
            {

                papel.FillEllipse(brocha, e.X, e.Y, 100, 50);
                cbEclipcell.Checked = !cbEclipcell.Checked;


            }*/

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int ro = int.Parse(txtR.Text);
            int ve = int.Parse(txtG.Text);
            int az = int.Parse(txtB.Text);
            Color colorDeFondo = Color.FromArgb(ro,ve,az);

            // Establecer el color de fondo del PictureBox
            pictureBox2.BackColor = colorDeFondo;
        }
    }
}


                    