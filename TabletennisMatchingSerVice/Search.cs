using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabletennisMatchingSerVice
{
    public partial class Search : Form
    {
        PlayerDataSet.playerDataTableDataTable playerDataTable;

        Dictionary<string, string> CityNames;
        public Search(PlayerDataSet.playerDataTableDataTable playerDataTable)
        {
            InitializeComponent();

            this.playerDataTable = playerDataTable;

            this.CityNames = new Dictionary<string, string>();

            this.CityNames.Add("北海道", "1");
            this.CityNames.Add("青森", "2");
            this.CityNames.Add("秋田", "3");
            this.CityNames.Add("岩手", "4");
            this.CityNames.Add("宮城", "5");
            this.CityNames.Add("山形", "6");
            this.CityNames.Add("群馬", "7");
            this.CityNames.Add("栃木", "8");
            this.CityNames.Add("茨城", "9");
            this.CityNames.Add("埼玉", "10");
            this.CityNames.Add("東京", "11");
            this.CityNames.Add("千葉", "12");
            this.CityNames.Add("神奈川", "13");

            foreach (KeyValuePair<string, string> data in this.CityNames)
            {
                areaBox.Items.Add(data.Key);
            }

            this.CityNames = new Dictionary<string, string>();

            this.CityNames.Add("朝", "1");
            this.CityNames.Add("昼", "2");
            this.CityNames.Add("夕方", "3");
            this.CityNames.Add("夜", "4");
            this.CityNames.Add("0:00～6:00", "5");
            this.CityNames.Add("6:00～9:00", "6");
            this.CityNames.Add("9:00～12:00", "7");
            this.CityNames.Add("12:00～15:00", "8");
            this.CityNames.Add("15:00～18:00", "9");
            this.CityNames.Add("18:00～21:00", "10");
            this.CityNames.Add("21:00～0:00", "11");
            this.CityNames.Add("毎日", "12");


            foreach (KeyValuePair<string, string> data in this.CityNames)
            {
                areaBox1.Items.Add(data.Key);
            }

            this.CityNames = new Dictionary<string, string>();

            this.CityNames.Add("初心者", "1");
            this.CityNames.Add("中級者", "2");
            this.CityNames.Add("上級者", "3");
            this.CityNames.Add("地区大会レベル", "4");
            this.CityNames.Add("県大会出場レベル", "5");
            this.CityNames.Add("関東大会レベル", "6");
            this.CityNames.Add("全国レベル", "7");
            this.CityNames.Add("全国トップレベル", "8");


            foreach (KeyValuePair<string, string> data in this.CityNames)
            {
                areaBox2.Items.Add(data.Key);
            }


            this.CityNames = new Dictionary<string, string>();

            this.CityNames.Add("両ハンドドライブマン", "1");
            this.CityNames.Add("ドライブマン", "2");
            this.CityNames.Add("前陣速攻", "3");
            this.CityNames.Add("カットマン", "4");
            this.CityNames.Add("ブロックマン", "5");
            this.CityNames.Add("粒高", "6");
            this.CityNames.Add("表ソフト", "7");
            this.CityNames.Add("粘着ドライブマン", "8");


            foreach (KeyValuePair<string, string> data in this.CityNames)
            {
                areaBox3.Items.Add(data.Key);
            }
        }

        string citySelectString;
        string citySelectString1;
        string citySelectString2;
        string citySelectString3;

        private void CitySelected(object sender, EventArgs e)
        {
            citySelectString = areaBox.SelectedItem.ToString();

            //  citySelectString = CityNames
        }

        private void DataTable_Get_Row_Item()
        {
            Form1 form1 = new Form1();

            DataRow[] dr;

            dr = PlayerDataSet.Select();
        }
        private void Search1_Click(object sender, EventArgs e)
        {
         //   Form1 form1 = new Form1();

            var dRows = playerDataTable.Select($"練習場所（都道府県）= '{citySelectString}'");

            foreach (var row in dRows)
            {
                listBox1.Items.Add(row["名前"]);
            }
            //if (areaBox2 == Achievement)
            //{

            //}

            var dRows1 = playerDataTable.Select($"実績= '{citySelectString1}'");

            foreach (var row in dRows1)
            {
                listBox1.Items.Add(row["名前"]);
            }

            var dRows2 = playerDataTable.Select($"戦型= '{citySelectString2}'");

            foreach (var row in dRows2)
            {
                listBox1.Items.Add(row["名前"]);
            }

            var dRows3 = playerDataTable.Select($"練習時間帯・曜日= '{citySelectString3}'");

            foreach (var row in dRows3)
            {
                listBox1.Items.Add(row["名前"]);
            }
        }


        private void areaBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            citySelectString1 = areaBox2.SelectedItem.ToString();
        }

        private void areaBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            citySelectString2 = areaBox3.SelectedItem.ToString();
        }

        private void areaBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            citySelectString3 = areaBox1.SelectedItem.ToString();
        }
    }
}
