using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using VAC_Statistic.Core;

namespace VAC_Statistic
{
    public partial class Form1 : Form
    {
        IEnumerable<Article> articles;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            readPDF();

            TextAnalyser analyser = new TextAnalyser(richTextBox1.Text);
            articles = analyser.Parse();

            
            
        }


        private void readPDF()
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

        private void buttonScienceDistribution_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Statistic.beautifulResult(new Statistic().getBranchOfScienceDistribution(articles));
        }

        private void buttonOneDirection_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Statistic.beautifulResult(new Statistic().getBranchOfScienceDistribution_OneDirection(articles));
        }

        private void buttonDirectionCount_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Statistic.beautifulResult(new Statistic().getDirectionsCount(articles));
        }

        private void buttonDirectionPairCount_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = new Statistic().getDirectionsPairCount(articles).ToString();
        }

        private void buttonPairs_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Statistic.beautifulResult(new Statistic().getDirectionPairs(articles));
        }

        private void buttonDirectionThird_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Statistic.beautifulResult(new Statistic().getDirectionThirds(articles));
        }

        private void buttonGNSDistribution_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Statistic.beautifulResult(new Statistic().getGNSDistribution(articles));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Statistic.beautifulResult(new Statistic().getGNSCount(articles));
        }

        private void buttonGNSWithoutDirections_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Statistic.beautifulResult(new Statistic().getGNSDistributionWithouDirections(articles));
        }

        private void buttonGNSPairsWithDirections_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Statistic.beautifulResult(new Statistic().getGNSDirectionNumbers(articles,2));
        }

        private void buttonGNSWithDirection_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Statistic.beautifulResult(new Statistic().getGNSDirectionNumbers(articles,3));
        }

        private void buttonGNSDirectionFour_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Statistic.beautifulResult(new Statistic().getGNSDirectionNumbers(articles, 4));
        }

        private void buttonGNSDirectionFifth_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Statistic.beautifulResult(new Statistic().getGNSDirectionNumbers(articles, 5));
        }
    }
}
