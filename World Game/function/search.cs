using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using World_Game.sql;

namespace World_Game.function
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.Clear(groupBox1.BackColor);
            //e.Graphics.DrawString(groupBox1.Text, groupBox1.Font, Brushes.Red, 10, 1);
            //e.Graphics.DrawLine(Pens.Red, 1, 7, 8, 7);
            //e.Graphics.DrawLine(Pens.Red, e.Graphics.MeasureString(groupBox1.Text, groupBox1.Font).Width + 8, 7, groupBox1.Width - 2, 7);
            //e.Graphics.DrawLine(Pens.Red, 1, 7, 1, groupBox1.Height - 2);
            //e.Graphics.DrawLine(Pens.Red, 1, groupBox1.Height - 2, groupBox1.Width - 2, groupBox1.Height - 2);
            //e.Graphics.DrawLine(Pens.Red, groupBox1.Width - 2, 7, groupBox1.Width - 2, groupBox1.Height - 2);
        }

        private void search_Load(object sender, EventArgs e)
        {
            //设置出发城市和到达城市的下拉列表框的值
            DBUtil db = new DBUtil();
            List<string> citylist;
            citylist = db.queryAllCity();
            citylist.Sort();
            foreach (string city in citylist)
            {
                this.cityBox.Items.Add(city);
                this.tocityBox.Items.Add(city);
            }
            //根据当前时间设置日期控件的值
            this.comeDate.MinDate = DateTime.Now;
            this.toDate.MinDate = DateTime.Parse(this.comeDate.Text);
        }

        //出发日期的点击事件，用于根据此事件设置到达日期的值
        private void comeDate_ValueChanged(object sender, EventArgs e)
        {
            this.toDate.MinDate = DateTime.Parse(this.comeDate.Text);
        }
    }
}
