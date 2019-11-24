using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using Application = System.Windows.Forms.Application;

namespace direct_save
{
    public partial class Form1 : Form
    {
        int serial = 0;
        public Form1()
        {
            InitializeComponent();
            Init_GUI();
            Load_DB();
            PV_total();
        }


        private void Init_GUI()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 10);
            dataGridView1.DefaultCellStyle.Font = new Font("微軟正黑體", 12);
        }

        private void Load_DB()
        {
            DBconfig.sql_connect = new SQLiteConnection(DBconfig.dbPath);
            DBconfig.sql_connect.Open();
            Show_DB();
        }

        private void Show_DB()
        {
            dataGridView1.Rows.Clear();

            string sql = @"SELECT * from record;";
            DBconfig.sql_cmd = new SQLiteCommand(sql, DBconfig.sql_connect);
            DBconfig.sql_dataread = DBconfig.sql_cmd.ExecuteReader();

            while (DBconfig.sql_dataread.Read())
            {
                int _serial = Convert.ToInt32(DBconfig.sql_dataread["serial"]);
                string _name = Convert.ToString(DBconfig.sql_dataread["name"]);
                int _id = Convert.ToInt32(DBconfig.sql_dataread["id"]);
                ulong _PV = Convert.ToUInt64(DBconfig.sql_dataread["PV"]);
                double _CTR = Convert.ToDouble(DBconfig.sql_dataread["CTR"]);

                serial = _serial;
                DataGridViewRowCollection row = dataGridView1.Rows;
                row.Add(new Object[] { serial, _name, _id, _PV, _CTR });
            }
            DBconfig.sql_dataread.Close();
        }

        public class DBconfig
        {
            public static string dbFile = Application.StartupPath + @"\record.db";
            public static string dbPath = "Data source=" + dbFile;

            public static SQLiteConnection sql_connect;
            public static SQLiteCommand sql_cmd;
            public static SQLiteDataReader sql_dataread;
        }

        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCellCollection selRowData = dataGridView1.SelectedRows[0].Cells;

            textBox1.Text = Convert.ToString(selRowData[1].Value);
            textBox2.Text = Convert.ToString(selRowData[2].Value);
            textBox3.Text = Convert.ToString(selRowData[3].Value);
            textBox4.Text = Convert.ToString(selRowData[4].Value);
            label6.Text = Convert.ToString(selRowData[0].Value);
        }


        private int num_of_CTR(int i_bottom, int i_floor)
        {
            string sql = @"SELECT COUNT(*) AS num from record " +
                          "where(CTR  > " + i_bottom + " ) " +
                                "and(CTR <= " + i_floor + " ); ";

            DBconfig.sql_cmd = new SQLiteCommand(sql, DBconfig.sql_connect);
            DBconfig.sql_dataread = DBconfig.sql_cmd.ExecuteReader();

            DBconfig.sql_dataread.Read();
            int _num = Convert.ToInt32(DBconfig.sql_dataread["num"]);

            return _num;
        }

        private int num_of_PV(int i_bottom, int i_floor)
        {
            string sql = @"SELECT COUNT(*) AS num from record " +
                          "where(PV  > " + i_bottom + " ) " +
                                "and(PV <= " + i_floor + " ); ";

            DBconfig.sql_cmd = new SQLiteCommand(sql, DBconfig.sql_connect);
            DBconfig.sql_dataread = DBconfig.sql_cmd.ExecuteReader();

            DBconfig.sql_dataread.Read();
            int _num = Convert.ToInt32(DBconfig.sql_dataread["num"]);

            return _num;
        }

        private void Add_data_Chick(object sender, EventArgs e)
        {
            string _name = textBox1.Text;
            int _id = Convert.ToInt32(textBox2.Text);
            ulong _PV = Convert.ToUInt64(textBox3.Text);
            double _CTR = Convert.ToDouble(textBox4.Text);

            string sql = @"INSERT INTO record (name,id,PV,CTR) 
                                  VALUES( '" + _name + "',"
                                         + _id.ToString() + ","
                                         + _PV.ToString() + ","
                                         + _CTR.ToString() + ");";

            DBconfig.sql_cmd = new SQLiteCommand(sql, DBconfig.sql_connect);
            DBconfig.sql_cmd.ExecuteNonQuery();

            Show_DB();
            PV_total();
        }

        private void Remove_data_Click(object sender, EventArgs e)
        {
            int _serial = Convert.ToInt32(label6.Text);
            string sql = @"DELETE from record " +
                " where serial = " + _serial.ToString() + ";";
            DBconfig.sql_cmd = new SQLiteCommand(sql, DBconfig.sql_connect);
            DBconfig.sql_cmd.ExecuteNonQuery();
            Show_DB();
            PV_total();
        }

        private void Updata_data_Click(object sender, EventArgs e)
        {
            string _name = textBox1.Text;
            int _id = Convert.ToInt32(textBox2.Text);
            ulong _PV = Convert.ToUInt64(textBox3.Text);
            double _CTR = Convert.ToDouble(textBox4.Text);
            int _serial = Convert.ToInt32(label6.Text);

            string sql = @"UPDATE record " +
                                    " SET name = '" + _name + "',"
                                        + " id = " + _id.ToString() + ","
                                        + " PV = " + _PV.ToString() + ","
                                        + " CTR = " + _CTR.ToString() +
                                        " where serial = " + _serial.ToString() + ";";




            DBconfig.sql_cmd = new SQLiteCommand(sql, DBconfig.sql_connect);
            DBconfig.sql_cmd.ExecuteNonQuery();

            Show_DB();
            PV_total();
        }

        private void Average_CTR_Click(object sender, EventArgs e)
        {
            int _count = dataGridView1.Rows.Count;
            double CTR_total = 0;
            double CTR_avg;
            for (int i = 0; i < _count; i = i + 1)
            {
                CTR_total = CTR_total + Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            CTR_avg = CTR_total / (_count - 1);
            MessageBox.Show(CTR_avg.ToString());
        }

        private void Average_PV_Click(object sender, EventArgs e)
        {
            int _count = dataGridView1.Rows.Count;
            int PV_total = 0;
            int PV_avg;
            for (int i = 0; i < _count; i = i + 1)
            {
                PV_total = PV_total + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            PV_avg = PV_total / (_count - 1);
            MessageBox.Show(PV_avg.ToString());
        }

        private void Chart_CTR_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            Dictionary<string, int> _CTR_bar = new Dictionary<string, int>();

            _CTR_bar.Add("~20%", num_of_CTR(0, 20));
            _CTR_bar.Add("20%~40%", num_of_CTR(20, 40));
            _CTR_bar.Add("40%~60%", num_of_CTR(40, 60));
            _CTR_bar.Add("60%~70%", num_of_CTR(60, 70));
            _CTR_bar.Add("70%~80%", num_of_CTR(70, 80));
            _CTR_bar.Add("80%~", num_of_CTR(80, 1000));

            f.setBar(_CTR_bar);
            f.Show(this);
        }


        private void Chart_PV_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            Dictionary<string, int> _PV_bar = new Dictionary<string, int>();

            _PV_bar.Add("~2500", num_of_PV(0, 2500));
            _PV_bar.Add("2500~5000", num_of_PV(2500, 5000));
            _PV_bar.Add("5000~7500", num_of_PV(5000, 7500));
            _PV_bar.Add("7500~10000", num_of_PV(7500, 10000));
            _PV_bar.Add("10000~12500", num_of_PV(10000, 12500));
            _PV_bar.Add("12500~15000", num_of_PV(12500, 15000));
            _PV_bar.Add("15000~", num_of_PV(15000, 1000000000));

            f.setBar(_PV_bar);
            f.Show(this);
        }

        private void Export_excel_Click(object sender, EventArgs e)
        {
            
            string path = @"..\..\..\";         //使用相對路徑
            string filename = "students_data.xlsx";     //檔名
            ExcelPackage excel = new ExcelPackage();
            ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("學生資料");       //添加第一個資料表

            /*          //下面是匯出到excel的簡單格式設定 可自行變化並放進for迴圈
            ExcelWorksheet worksheet2 = excel.Workbook.Worksheets.Add("2222");        //新增工作表
            worksheet.Cells[1,1,1,10].Merge = true;       //左右合併(第一到第十格)
            worksheet.Cells[1,1,2,10].Merge = true;       //上下合併 1.2列合併
            worksheet.Cells[1, 1, 2, 10].Style.Font.Size = 20;       //更改字型大小
            worksheet.Cells[1, 1, 1, 10].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;     //字型置中
            */

            for (int i = 0; i < dataGridView1.ColumnCount; i = i + 1)     //將屬性名稱寫進excel
            {
                worksheet.Cells[1, i + 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;        //依照上面合併使用過的列數(最大值+1)
            }
            for (int r = 0; r < dataGridView1.Rows.Count; r = r + 1)      //將屬性值寫進excel
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i = i + 1)
                {
                    worksheet.Cells[r + 2, i + 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    worksheet.Cells[r + 2, i + 1].Value = dataGridView1.Rows[r].Cells[i].Value;
                }
                Application.DoEvents();
            }

            worksheet.Cells.AutoFitColumns();       //自動調整欄位大小

            FileInfo excelFile = new FileInfo(path + filename);
            excel.SaveAs(excelFile);

            Process.Start(path + filename);     //開啟excel檔
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57) e.Handled = false;
            else if (e.KeyChar == 8 || e.KeyChar == 13) e.Handled = false;
            else e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57) e.Handled = false;
            else if (e.KeyChar == 8 || e.KeyChar == 13) e.Handled = false;
            else e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57) e.Handled = false;
            else if (e.KeyChar == 8 || e.KeyChar == 13) e.Handled = false;
            else e.Handled = true;
        }

        private void PV_total()
        {
            int _count = dataGridView1.Rows.Count;
            int PV_total = 0;
            for (int i = 0; i < _count; i = i + 1)
            {
                PV_total = PV_total + Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            textBox5.Text = Convert.ToString(PV_total);
        }
    }
}