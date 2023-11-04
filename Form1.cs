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
        void bombel(int[] tab)//select sort drugie
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
            int tmp = 0;
            for (int i = 0; i < tab.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[i])
                        min = j;

                    tmp = tab[min];
                    tab[min] = tab[i];
                    tab[i] = tab[tmp];
                }

            }
        }
    

        private void buttonss_Click(object sender, EventArgs e)
        {
            string[]liczbyStr = textBoxwpisz.Text.Split('_');
            int[] liczby = new int[liczbyStr.Length];
            for(int i = 0; i < liczbyStr.Length; i++)
            {
                if (int.TryParse(liczbyStr[i],out int val))
                {
                    liczby[i] = val;
                }
            }
            bombel(liczby);
            textBoxpokaz.Text = string.Join('_', liczby);

        }

        private void buttonsb_Click(object sender, EventArgs e)
        {

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

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttongeneruj_Click(object sender, EventArgs e)
        {

        }
    }
}