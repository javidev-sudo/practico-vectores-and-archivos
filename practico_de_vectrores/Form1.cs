using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace practico_de_vectrores
{
    public partial class Form1 : Form
    {

        Vector v1,v2,v3;
             
        public Form1()
        {
            InitializeComponent();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.cargar(int.Parse(textBox1.Text),int.Parse(textBox2.Text),int.Parse(textBox3.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            v1 = new Vector();
            v2 = new Vector();
            v3 = new Vector();
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = v1.Descargar();
        }

        private void cargarFiboReversaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.cargarFi(int.Parse(textBox1.Text));
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v1.cargarFibo(int.Parse(textBox1.Text));
        }

        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox7.Text = v2.Descargar();
        }

        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox8.Text = v3.Descargar();
        }

        private void multilosYNoMultiplosDeMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.MultYNomult(int.Parse(textBox6.Text), ref v2, ref v3);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.MediaPosMultM(int.Parse(textBox6.Text)));
        }

        private void invertirEleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.inveVec();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int n1;
            v1 = new Vector();
            n1 = int.Parse(Interaction.InputBox("N elementos"));
            for (int i = 1; i <= n1; i++)
            {
                v1.Cargar(int.Parse(Interaction.InputBox("Elemento"+i+";")));
            }
        }

        private void verifElemntosRepetidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.VerifOrde());
        }

        private void unionElentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.UniElementos(ref v2, ref v3);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            v2.cargar(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
        }

        private void diferenciaDeElementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.DifElemntos(ref v2, ref v3);

        }

        private void verifSegmentoOrdenadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.VerifSegOr(int.Parse(textBox2.Text), int.Parse(textBox3.Text)));
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            int n1;
            v2 = new Vector();
            n1 = int.Parse(Interaction.InputBox("N elementos"));
            for (int i = 1; i <= n1; i++)
            {
                v2.Cargar(int.Parse(Interaction.InputBox("elemento "+i+" ;")));
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void eliminarNoNoPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.ElimEleNoPrim();
        }

        private void ordenamientoAMultiplosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.OrdMultM(int.Parse(textBox6.Text));
        }

        private void ordenamientoEspiralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.OrdEspi();
        }

        private void contarElementosDeAEntreBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.ConteleDif(int.Parse(textBox2.Text),int.Parse(textBox3.Text)));

        }

        private void encontrarElementoMasRepYSuFrecuenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.EleRepSeg(int.Parse(textBox2.Text),int.Parse(textBox3.Text),ref v2, ref v3 );
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            int ele = 0;
            int fre = 0;
            v1.EleMasRep(int.Parse(textBox2.Text), int.Parse(textBox3.Text), ref ele, ref fre); //var result =
            textBox5.Text = string.Concat(ele);
            textBox9.Text = string.Concat(fre);

            /*var result = v1.EleMasRepV2(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox5.Text = string.Concat(result["elemento"]);
            textBox9.Text = string.Concat(result["frecuencia"]);*/
        }

        private void encontrarElementosYFrecDeSerieFiboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.EleFreFibo(ref v2, ref v3);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            v1.ElerepNorep(int.Parse(textBox2.Text),int.Parse(textBox3.Text));
            textBox7.Text = v1.Descargar();
        }

        private void ordenarCapicualYNoCapicuasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.ordenarCapicuas();
            textBox7.Text = v1.Descargar();
        }

        private void intercalarPrimosYNoPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v1.InterPrim(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
            textBox7.Text = v1.Descargar();
        }

        private void operacionFiboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.OperacionFibo());
        }

        private void elementoMayorEnLasPosicionesMultiplasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Concat(v1.EleMaPosiMul(int.Parse(textBox6.Text)));
        }
    }
}
