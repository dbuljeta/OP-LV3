using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //StreamReader str = new StreamReader(openFileDialog1.FileName);
                //openFileDialog1.Filter = "Tekst (*.txt)|*.txt| word (*.doc)|*.doc| RTF (*.rtf)|*.rtf";
                //richTextBox1.Text = str.ReadToEnd();
                //str.Close();
                richTextBox1.LoadFile(openFileDialog1.FileName);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Tekst (*.txt)|*.txt| word (*.doc)|*.doc| RTF (*.rtf)|*.rtf";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult boja = colorDialog1.ShowDialog();
            if (boja == DialogResult.OK)
            {
                Color c = colorDialog1.Color;
                richTextBox1.SelectionColor = c;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult font = fontDialog1.ShowDialog();
            if (font == DialogResult.OK)
            {
                Font f = fontDialog1.Font;
                richTextBox1.SelectionFont = f;
            }

        }
    }
}
