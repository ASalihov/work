using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Work
{
    public static class WorldbestlearningcenterExample
    {
        public static void Go()
        {
            //variables
            String pathin = "d:/0.pdf";
            String pathout = "d:/666.pdf";
            //create a document object
            //var doc = new Document(PageSize.A4);
            //create PdfReader object to read from the existing document
            PdfReader reader = new PdfReader(pathin);
            //select three pages from the original document
            reader.SelectPages("1");
            //create PdfStamper object to write to get the pages from reader 
            PdfStamper stamper = new PdfStamper(reader, new FileStream(pathout, FileMode.Create));
            // PdfContentByte from stamper to add content to the pages over the original content
            PdfContentByte pbover = stamper.GetOverContent(1);
            //add content to the page using ColumnText
            ColumnText.ShowTextAligned(pbover, Element.ALIGN_LEFT, new Phrase("<b>Hello World</b>"), 100, 400, 0);
            // PdfContentByte from stamper to add content to the pages under the original content
            PdfContentByte pbunder = stamper.GetUnderContent(1);
            //add image from a file 
            iTextSharp.text.Image img = new Jpeg(imageToByteArray(System.Drawing.Image.FromFile("d:/1.jpg")));
            img.Url = new Uri(@"http://stackoverflow.com/");
            //add the image under the original content
            pbunder.AddImage(img, img.Width / 2, 2, 2, img.Height / 2, 100, 62);

            //close the stamper
            stamper.Close();
            pbunder.ClosePath();
            pbover.ClosePath();
            File.Delete("d:/0.pdf");
            File.Move("d:/666.pdf", "111");

            //Console.Read();
        }

        //this method will be called to convert an image object to byte array
        public static byte[] imageToByteArray(System.Drawing.Image imageori)
        {
            using (var ms = new MemoryStream())
            {
                imageori.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}
