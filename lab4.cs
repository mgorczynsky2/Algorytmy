using System.Security.Cryptography.X509Certificates;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            int[] tab = convert(textBox1.Text);
            int[]tab2  = selectionSort(tab);
            label2.Text = wypisz(tab2);
        }
        public int[] convert(string napis)
        {
            var liczbyS = napis.Trim().Split(' ');
            int[] liczby = new int[liczbyS.Length];
            for (int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = int.Parse(liczbyS[i]);
            }
            return liczby;
        }
        public string wypisz(int[] tab)
        {
            string text = string.Join(", ", tab);
            return text;
        }
        public int minindeks(int[] tab, int start, int koniec)
        {
            int min = start;
            for(int i = start; i < koniec; i++)
            {
                if (tab[min]>tab[i])
                    min = i;
            }
            return min;
        }
        public int [] selectionSort(int[]tab)
        {
            int size = tab.Length;
            int temp;
            int min;
            for (int i = 0; i < size - 1; i++)
            {
                min=minindeks(tab, i, size);
                temp = tab[i];
                tab[i] =tab[min];
                tab[min] = temp;
            }
            return tab;
        }
    }
}
