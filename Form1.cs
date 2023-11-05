using System.Diagnostics;

namespace AiSD_IO_gr3_1
{
    public partial class Form1 : Form
    {
        int[] tablica;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void bubble(int[] tab)//
        {
            int tmp; bool cbz = false;

            do
            {
                cbz = false;
                for (int i = 0; i < tab.Length - 1; i++)//zamienia liczbe po lewej z liczba poprawej jesli jest wieksza i robi to az do momentu gdy nie bedzie zadnych zmian
                {

                    if (tab[i] > tab[i + 1])
                    {
                        tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                        cbz = true;

                    }
                }
            } while (cbz);

        }
        void select_sort(int[] tab)//szukamy najni¿szej i zamieniamy z pierwszym aktualnym indexem
        {
            int tmp;
            for (int i = 0; i < tab.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[min])
                        min = j;
                }
                tmp = tab[min];
                tab[min] = tab[i];
                tab[i] = tmp;
            }
        }

        void insert_sort(int[] tab)
        {
            for(int i = 1; i < tab.Length; i++)
            {
                int key = tab[i];
                int j = i - 1;
                while (j >= 0&&tab[j] > key)
                {
                    tab[j+1] = tab[j];
                    j--;
                }
                tab[j+1]= key;
            }
        }


        private void buttonss_Click(object sender, EventArgs e)
        {
            if (!checkbox.Checked)
            {
                string[] liczbyStr = textBoxwpisz.Text.Split('_');
                int[] liczby = new int[liczbyStr.Length];
                for (int i = 0; i < liczbyStr.Length; i++)
                {
                    if (int.TryParse(liczbyStr[i], out int val))
                    {
                        liczby[i] = val;
                    }
                }
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                select_sort(liczby);
                stopwatch.Stop();
                TimeSpan czasTrwania = stopwatch.Elapsed;
                label1.Text = czasTrwania.TotalMilliseconds + "ms";
                textBoxpokaz.Text = string.Join('_', liczby);
            }
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                select_sort(tablica);
                stopwatch.Stop();
                TimeSpan czasTrwania = stopwatch.Elapsed;
                label1.Text = czasTrwania.TotalMilliseconds + "ms";
                textBoxpokaz.Text = string.Join('_', tablica);
                label4.Text = "";
            }

        }

        private void buttonsb_Click(object sender, EventArgs e)
        {
            if (!checkbox.Checked)
            {
                string[] liczbyStr = textBoxwpisz.Text.Split('_');
                int[] liczby = new int[liczbyStr.Length];
                for (int i = 0; i < liczbyStr.Length; i++)
                {
                    if (int.TryParse(liczbyStr[i], out int val))
                    {
                        liczby[i] = val;
                    }
                }
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                bubble(liczby);
                stopwatch.Stop();
                TimeSpan czasTrwania = stopwatch.Elapsed;
                label1.Text = czasTrwania.TotalMilliseconds + "ms";
                textBoxpokaz.Text = string.Join('_', liczby);
            }
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                bubble(tablica);
                stopwatch.Stop();
                TimeSpan czasTrwania = stopwatch.Elapsed;
                label1.Text = czasTrwania.TotalMilliseconds + "ms";
                textBoxpokaz.Text = string.Join('_', tablica);
                label4.Text = "";
            }
        }

        private void buttonsi_Click(object sender, EventArgs e)
        {
            if (!checkbox.Checked)
            {
                string[] liczbyStr = textBoxwpisz.Text.Split('_');
                int[] liczby = new int[liczbyStr.Length];
                for (int i = 0; i < liczbyStr.Length; i++)
                {
                    if (int.TryParse(liczbyStr[i], out int val))
                    {
                        liczby[i] = val;
                    }
                }
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                insert_sort(liczby);
                stopwatch.Stop();
                TimeSpan czasTrwania = stopwatch.Elapsed;
                label1.Text = czasTrwania.TotalMilliseconds + "ms";
                textBoxpokaz.Text = string.Join('_', liczby);
            }
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                insert_sort(tablica);
                stopwatch.Stop();
                TimeSpan czasTrwania = stopwatch.Elapsed;
                label1.Text = czasTrwania.TotalMilliseconds + "ms";
                textBoxpokaz.Text = string.Join('_', tablica);
                label4.Text = "";
            }
        }

        private void buttonsm_Click(object sender, EventArgs e)
        {

        }

        private void buttonsq_Click(object sender, EventArgs e)
        {

        }

        private void textBoxwpisz_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxpokaz_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = checkbox.Checked;
            buttongeneruj.Enabled = checkbox.Checked;
            textBoxwpisz.Enabled = !checkbox.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttongeneruj_Click(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            Random random = new Random();
            tablica = new int[n];
            for (int i = 0; i < n; i++)
            {
                tablica[i] = random.Next(0, 100);
            }
            label4.Text = "Wygenerowano Liczby";
            label4.Visible = true;


        }
    }
}