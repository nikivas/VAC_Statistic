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
            var lnk = new Statistic().getGNSDirectionNumbers(articles, 2);
            var count4 = lnk.Where(x => x.Value == 4).Count();
            var count3 = lnk.Where(x => x.Value == 3).Count();
            var count2 = lnk.Where(x => x.Value == 2).Count();
            var count1 = lnk.Where(x => x.Value == 1).Count();
            richTextBox1.Text = Statistic.beautifulResult(lnk);
        }


        private void buttonGNSWithDirection_Click(object sender, EventArgs e)
        {
            var lnk = new Statistic().getGNSDirectionNumbers(articles, 3);
            var count3 = lnk.Where(x => x.Value == 3).Count();
            var count2 = lnk.Where(x => x.Value == 2).Count();
            var count1 = lnk.Where(x => x.Value == 1).Count();
            richTextBox1.Text = Statistic.beautifulResult(lnk);
        }

        private void buttonGNSDirectionFour_Click(object sender, EventArgs e)
        {
            var lnk = new Statistic().getGNSDirectionNumbers(articles, 4);
            var count4 = lnk.Where(x => x.Value == 4).Count();
            var count3 = lnk.Where(x => x.Value == 3).Count();
            var count2 = lnk.Where(x => x.Value == 2).Count();
            var count1 = lnk.Where(x => x.Value == 1).Count();
            richTextBox1.Text = Statistic.beautifulResult(lnk);
        }

        private void buttonGNSDirectionFifth_Click(object sender, EventArgs e)
        {
            var lnk = new Statistic().getGNSDirectionNumbers(articles, 5);
            var count3 = lnk.Where(x => x.Value == 3).Count();
            var count2 = lnk.Where(x => x.Value == 2).Count();
            var count1 = lnk.Where(x => x.Value == 1).Count();
            richTextBox1.Text = Statistic.beautifulResult(lnk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Statistic.beautifulResult(new Statistic().getObjectsDirection(articles));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var lnk = new Statistic().Plotnost(articles);
            richTextBox1.Text = Statistic.beautifulResult(lnk);
        }

        private void buttonGNS_NJ_ALL_Click(object sender, EventArgs e)
        {
            var lnk = new Statistic().getGNS_NJ_ALL(articles);
            richTextBox1.Text = Statistic.beautifulResult(lnk);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var link = new Statistic().getWitoutTechnicalSpecs(articles);
            richTextBox1.Text = Statistic.beautifulResult( link );
        }

        private void buttonOnlyTN_Click(object sender, EventArgs e)
        {
            var link = new Statistic().getWithTechnicalSpecsOnly(articles);

            richTextBox1.Text = Statistic.beautifulResult(link);
        }

        private void buttonTnAndNotTn_Click(object sender, EventArgs e)
        {
            var link = new Statistic().getWithTechnicalAndNotTechnicalSpecs(articles);
            richTextBox1.Text = Statistic.beautifulResult(link);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var link = new Statistic().getTnWithoutPhysic(articles);
            richTextBox1.Text = Statistic.beautifulResult(link);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var link = new Statistic().getTnWithPhysic(articles);
            richTextBox1.Text = Statistic.beautifulResult(link);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var techAndPhys = new Statistic().getNS_TN_FMI(articles);
            richTextBox1.Text = Statistic.beautifulResult(techAndPhys);
        }

        private void buttonNS_Count_Click(object sender, EventArgs e)
        {
            var link = new Statistic().getNSCount(articles);
            richTextBox1.Text = Statistic.beautifulResult(link);
        }

        private void buttonTNDistrib_Click(object sender, EventArgs e)
        {
            var link = new Statistic().getNSTechDistribution(articles);
            richTextBox1.Text = Statistic.beautifulResult(link);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var link = new Statistic().getNSTechDistribForEach(articles);
            richTextBox1.Text = Statistic.beautifulResult(link);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var link = new Statistic().listFrequencySpecs(articles, firstCode: 5, secondCode: 2);
            richTextBox1.Text = Statistic.beautifulResult(link);
            richTextBox1.Text = richTextBox1.Text + "\r\n" + (new Statistic().difValue(link)).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var link = new Statistic().listFrequencySpecs(articles, firstCode: 5, secondCode: 11);
            richTextBox1.Text = Statistic.beautifulResult(link);
            richTextBox1.Text = richTextBox1.Text + "\r\n" + (new Statistic().difValue(link)).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var link = new Statistic().listFrequencySpecs(articles, firstCode: 5, secondCode: 13);
            richTextBox1.Text = Statistic.beautifulResult(link);
            richTextBox1.Text = richTextBox1.Text + "\r\n" + (new Statistic().difValue(link)).ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var link = new Statistic().listFrequencySpecs(articles, firstCode: 5, secondCode: 22);
            richTextBox1.Text = Statistic.beautifulResult(link);
            richTextBox1.Text = richTextBox1.Text + "\r\n" + (new Statistic().difValue(link)).ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var link = new Statistic().listFrequencySpecs(articles, firstCode: 5, secondCode: 23);
            richTextBox1.Text = Statistic.beautifulResult(link);
            richTextBox1.Text = richTextBox1.Text + "\r\n" + (new Statistic().difValue(link)).ToString();
        }
    }
}
