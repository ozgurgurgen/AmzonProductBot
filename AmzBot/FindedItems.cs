using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmzBot
{
    public partial class FindedItems : Form
    {
        DataTable tablo = new DataTable();
        List<object> list;
        public FindedItems()
        {
            InitializeComponent();
            
            
        }
        //public FindedItems(List<object> list)
        //{
        //    InitializeComponent();
        //    this.list = list;
        //    tablo.Columns.Add("Sıra No", typeof(int));
        //    tablo.Columns.Add("ASIN", typeof(string));
        //    tablo.Columns.Add("Ürün Adı", typeof(string));
        //    tablo.Columns.Add("Maliyeti", typeof(double));
        //    tablo.Columns.Add("Satış F.", typeof(double));
        //    tablo.Columns.Add("Stok", typeof(int));
        //    tablo.Columns.Add("Rank", typeof(string));
        //    tablo.Columns.Add("Ağırlık", typeof(double));
        //    UrunlerDataGrid.DataSource = tablo;
        //    AddData(list);
        //}

            public void AddData(List<object> list)
        {
            //var rowAdet = UrunlerDataGrid.Rows.Count;
            int siraNo = 1;
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            tablo.Rows.Add(siraNo);
            UrunlerDataGrid.DataSource = tablo;
            UrunlerDataGrid.Update();
            UrunlerDataGrid.Refresh();
        }


    }
}
