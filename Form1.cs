using System.Diagnostics;

namespace AiSD_IO_gr3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int[] tab;
        void bubble(int[] tab)//select sort drugie
        {
            int tmp; bool cbz = false;

            do
            {
                cbz = false;
                for (int i = 0; i < tab.Length - 1; i++)
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
        void select_sort(int[] tab)
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
                select_sort(tab);
                stopwatch.Stop();
                TimeSpan czasTrwania = stopwatch.Elapsed;
                label1.Text = czasTrwania.TotalMilliseconds + "ms";
                textBoxpokaz.Text = string.Join('_', tab);
            }

        }

        private void buttonsb_Click(object sender, EventArgs e)
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
            bubble(liczby);
            textBoxpokaz.Text = string.Join('_', liczby);
        }

        private void buttonsi_Click(object sender, EventArgs e)
        {

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
            tab = new int[n];
            for (int i = 0; i < n; i++)
            {
                tab[i] = random.Next(0, 100);
            }
            label4.Text = "Wygenerowano Liczby";
            label4.Visible = true;


        }
    }
}