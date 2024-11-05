using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gen1._1
{
    public partial class Form2 : Form
    {
        public Form2(string password)
        {
            InitializeComponent();
            label1.Text = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label1.Text);
            MessageBox.Show("Пароль скопирован в буфер обмена!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Генератор паролей";
            label2.Text = "Пароль:";
            button1.Text = "Скопировать";
            button2.Text = "Ок";
        }
    }
}
