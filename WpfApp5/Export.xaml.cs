using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows;
using Document = iTextSharp.text.Document;
using Word = Microsoft.Office.Interop.Word;
namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Export.xaml
    /// </summary>
    public partial class Export : Window
    {
        private string FileName = @"D:\text.docx";
        public Export()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var objWord = new Word.Application();
            objWord.Visible = false;
            try
            {
                Word.Document objDoc = objWord.Documents.Add();
                var doc = objWord.Documents.Open(FileName);
                Word.Paragraph objPar;
                objPar = objDoc.Paragraphs.Add();
                objPar.Range.Text = "Danildanildanil";
                doc.SaveAs(@"D:\result.docx");
                doc.Close();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }

            finally
            {
                objWord.Quit();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Document doc = new Document();
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));
            doc.Open();
            Paragraph par = new Paragraph("Me name is Danil");
            doc.Add(par);
            doc.Close();
            MessageBox.Show("Ok");
        }
    }
}
