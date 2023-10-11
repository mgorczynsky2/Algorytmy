using System.Collections.Specialized;

namespace mg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int liczbaN =(int)liczba_n.Value;
            long wynik = Fib2(liczbaN);
            MessageBox.Show(wynik.ToString());
        }
        int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
        long Fib2(int n)
        {
           long[] wyrazy = new long[n+1];
           wyrazy[0] = 0;
           wyrazy[1] = 1;
           for(int i=2;i<wyrazy.Length;i++)
            {
                wyrazy[i] = wyrazy[i - 1] + wyrazy[i - 2];
            }
            return wyrazy[n];
        }
    }
}
