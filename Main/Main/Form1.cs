using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“m.Movies”中。您可以根据需要移动或删除它。
            this.moviesTableAdapter.Fill(this.m.Movies);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoiRea moiRea = new MoiRea();
            M.MoviesDataTable table = moiRea.GetMovie(comboBox1.Text);
            End.DataSource = table;
            top.Text = "排名:" + Convert.ToString(table[0].Top - 1);
            name.Text = "名称:" + table[0].Name;
            star.Text = "导演与演员:" + table[0].Stars;
            Date.Text = "上映日期:" + table[0].Date;
            cuuntry.Text = "制作国家/地区:" + table[0].Country;
            review.Text = "一句点评:" + table[0].Review;
            pictureBox1.Image = imageList1.Images[table[0].Top - 2];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
