using Practica7._2.Entities;

namespace Practica7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ordenador gus = new Ordenador();
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string palabra = textBox1.Text;
            gus.AgregarPalabra(palabra);
            gus.InvertirPalabra(palabra);
            label1.Visible = true;
            foreach (Palabra p in gus.palabrasIngresadas)
            {
                listBox1.Items.Add($"{p._Palabra}");
            }
            foreach (Palabra p in gus.palabrasInvertidas)
            {
                listBox2.Items.Add($"{p._Palabra}");
            }
            if (gus.EsPalindromo(palabra))
            {
                label1.Text = "Es Palindromo";
            }
            else
            {
                label1.Text = "No es Palindromo";
            }
            textBox1.Clear();
        }
    }
}