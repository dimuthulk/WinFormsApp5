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

            // Using while loop
            //while (i <= 9)
            //{
            //    richTextBox1.Text += i + "\n";
            //    i++;
            //}

            // Using for loop
            //for (int j = 0; j <= 9; j++)
            //{
            //    richTextBox1.Text += j + "\n";
            //}

            // Using do while loop
            do
            {
                richTextBox1.Text += i + "\n";
                i++;
            } while (i <= 9);
        }
    }
 }
