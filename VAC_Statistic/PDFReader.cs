using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
namespace VAC_Statistic
{
    class PDFReader
    {
        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set
            {
                if(File.Exists(value))
                    _fileName = value;
            }
        }

        public string Parse()
        {
            if (!File.Exists(this._fileName))
                throw new FileNotFoundException();

            StringBuilder text = new StringBuilder();

            if (File.Exists(_fileName))
            {
                PdfReader pdfReader = new PdfReader(_fileName);

                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);
                    currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));
                    text.Append(currentText);
                    text.Append("\r\n");
                }
                pdfReader.Close();
            }
            return text.ToString();

        }


        
    }
}
