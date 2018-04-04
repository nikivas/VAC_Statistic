using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace VAC_Statistic
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

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opener = new OpenFileDialog();
            opener.ShowDialog();

            if (opener.FileName == "")
                return;

            var fileNamesCollection = opener.FileNames;
            
            foreach (var el in fileNamesCollection)
            {
                PDFReader reader = new PDFReader();
                reader.FileName = el;
                richTextBox1.Text += reader.Parse() + "\n\r";
            }
            
        }
    }
}
