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
            var liczbyS = napis.Split(' ');
            int[] liczby = new int[liczbyS.Length];
            for (int i = 0; i < liczbyS.Length; i++)
            {
                liczby[i] = Convert.ToInt32(liczbyS[i]);
            }
            return liczby;
        }
        public string wypisz(int[] tab)
        {
            string text = string.Join(", ", tab);
            return text;
        }
        public int [] selectionSort(int[]tab)
        {
            int size = tab.Length;
            int min;
            int temp;
            for (int i = 0; i < size - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (tab[j] < tab[min])
                    {
                        min= j;
                    }
                }
                temp = tab[i];
                tab[i] =tab[min];
                tab[min] = temp;
            }
            return tab;
        }
    }
}
