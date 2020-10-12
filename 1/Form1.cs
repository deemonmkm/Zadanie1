using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
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
		private void button1_Click(object sender, EventArgs e)
		{
			string tarif = null;
			string option = null;
			string msg = null;

			if (radioButton1.Checked) tarif = "100";
			if (radioButton2.Checked) tarif = "200";
			if (radioButton3.Checked) tarif = "300";
			if (radioButton4.Checked) tarif = "400";
			if (radioButton5.Checked) tarif = "500";
			if (radioButton6.Checked) tarif = "600";
			if (radioButton7.Checked) tarif = "700";
			if (checkBox1.Checked) option = "АнтиАОН" + "\n";
			if (checkBox2.Checked) option = option + "Переадрессация вызова" + "\n";
			if (checkBox3.Checked) option = option + "Автоинформатор" + "\n";
			if (checkBox4.Checked) option = option + "Расширенный пакет СМС" + "\n";
			if (checkBox5.Checked) option = option + "Локатор" + "\n";
			if (checkBox6.Checked) option = option + "Запрет подписок" + "\n";
			if (option != null) msg = "c опциями:\n";

			MessageBox.Show("Вы подключили тариф " + tarif + " " + msg + option);	
		}
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}
		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}
		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{

		}
		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{

		}
		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{

		}
		private void radioButton6_CheckedChanged(object sender, EventArgs e)
		{

		}
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{

		}
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
