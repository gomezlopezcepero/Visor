using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using Visor2;


namespace PracticaVisor
{
    public partial class Form1 : Form
    {
        int num = 0;
        int fila = 0;
        int casillas = 7;
        int numFotos = 0;

        int posX = 0;
        int posY = 0;
        int posX2 = 0;
        int posY2 = 0;

        Boolean fal = false;
        Boolean arrastrando = false;

        ArrayList myAL = new ArrayList();
        String[] arrayNombres = new string[500];

        Visor v = new Visor(616, 379);

        

        public Form1()
        {
            InitializeComponent();

            imagenPrinci.AllowDrop = true;

        }


        //ABRIR IMAGENES

        private void abrirImagenes_Click(object sender, EventArgs e)
        {
            abrirFotos();
        }


        //BARRA DE HERRAMIENTAS

        private void rotarHorario_Click(object sender, EventArgs e)
        {
            if (v.Num_Fotos() != 0)
            {
                imagenPrinci.Image = v.rotar_hor();
            }
        }

        private void rotarsentidoantihorario_Click(object sender, EventArgs e)
        {
            if (v.Num_Fotos() != 0)
            {
                imagenPrinci.Image = v.rotar_antihor();
            }
        }

        private void aumentar_Click(object sender, EventArgs e)
        {
            if (v.Num_Fotos() != 0)
            {
                imagenPrinci.Image = v.Zoom(1.1f);

            }
        }

        private void disminuir_Click(object sender, EventArgs e)
        {
            if (v.Num_Fotos() != 0)
            {
                imagenPrinci.Image = v.Zoom(0.9f);
            }
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            irAnterior();
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            irSiguiente();

        }

        private void eliminarImagen_Click(object sender, EventArgs e)
        {
            limpiarImagen();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            limpiarTodas();
        }

        
        private void expandir_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }


        private void label1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            irAImagen();
        }


        //DESPLAZAR IMÁGENES


        private void imagenPrinci_MouseDown(object sender, MouseEventArgs e)
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            posX = Cursor.Position.X;
            posY = Cursor.Position.Y;

            arrastrando = true;
            Cursor = Cursors.SizeAll;
        }

        private void imagenPrinci_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (arrastrando)
                {
                    this.Cursor = new Cursor(Cursor.Current.Handle);
                    posX2 = Cursor.Position.X;
                    posY2 = Cursor.Position.Y;
                    
                    posY2 = (posY2 - posY) / 10;
                    posX2 = (posX2 - posX) / 10;

                    imagenPrinci.Image = v.Despl(posX2, posY2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void imagenPrinci_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrando = false;
            Cursor = Cursors.Cross;
        }

        private void toolStrip1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }



        //FUNCIONES DE TECLADO

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                irAnterior();
            }
            else if (e.KeyCode == Keys.Right)
            {

                irSiguiente();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
 

        }

       
        //CLICS EN LAS MINIATURAS

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            miniaturas_Click(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            miniaturas_Click(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            miniaturas_Click(2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            miniaturas_Click(3);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            miniaturas_Click(4);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            miniaturas_Click(5);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            miniaturas_Click(6);
        }



        //ARRASTRAR Y SOLTAR

        private void imagenPrinci_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

            

        }

        private void imagenPrinci_DragDrop(object sender, DragEventArgs e)
        {
            try
            {

                String[] archivos = (String[])e.Data.GetData(DataFormats.FileDrop);
                             
                    for (int i = 0; i < archivos.Length; i++)
                    {
                      //  Bitmap imagen = (Bitmap)Image.FromFile(archivos[i]);
                        v.Agregar_Foto(archivos[i]);
                        
                        arrayNombres[numFotos] = archivos[i];
                        numFotos++;

                        ubicarPuntero();

                    }

                    agregarImagenes();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }



        //MENU SUPERIOR

        private void imagenAnteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            irAnterior();
        }

        private void imagenSiguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            irSiguiente();
        }

        private void aumentarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (v.Num_Fotos() != 0)
            {
                imagenPrinci.Image = v.Zoom(1.2f);
            }
        }

        private void disminuirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (v.Num_Fotos() != 0)
            {
                imagenPrinci.Image = v.Zoom(0.8f);
            }
        }

        private void rotarDerechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (v.Num_Fotos() != 0)
            {
                imagenPrinci.Image = v.rotar_hor();
            }
        }

        private void rotarIzquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (v.Num_Fotos() != 0)
            {
                imagenPrinci.Image = v.rotar_antihor();
            }
        }

        private void expandirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void imagenActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarImagen();
        }

        private void todasLasImágenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarTodas();
        }

        private void abrirImágenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFotos();
        }

        private void cerrarVisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void desplazarArribaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagenPrinci.Image = v.Despl(0, 100);
        }

        private void desplazarAbajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagenPrinci.Image = v.Despl(0, -100);
        }

        private void desplazarIzquierdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagenPrinci.Image = v.Despl(100, 0);
        }

        private void desplazarDerechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagenPrinci.Image = v.Despl(-100, 0);
        }        

        private void irAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            irAImagen();
        }



        //FUNCIONALIDADES

        private void irSiguiente()
        {

            if (v.Num_Fotos() != 0)
            {
                if (v.Num_Actual < v.Num_Fotos() - 1)
                {

                    imagenPrinci.Image = v.Next_Foto();
                    label2.Text = arrayNombres[v.Num_Actual];

                    if (v.Num_Actual % 7 == 0)
                    {
                        fila++;
                        limpiarCasillas();
                    }
                    cambiarColor();
                    moverCasillas();
                    v.Get_Foto(v.Num_Actual);
                }
                else
                {
                    elegirNumero(0);
                }
                
            }

        }


            private void irAnterior()
        {

            if (v.Num_Fotos() != 0)
            {
                if (v.Num_Actual > 0)
                {

                    imagenPrinci.Image = v.Prev_Foto();
                    label2.Text = arrayNombres[v.Num_Actual];

                    for (int i=0; i < 700; i=i+7){
                        if (v.Num_Actual == 6+i)
                        {
                            fila--;
                            limpiarCasillas();
                            break;
                        }
                    }
                    
                    cambiarColor();
                    moverCasillas();
                    v.Get_Foto(v.Num_Actual);
                }
                else
                {
                    elegirNumero(v.Num_Fotos()-1);
                }
            }
        }


        private void abrirFotos()
        {

            abrir.ShowDialog();
            try
            {

                    for (int i = 0; i < abrir.FileNames.Length; i++)
                    {
                        v.Agregar_Foto(abrir.FileNames[i]);
                        arrayNombres[numFotos] = abrir.FileNames[i];
                        numFotos++;

                        ubicarPuntero();
                    }

                    agregarImagenes();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debes seleccionar imágenes", "Visor de imágenes");
                Console.WriteLine(ex.Message);
            }

        }


        private void limpiarImagen()
        {


            if (v.Num_Fotos() != 0)
            {
                DialogResult dr = MessageBox.Show("¿Está seguro que desea eliminar la imagen del visor?", "Visor de imágenes", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {

                    Visor v2 = new Visor(616, 379);
                    v2 = v;

                    String[] arrayNombres2 = new String[500];
                    arrayNombres2 = arrayNombres;

                   int nem = v.Num_Actual;
                    num = v.Num_Actual;

                    v = null;
                    v = new Visor(616, 379);
                    fila = 0;

                    arrayNombres = null;
                    arrayNombres = new String[500];
                    numFotos = 0;

                    for (int i = 0; i < v2.Num_Fotos(); i++)
                    {
                        if (i != num)
                        {
                            v.Agregar_Foto(arrayNombres2[i]);
                            arrayNombres[numFotos] = arrayNombres2[i];
                            numFotos++;
                        }
                    }
                   
                    limpiarCasillas();
                    ubicarPuntero();
                    agregarImagenes();
                    if (nem == v.Num_Fotos())
                    {
                        elegirNumero(nem-1);
                    }
                    else
                    {
                        elegirNumero(nem);
                    }
                    



                    if (v.Num_Fotos() == 0)
                    {
                        foreach (PictureBox j in myAL)
                        {
                            j.BackColor = Color.Black;
                        }

                        imagenPrinci.Image = null;

                        label1.Text = "0/0";
                        label2.Text = "";
                    }

                }
            }

        }

        private void limpiarTodas()
        {

            if (v.Num_Fotos() != 0)
            {
                DialogResult dr = MessageBox.Show("¿Está seguro que desea limpiar todas las imágenes del visor?", "Visor de imágenes", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    arrayNombres = null;
                    arrayNombres = new String[500];
                    numFotos = 0;

                    v = null;
                    v = new Visor(616, 379);
                    fila = 0;

                    foreach (PictureBox j in myAL)
                    {
                        j.BackColor = Color.Black;
                    }

                    limpiarCasillas();
                    imagenPrinci.Image = null;

                    label1.Text = "0/0";
                    label2.Text = "";
                }
            }

        }

        private void limpiarCasillas()
        {

            foreach (PictureBox j in myAL)
            {
                j.Image = null;
            }

        }



        private void moverCasillas()
        {
       

            num = 0;

            foreach (PictureBox j in myAL)
            {

                if (num + (fila * casillas) < v.Num_Fotos())
                {
                    j.Image = v.Get_Foto(num + (fila * casillas));
                    num++;

                }

            }

            label1.Text = v.Num_Actual + 1 + "/" + v.Num_Fotos();

        }


        private void cambiarColor()
        {
            try
            {
                foreach (PictureBox j in myAL)
                {
                    j.BackColor = Color.Black;
                }

                num = v.Num_Actual;
                while (num >= 7)
                {
                    num = num - 7;
                }

                PictureBox pic = (PictureBox)myAL[num];
                pic.BackColor = Color.DarkGray;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        private void ubicarPuntero()
        {
            try { 
                if (fal == false)
                {
                    imagenPrinci.Image = v.Foto_Actual();
                    label2.Text = arrayNombres[v.Num_Actual];

                    pictureBox1.BackColor = Color.DarkGray;

                    myAL.Add(pictureBox1);
                    myAL.Add(pictureBox2);
                    myAL.Add(pictureBox3);
                    myAL.Add(pictureBox4);
                    myAL.Add(pictureBox5);
                    myAL.Add(pictureBox6);
                    myAL.Add(pictureBox7);

                    fal = true;
                }
                else
                {
                    num = v.Num_Fotos() - 1;
                    fila = 0;
                        while (num >= 7)
                        {
                            num = num - 7;
                            fila++;
                        }
                    

                    v.Num_Actual = num + (fila * casillas);
                    imagenPrinci.Image = v.Foto_Actual();
                    label2.Text = arrayNombres[v.Num_Actual];

                    cambiarColor();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

    }


        private void agregarImagenes()
        {
          
            num = v.Num_Fotos() - 1;
            

            fila = 0;
            while (num >= 7)
            {
                num = num - 7;
                fila++;
            }

            if (v.Num_Fotos() >= 8)
            {
                limpiarCasillas();
            }

            num = 0;

            foreach (PictureBox j in myAL)
            {

                if (num + (fila * casillas) < v.Num_Fotos())
                {
                    j.Image = v.Get_Foto(num + (fila * casillas));
                    num++;
                }

            }

            label1.Text = v.Num_Actual + 1 + "/" + v.Num_Fotos();
        }


        private void miniaturas_Click(int i)
        {

            try
            {
                v.Num_Actual = i + (fila * casillas);
                imagenPrinci.Image = v.Foto_Actual();
                label2.Text = arrayNombres[v.Num_Actual];

                cambiarColor();
                moverCasillas();
                v.Get_Foto(v.Num_Actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        private void elegirNumero(int num)
        {

            try
            {
                fila = 0;
                while (num >= 7)
                {
                    num = num - 7;
                    fila++;
                }

                v.Num_Actual = num + (fila * casillas);
                imagenPrinci.Image = v.Foto_Actual();
                label2.Text = arrayNombres[v.Num_Actual];

                limpiarCasillas();
                cambiarColor();
                moverCasillas();
                v.Get_Foto(v.Num_Actual);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void irAImagen()
        {
            Form2 testDialog = new Form2();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {

            }
            else
            {
                String num = testDialog.numericPag.Text;

                if (int.Parse(num) > v.Num_Fotos() || int.Parse(num) < 1)
                {
                    DialogResult dr = MessageBox.Show("El número de foto introducido no es válido", "Visor de imágenes", MessageBoxButtons.OK,
        MessageBoxIcon.Information);
                }
                else
                {

                    elegirNumero(int.Parse(num) - 1);

                }
            }
            testDialog.Dispose();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro que desea cerrar el Visor?", "Visor de imágenes", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Question);
            if (dr != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }



    }
}
