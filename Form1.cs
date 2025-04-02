namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 9)
            {
                richTextBox1.Text += i + "\n";
                i++;
            }
        }
    }
 }
