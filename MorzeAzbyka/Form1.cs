namespace MorzeAzbyka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string enter;
        string v;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            enter = textBox1.Text;
            string[] vyvod = new string[enter.Length];
            char[] alfavit = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string[] alfavitmorze = { "*-", "-***", "-*-*", "-**", "*", "**-*", "--*", "****", "**", "*---", "-*-", "*-**", "--", "-*", "---", "*--*", "--*-", "*-*", "***", "-", "**-", "***-", "*--", "-**-", "-*--", "--**" };
            for (int i = 0; i < enter.Length; i++)
            {
                for (int j = 0; j < alfavit.Length; j++)
                {
                    if (enter[i] == alfavit[j])
                    {
                        vyvod[i] = alfavitmorze[j];
                    }
                }
            }
            for (int h = 0; h < vyvod.Length; h++)
            {
                textBox2.Text += vyvod[h] + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            enter = textBox1.Text;
            string[] enterarray = enter.Split(' ');
            string[] vyvod = new string[enter.Length];
            char[] alfavit = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string[] alfavitmorze = { "*-", "-***", "-*-*", "-**", "*", "**-*", "--*", "****", "**", "*---", "-*-", "*-**", "--", "-*", "---", "*--*", "--*-", "*-*", "***", "-", "**-", "***-", "*--", "-**-", "-*--", "--**" };
            for (int i = 0; i < enterarray.Length; i++)
            {
                for (int j = 0; j < alfavitmorze.Length; j++)
                {
                    if (enterarray[i] == alfavitmorze[j])
                    {
                        vyvod[i] = Convert.ToString(alfavit[j]);
                    }
                }
            }
            for (int h = 0; h < vyvod.Length; h++)
            {
                textBox2.Text += vyvod[h];

            }
        }
    }
}