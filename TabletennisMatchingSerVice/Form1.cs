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
    public partial class Form1 : Form
    {

        Search search;

        PlayerDataSet.playerDataTableDataTable playerDataTable;

        Dictionary<string, string> CityNames;
        public Form1()
        {
            InitializeComponent();

            this.search = new Search(playerDataSet.playerDataTable);
            search.Show();
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            playerDataSet.playerDataTable.AddplayerDataTableRow(this.Names.Text,this.Birthplace.Text,this.Achievement.Text,this.BattleType.Text,this.PracticeTimeZone.Text,this.PracticePlace.Text);
        }

        private void RemoveButtonClicked(object sender, EventArgs e)
        {
            int row = this.PlayerDataGrid.CurrentRow.Index;
            this.PlayerDataGrid.Rows.RemoveAt(row);
        }
        private void 保存ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            playerDataSet.WriteXml("player.xml");
        }

        private void 読み出しToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            playerDataSet.ReadXml("player.xml");
        }

        private void PlayerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public Form1(PlayerDataSet.playerDataTableDataTable playerDataTable)
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
                Birthplace.Items.Add(data.Key);
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
                PracticePlace.Items.Add(data.Key);
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
                Achievement.Items.Add(data.Key);
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
                BattleType.Items.Add(data.Key);
            }
        }
    }
}
