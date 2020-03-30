using iTextSharp.text;
using iTextSharp.text.pdf;
using javax.print;
using Magnum.FileSystem;
using Spire.Doc;
using System.Diagnostics;
using System.IO;
using System.Windows;
using Xceed.Words.NET;
using Document = iTextSharp.text.Document;
using Section = Spire.Doc.Section;
using Word = Microsoft.Office.Interop.Word;

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для Export.xaml
    /// </summary>
    public partial class Export : Window
    {
        RecipeWindow recipeWindow = new RecipeWindow();
        
        public Export()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, RoutedEventArgs e)
        {
            //var objWord = new Word.Application();
            //objWord.Visible = false;
            //try
            //{
            //    Word.Document objDoc = objWord.Documents.Add();
            //    var doc = objWord.Documents.Open(FileName);
            //    Word.Paragraph objPar;
            //    objPar = objDoc.Paragraphs.Add();
            //    objPar.Range.Text = "Danildanildanil";
            //    doc.SaveAs(@"D:\result.docx");
            //    doc.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("Произошла ошибка");
            //}

            //finally
            //{
            //    objWord.Quit();
            //}

            //string FileName = "danilllllll.doc";
            //var doc = Doc.Create(FileName).ToString();
            //doc.InsertParagraph(recipeWindow.recipeWindows.ToString());


            //doc.Save();

            //Process.Start("WpfApp5.EXE", FileName);


            Document doc = new Document();
            Section section = doc.AddSection();
            Paragraph Para = section.AddParagraph();
            Para.Content(recipeWindow.recipeWindows.ToString());
            doc.SaveToFile("MyWord.doc", FileFormat.Doc);
            System.Diagnostics.Process.Start("MyWord.docx");
        }

        private void btnPdf_Click_1(object sender, RoutedEventArgs e)
        {
            Document doc = new Document();
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Test.pdf", FileMode.Create));
            doc.Open();
            Paragraph par = new Paragraph(recipeWindow.recipeWindows.ToString());
            doc.Add(par);
            MessageBox.Show("Всё верно!");
            doc.Close();
        }

        private void btnDocX_Click(object sender, RoutedEventArgs e)
        {
            string FileName = "danilllllll.docx";
            var doc = DocX.Create(FileName);
            doc.InsertParagraph(recipeWindow.recipeWindows.ToString());


            doc.Save();

            Process.Start("WpfApp5.EXE", FileName);
        }



    }
}


/*01
private void button1_Click(object sender, RoutedEventArgs e)<font></font>
02
        {<font></font>
03
            //Create New Word<font></font>
04
            Document doc = new Document();<font></font>
05
            //Add Section<font></font>
06
            Section section = doc.AddSection();<font></font>
07
            //Add Paragraph<font></font>
08
            Paragraph Para = section.AddParagraph();<font></font>
09
            //Append Text<font></font>
10
            Para.AppendText("Hello! "<font></font>
11
            + "I was created by Spire.Doc for WPF, it's a professional .NET Word component "<font></font>
12
            + "which enables developers to perform a large range of tasks on Word document (such as create, open, write, edit, save and convert "<font></font>
13
            + "Word document) without installing Microsoft Office and any other third-party tools on system.");<font></font>
14
            //Save and launch<font></font>
15
            doc.SaveToFile("MyWord.docx", FileFormat.Docx);<font></font><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">
16
            System.Diagnostics.Process.Start ( "MyWord.docx");</font></font><font></font><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">
17
        }</font></font><font></font>
*/
