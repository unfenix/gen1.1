using System.Text;

namespace gen1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "√енератор паролей";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "¬ведите количество символов (макс. 20):";
            button1.Text = "—генерировать";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int length) && length > 0 && length <= 20)
            {
                string password = GeneratePassword(length);
                Form2 form2 = new Form2(password);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("¬ведите корректную длину парол€.");
            }
        }
        private string GeneratePassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$*_?";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(validChars.Length);
                password.Append(validChars[index]);
            }

            return password.ToString();
        }
    }
}
