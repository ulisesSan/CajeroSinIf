namespace Cajero_sin_if_grafico
{
    public partial class Form1 : Form
    {
        public int pesos = 1000, dosPesos = 1000, cincoPeso = 1000, diezPesos = 1000;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cicloPrograma = 0;
            int cuenta5Suelos = 0;
            int cambio10 = 0, cambio5 = 0, cambio2 = 0, cambio1 = 0;
            int enteroCambio = int.Parse(CambioTXT.Text)-13;
            string cambio = enteroCambio.ToString();
            int decimall = 0, entero = 0,conta =0;

           while(int.Parse(CambioTXT.Text) <= 100 && cicloPrograma == 0)
           {
                while (conta == 0)
                {
                    decimall += int.Parse(cambio[0].ToString());
                    conta++;
                }

                while (conta == 1 && cambio.Length > 1)
                {
                    conta++;
                    entero += int.Parse(cambio[1].ToString());
                }

                while (decimall > 0 && diezPesos > 0 && cambio10 < 4)
                {
                    cambio10++;
                    decimall--;
                }
                int contaEspecial = 1;
                while (decimall > 0 && cincoPeso > 0 && cambio5 < 6)
                {

                    while (contaEspecial == 2)
                    {
                        decimall--;
                        contaEspecial = 0;
                    }
                    while (entero >= 5)
                    {
                        entero -= 5;
                        cuenta5Suelos++;
                    }

                    cambio5++;
                    contaEspecial++;
                }
                while (decimall > 0 && cincoPeso > 0 && decimall == 1)
                {
                    decimall--;
                    cambio5 += 2;
                }
                
                while (entero % 2 == 0 && entero > 0 && dosPesos > 0)
                {
                    cambio2++;
                    entero -= 2;
                }

                while (entero % 2 != 0 && entero > 0 && pesos > 0)
                {
                    cambio1++;
                    entero--;
                    while (entero % 2 == 0 && entero > 0 && dosPesos > 0)
                    {
                        cambio2++;
                        entero -= 2;
                    }
                }
                cicloPrograma++;
           }

            MessageBox.Show("Total de cambio es " + enteroCambio.ToString());
            MessageBox.Show("En 10 pesos se dio  "+cambio10.ToString());
            MessageBox.Show("En 5 pesos se dio  " + cambio5.ToString());
            MessageBox.Show("En 2 pesos se dio  " + cambio2.ToString());
            MessageBox.Show("En 1 peso se dio  " + cambio1.ToString());
            MessageBox.Show("En 5 pesos sueltos se dio  " + cuenta5Suelos.ToString());
            MessageBox.Show("En las decimas hay " + decimall.ToString());
            MessageBox.Show("En los enteros hay " + entero.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}