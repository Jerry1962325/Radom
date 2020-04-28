namespace Main
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.top = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.star = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.cuuntry = new System.Windows.Forms.Label();
            this.review = new System.Windows.Forms.Label();
            this.End = new System.Windows.Forms.DataGridView();
            this.Top250 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.topDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boolDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.reviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m = new Main.M();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.moviesTableAdapter = new Main.MTableAdapters.MoviesTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.End)).BeginInit();
            this.Top250.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Top250);
            this.tabControl1.Location = new System.Drawing.Point(-3, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(937, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.top);
            this.tabPage1.Controls.Add(this.name);
            this.tabPage1.Controls.Add(this.star);
            this.tabPage1.Controls.Add(this.Date);
            this.tabPage1.Controls.Add(this.cuuntry);
            this.tabPage1.Controls.Add(this.review);
            this.tabPage1.Controls.Add(this.End);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(929, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "抽个奖";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(735, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "开选";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "剧情",
            "喜剧",
            "动作",
            "爱情",
            "科幻",
            "动画",
            "悬疑",
            "惊悚",
            "恐怖",
            "犯罪",
            "同性",
            "音乐",
            "歌舞",
            "传记",
            "历史",
            "战争",
            "西部",
            "奇幻",
            "冒险",
            "灾难",
            "武侠",
            "情色"});
            this.comboBox1.Location = new System.Drawing.Point(735, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // top
            // 
            this.top.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.top.AutoSize = true;
            this.top.Location = new System.Drawing.Point(237, 6);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(37, 15);
            this.top.TabIndex = 7;
            this.top.Text = "排名";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(237, 68);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(37, 15);
            this.name.TabIndex = 6;
            this.name.Text = "片名";
            // 
            // star
            // 
            this.star.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.star.AutoSize = true;
            this.star.Location = new System.Drawing.Point(237, 130);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(37, 15);
            this.star.TabIndex = 5;
            this.star.Text = "演员";
            // 
            // Date
            // 
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(237, 192);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(67, 15);
            this.Date.TabIndex = 4;
            this.Date.Text = "上映日期";
            // 
            // cuuntry
            // 
            this.cuuntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuuntry.AutoSize = true;
            this.cuuntry.Location = new System.Drawing.Point(237, 254);
            this.cuuntry.Name = "cuuntry";
            this.cuuntry.Size = new System.Drawing.Size(105, 15);
            this.cuuntry.TabIndex = 3;
            this.cuuntry.Text = "制作国家/地区";
            // 
            // review
            // 
            this.review.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.review.AutoSize = true;
            this.review.Location = new System.Drawing.Point(237, 316);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(37, 15);
            this.review.TabIndex = 2;
            this.review.Text = "点评";
            // 
            // End
            // 
            this.End.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.End.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.End.Location = new System.Drawing.Point(6, 339);
            this.End.Name = "End";
            this.End.RowHeadersWidth = 51;
            this.End.RowTemplate.Height = 27;
            this.End.Size = new System.Drawing.Size(917, 82);
            this.End.TabIndex = 0;
            // 
            // Top250
            // 
            this.Top250.Controls.Add(this.dataGridView1);
            this.Top250.Location = new System.Drawing.Point(4, 25);
            this.Top250.Name = "Top250";
            this.Top250.Padding = new System.Windows.Forms.Padding(3);
            this.Top250.Size = new System.Drawing.Size(929, 424);
            this.Top250.TabIndex = 1;
            this.Top250.Text = "Top250";
            this.Top250.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.topDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.starsDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.typesDataGridViewTextBoxColumn,
            this.boolDataGridViewCheckBoxColumn,
            this.reviewDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.moviesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(917, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // topDataGridViewTextBoxColumn
            // 
            this.topDataGridViewTextBoxColumn.DataPropertyName = "Top";
            this.topDataGridViewTextBoxColumn.HeaderText = "Top";
            this.topDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.topDataGridViewTextBoxColumn.Name = "topDataGridViewTextBoxColumn";
            this.topDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // starsDataGridViewTextBoxColumn
            // 
            this.starsDataGridViewTextBoxColumn.DataPropertyName = "Stars";
            this.starsDataGridViewTextBoxColumn.HeaderText = "Stars";
            this.starsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.starsDataGridViewTextBoxColumn.Name = "starsDataGridViewTextBoxColumn";
            this.starsDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 125;
            // 
            // typesDataGridViewTextBoxColumn
            // 
            this.typesDataGridViewTextBoxColumn.DataPropertyName = "Types";
            this.typesDataGridViewTextBoxColumn.HeaderText = "Types";
            this.typesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typesDataGridViewTextBoxColumn.Name = "typesDataGridViewTextBoxColumn";
            this.typesDataGridViewTextBoxColumn.Width = 125;
            // 
            // boolDataGridViewCheckBoxColumn
            // 
            this.boolDataGridViewCheckBoxColumn.DataPropertyName = "Bool";
            this.boolDataGridViewCheckBoxColumn.HeaderText = "Bool";
            this.boolDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.boolDataGridViewCheckBoxColumn.Name = "boolDataGridViewCheckBoxColumn";
            this.boolDataGridViewCheckBoxColumn.Width = 125;
            // 
            // reviewDataGridViewTextBoxColumn
            // 
            this.reviewDataGridViewTextBoxColumn.DataPropertyName = "Review";
            this.reviewDataGridViewTextBoxColumn.HeaderText = "Review";
            this.reviewDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reviewDataGridViewTextBoxColumn.Name = "reviewDataGridViewTextBoxColumn";
            this.reviewDataGridViewTextBoxColumn.Width = 125;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.m;
            // 
            // m
            // 
            this.m.DataSetName = "M";
            this.m.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpg");
            this.imageList1.Images.SetKeyName(1, "2.jpg");
            this.imageList1.Images.SetKeyName(2, "3.jpg");
            this.imageList1.Images.SetKeyName(3, "4.jpg");
            this.imageList1.Images.SetKeyName(4, "5.jpg");
            this.imageList1.Images.SetKeyName(5, "6.jpg");
            this.imageList1.Images.SetKeyName(6, "7.jpg");
            this.imageList1.Images.SetKeyName(7, "8.jpg");
            this.imageList1.Images.SetKeyName(8, "9.jpg");
            this.imageList1.Images.SetKeyName(9, "10.jpg");
            this.imageList1.Images.SetKeyName(10, "11.jpg");
            this.imageList1.Images.SetKeyName(11, "12.jpg");
            this.imageList1.Images.SetKeyName(12, "13.jpg");
            this.imageList1.Images.SetKeyName(13, "14.jpg");
            this.imageList1.Images.SetKeyName(14, "15.jpg");
            this.imageList1.Images.SetKeyName(15, "16.jpg");
            this.imageList1.Images.SetKeyName(16, "17.jpg");
            this.imageList1.Images.SetKeyName(17, "18.jpg");
            this.imageList1.Images.SetKeyName(18, "19.jpg");
            this.imageList1.Images.SetKeyName(19, "20.jpg");
            this.imageList1.Images.SetKeyName(20, "21.jpg");
            this.imageList1.Images.SetKeyName(21, "22.jpg");
            this.imageList1.Images.SetKeyName(22, "23.jpg");
            this.imageList1.Images.SetKeyName(23, "24.jpg");
            this.imageList1.Images.SetKeyName(24, "25.jpg");
            this.imageList1.Images.SetKeyName(25, "26.jpg");
            this.imageList1.Images.SetKeyName(26, "27.jpg");
            this.imageList1.Images.SetKeyName(27, "28.jpg");
            this.imageList1.Images.SetKeyName(28, "29.jpg");
            this.imageList1.Images.SetKeyName(29, "30.jpg");
            this.imageList1.Images.SetKeyName(30, "31.jpg");
            this.imageList1.Images.SetKeyName(31, "32.jpg");
            this.imageList1.Images.SetKeyName(32, "33.jpg");
            this.imageList1.Images.SetKeyName(33, "34.jpg");
            this.imageList1.Images.SetKeyName(34, "35.jpg");
            this.imageList1.Images.SetKeyName(35, "36.jpg");
            this.imageList1.Images.SetKeyName(36, "37.jpg");
            this.imageList1.Images.SetKeyName(37, "38.jpg");
            this.imageList1.Images.SetKeyName(38, "39.jpg");
            this.imageList1.Images.SetKeyName(39, "40.jpg");
            this.imageList1.Images.SetKeyName(40, "41.jpg");
            this.imageList1.Images.SetKeyName(41, "42.jpg");
            this.imageList1.Images.SetKeyName(42, "43.jpg");
            this.imageList1.Images.SetKeyName(43, "44.jpg");
            this.imageList1.Images.SetKeyName(44, "45.jpg");
            this.imageList1.Images.SetKeyName(45, "46.jpg");
            this.imageList1.Images.SetKeyName(46, "47.jpg");
            this.imageList1.Images.SetKeyName(47, "48.jpg");
            this.imageList1.Images.SetKeyName(48, "49.jpg");
            this.imageList1.Images.SetKeyName(49, "50.jpg");
            this.imageList1.Images.SetKeyName(50, "51.jpg");
            this.imageList1.Images.SetKeyName(51, "52.jpg");
            this.imageList1.Images.SetKeyName(52, "53.jpg");
            this.imageList1.Images.SetKeyName(53, "54.jpg");
            this.imageList1.Images.SetKeyName(54, "55.jpg");
            this.imageList1.Images.SetKeyName(55, "56.jpg");
            this.imageList1.Images.SetKeyName(56, "57.jpg");
            this.imageList1.Images.SetKeyName(57, "58.jpg");
            this.imageList1.Images.SetKeyName(58, "59.jpg");
            this.imageList1.Images.SetKeyName(59, "60.jpg");
            this.imageList1.Images.SetKeyName(60, "61.jpg");
            this.imageList1.Images.SetKeyName(61, "62.jpg");
            this.imageList1.Images.SetKeyName(62, "63.jpg");
            this.imageList1.Images.SetKeyName(63, "64.jpg");
            this.imageList1.Images.SetKeyName(64, "65.jpg");
            this.imageList1.Images.SetKeyName(65, "66.jpg");
            this.imageList1.Images.SetKeyName(66, "67.jpg");
            this.imageList1.Images.SetKeyName(67, "68.jpg");
            this.imageList1.Images.SetKeyName(68, "69.jpg");
            this.imageList1.Images.SetKeyName(69, "70.jpg");
            this.imageList1.Images.SetKeyName(70, "71.jpg");
            this.imageList1.Images.SetKeyName(71, "72.jpg");
            this.imageList1.Images.SetKeyName(72, "73.jpg");
            this.imageList1.Images.SetKeyName(73, "74.jpg");
            this.imageList1.Images.SetKeyName(74, "75.jpg");
            this.imageList1.Images.SetKeyName(75, "76.jpg");
            this.imageList1.Images.SetKeyName(76, "77.jpg");
            this.imageList1.Images.SetKeyName(77, "78.jpg");
            this.imageList1.Images.SetKeyName(78, "79.jpg");
            this.imageList1.Images.SetKeyName(79, "80.jpg");
            this.imageList1.Images.SetKeyName(80, "81.jpg");
            this.imageList1.Images.SetKeyName(81, "82.jpg");
            this.imageList1.Images.SetKeyName(82, "83.jpg");
            this.imageList1.Images.SetKeyName(83, "84.jpg");
            this.imageList1.Images.SetKeyName(84, "85.jpg");
            this.imageList1.Images.SetKeyName(85, "86.jpg");
            this.imageList1.Images.SetKeyName(86, "87.jpg");
            this.imageList1.Images.SetKeyName(87, "88.jpg");
            this.imageList1.Images.SetKeyName(88, "89.jpg");
            this.imageList1.Images.SetKeyName(89, "90.jpg");
            this.imageList1.Images.SetKeyName(90, "91.jpg");
            this.imageList1.Images.SetKeyName(91, "92.jpg");
            this.imageList1.Images.SetKeyName(92, "93.jpg");
            this.imageList1.Images.SetKeyName(93, "94.jpg");
            this.imageList1.Images.SetKeyName(94, "95.jpg");
            this.imageList1.Images.SetKeyName(95, "96.jpg");
            this.imageList1.Images.SetKeyName(96, "97.jpg");
            this.imageList1.Images.SetKeyName(97, "98.jpg");
            this.imageList1.Images.SetKeyName(98, "99.jpg");
            this.imageList1.Images.SetKeyName(99, "100.jpg");
            this.imageList1.Images.SetKeyName(100, "101.jpg");
            this.imageList1.Images.SetKeyName(101, "102.jpg");
            this.imageList1.Images.SetKeyName(102, "103.jpg");
            this.imageList1.Images.SetKeyName(103, "104.jpg");
            this.imageList1.Images.SetKeyName(104, "105.jpg");
            this.imageList1.Images.SetKeyName(105, "106.jpg");
            this.imageList1.Images.SetKeyName(106, "107.jpg");
            this.imageList1.Images.SetKeyName(107, "108.jpg");
            this.imageList1.Images.SetKeyName(108, "109.jpg");
            this.imageList1.Images.SetKeyName(109, "110.jpg");
            this.imageList1.Images.SetKeyName(110, "111.jpg");
            this.imageList1.Images.SetKeyName(111, "112.jpg");
            this.imageList1.Images.SetKeyName(112, "113.jpg");
            this.imageList1.Images.SetKeyName(113, "114.jpg");
            this.imageList1.Images.SetKeyName(114, "115.jpg");
            this.imageList1.Images.SetKeyName(115, "116.jpg");
            this.imageList1.Images.SetKeyName(116, "117.jpg");
            this.imageList1.Images.SetKeyName(117, "118.jpg");
            this.imageList1.Images.SetKeyName(118, "119.jpg");
            this.imageList1.Images.SetKeyName(119, "120.jpg");
            this.imageList1.Images.SetKeyName(120, "121.jpg");
            this.imageList1.Images.SetKeyName(121, "122.jpg");
            this.imageList1.Images.SetKeyName(122, "123.jpg");
            this.imageList1.Images.SetKeyName(123, "124.jpg");
            this.imageList1.Images.SetKeyName(124, "125.jpg");
            this.imageList1.Images.SetKeyName(125, "126.jpg");
            this.imageList1.Images.SetKeyName(126, "127.jpg");
            this.imageList1.Images.SetKeyName(127, "128.jpg");
            this.imageList1.Images.SetKeyName(128, "129.jpg");
            this.imageList1.Images.SetKeyName(129, "130.jpg");
            this.imageList1.Images.SetKeyName(130, "131.jpg");
            this.imageList1.Images.SetKeyName(131, "132.jpg");
            this.imageList1.Images.SetKeyName(132, "133.jpg");
            this.imageList1.Images.SetKeyName(133, "134.jpg");
            this.imageList1.Images.SetKeyName(134, "135.jpg");
            this.imageList1.Images.SetKeyName(135, "136.jpg");
            this.imageList1.Images.SetKeyName(136, "137.jpg");
            this.imageList1.Images.SetKeyName(137, "138.jpg");
            this.imageList1.Images.SetKeyName(138, "139.jpg");
            this.imageList1.Images.SetKeyName(139, "140.jpg");
            this.imageList1.Images.SetKeyName(140, "141.jpg");
            this.imageList1.Images.SetKeyName(141, "142.jpg");
            this.imageList1.Images.SetKeyName(142, "143.jpg");
            this.imageList1.Images.SetKeyName(143, "144.jpg");
            this.imageList1.Images.SetKeyName(144, "145.jpg");
            this.imageList1.Images.SetKeyName(145, "146.jpg");
            this.imageList1.Images.SetKeyName(146, "147.jpg");
            this.imageList1.Images.SetKeyName(147, "148.jpg");
            this.imageList1.Images.SetKeyName(148, "149.jpg");
            this.imageList1.Images.SetKeyName(149, "150.jpg");
            this.imageList1.Images.SetKeyName(150, "151.jpg");
            this.imageList1.Images.SetKeyName(151, "152.jpg");
            this.imageList1.Images.SetKeyName(152, "153.jpg");
            this.imageList1.Images.SetKeyName(153, "154.jpg");
            this.imageList1.Images.SetKeyName(154, "155.jpg");
            this.imageList1.Images.SetKeyName(155, "156.jpg");
            this.imageList1.Images.SetKeyName(156, "157.jpg");
            this.imageList1.Images.SetKeyName(157, "158.jpg");
            this.imageList1.Images.SetKeyName(158, "159.jpg");
            this.imageList1.Images.SetKeyName(159, "160.jpg");
            this.imageList1.Images.SetKeyName(160, "161.jpg");
            this.imageList1.Images.SetKeyName(161, "162.jpg");
            this.imageList1.Images.SetKeyName(162, "163.jpg");
            this.imageList1.Images.SetKeyName(163, "164.jpg");
            this.imageList1.Images.SetKeyName(164, "165.jpg");
            this.imageList1.Images.SetKeyName(165, "166.jpg");
            this.imageList1.Images.SetKeyName(166, "167.jpg");
            this.imageList1.Images.SetKeyName(167, "168.jpg");
            this.imageList1.Images.SetKeyName(168, "169.jpg");
            this.imageList1.Images.SetKeyName(169, "170.jpg");
            this.imageList1.Images.SetKeyName(170, "171.jpg");
            this.imageList1.Images.SetKeyName(171, "172.jpg");
            this.imageList1.Images.SetKeyName(172, "173.jpg");
            this.imageList1.Images.SetKeyName(173, "174.jpg");
            this.imageList1.Images.SetKeyName(174, "175.jpg");
            this.imageList1.Images.SetKeyName(175, "176.jpg");
            this.imageList1.Images.SetKeyName(176, "177.jpg");
            this.imageList1.Images.SetKeyName(177, "178.jpg");
            this.imageList1.Images.SetKeyName(178, "179.jpg");
            this.imageList1.Images.SetKeyName(179, "180.jpg");
            this.imageList1.Images.SetKeyName(180, "181.jpg");
            this.imageList1.Images.SetKeyName(181, "182.jpg");
            this.imageList1.Images.SetKeyName(182, "183.jpg");
            this.imageList1.Images.SetKeyName(183, "184.jpg");
            this.imageList1.Images.SetKeyName(184, "185.jpg");
            this.imageList1.Images.SetKeyName(185, "186.jpg");
            this.imageList1.Images.SetKeyName(186, "187.jpg");
            this.imageList1.Images.SetKeyName(187, "188.jpg");
            this.imageList1.Images.SetKeyName(188, "189.jpg");
            this.imageList1.Images.SetKeyName(189, "190.jpg");
            this.imageList1.Images.SetKeyName(190, "191.jpg");
            this.imageList1.Images.SetKeyName(191, "192.jpg");
            this.imageList1.Images.SetKeyName(192, "193.jpg");
            this.imageList1.Images.SetKeyName(193, "194.jpg");
            this.imageList1.Images.SetKeyName(194, "195.jpg");
            this.imageList1.Images.SetKeyName(195, "196.jpg");
            this.imageList1.Images.SetKeyName(196, "197.jpg");
            this.imageList1.Images.SetKeyName(197, "198.jpg");
            this.imageList1.Images.SetKeyName(198, "199.jpg");
            this.imageList1.Images.SetKeyName(199, "200.jpg");
            this.imageList1.Images.SetKeyName(200, "201.jpg");
            this.imageList1.Images.SetKeyName(201, "202.jpg");
            this.imageList1.Images.SetKeyName(202, "203.jpg");
            this.imageList1.Images.SetKeyName(203, "204.jpg");
            this.imageList1.Images.SetKeyName(204, "205.jpg");
            this.imageList1.Images.SetKeyName(205, "206.jpg");
            this.imageList1.Images.SetKeyName(206, "207.jpg");
            this.imageList1.Images.SetKeyName(207, "208.jpg");
            this.imageList1.Images.SetKeyName(208, "209.jpg");
            this.imageList1.Images.SetKeyName(209, "210.jpg");
            this.imageList1.Images.SetKeyName(210, "211.jpg");
            this.imageList1.Images.SetKeyName(211, "212.jpg");
            this.imageList1.Images.SetKeyName(212, "213.jpg");
            this.imageList1.Images.SetKeyName(213, "214.jpg");
            this.imageList1.Images.SetKeyName(214, "215.jpg");
            this.imageList1.Images.SetKeyName(215, "216.jpg");
            this.imageList1.Images.SetKeyName(216, "217.jpg");
            this.imageList1.Images.SetKeyName(217, "218.jpg");
            this.imageList1.Images.SetKeyName(218, "219.jpg");
            this.imageList1.Images.SetKeyName(219, "220.jpg");
            this.imageList1.Images.SetKeyName(220, "221.jpg");
            this.imageList1.Images.SetKeyName(221, "222.jpg");
            this.imageList1.Images.SetKeyName(222, "223.jpg");
            this.imageList1.Images.SetKeyName(223, "224.jpg");
            this.imageList1.Images.SetKeyName(224, "225.jpg");
            this.imageList1.Images.SetKeyName(225, "226.jpg");
            this.imageList1.Images.SetKeyName(226, "227.jpg");
            this.imageList1.Images.SetKeyName(227, "228.jpg");
            this.imageList1.Images.SetKeyName(228, "229.jpg");
            this.imageList1.Images.SetKeyName(229, "230.jpg");
            this.imageList1.Images.SetKeyName(230, "231.jpg");
            this.imageList1.Images.SetKeyName(231, "232.jpg");
            this.imageList1.Images.SetKeyName(232, "233.jpg");
            this.imageList1.Images.SetKeyName(233, "234.jpg");
            this.imageList1.Images.SetKeyName(234, "235.jpg");
            this.imageList1.Images.SetKeyName(235, "236.jpg");
            this.imageList1.Images.SetKeyName(236, "237.jpg");
            this.imageList1.Images.SetKeyName(237, "238.jpg");
            this.imageList1.Images.SetKeyName(238, "239.jpg");
            this.imageList1.Images.SetKeyName(239, "240.jpg");
            this.imageList1.Images.SetKeyName(240, "241.jpg");
            this.imageList1.Images.SetKeyName(241, "242.jpg");
            this.imageList1.Images.SetKeyName(242, "243.jpg");
            this.imageList1.Images.SetKeyName(243, "244.jpg");
            this.imageList1.Images.SetKeyName(244, "245.jpg");
            this.imageList1.Images.SetKeyName(245, "246.jpg");
            this.imageList1.Images.SetKeyName(246, "247.jpg");
            this.imageList1.Images.SetKeyName(247, "248.jpg");
            this.imageList1.Images.SetKeyName(248, "249.jpg");
            this.imageList1.Images.SetKeyName(249, "250.jpg");
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 461);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "随机电影推荐";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.End)).EndInit();
            this.Top250.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Top250;
        private System.Windows.Forms.DataGridView End;
        private System.Windows.Forms.DataGridView dataGridView1;
        private M m;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private MTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn topDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label star;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label cuuntry;
        private System.Windows.Forms.Label review;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label top;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

