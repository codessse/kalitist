using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace direct_save
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void setBar(Dictionary<string, int> i_PV_bar)
        {
            foreach (var OneItem in i_PV_bar)
            {
                chart1.Series["PV"].Points.AddXY(OneItem.Key, OneItem.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"..\..\..\";     //使用相對路徑
            string filename = "PV.pdf";     //檔名
            Document Doc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);        //定義pdf大小,f為邊界空白寬度
            PdfWriter.GetInstance(Doc, new FileStream(path + filename, FileMode.Create));

            Doc.Open();
            using (MemoryStream memory = new MemoryStream())
            {
                chart1.SaveImage(memory, ChartImageFormat.Png);
                Image img = Image.GetInstance(memory.GetBuffer());      //將圖片以陣列儲存到記憶體
                img.ScalePercent(75f);      //圖片大小縮放
                Doc.Add(img);
                Doc.Close();
            }
            Process.Start(path + filename);     //開啟pdf
        }
    }
}
