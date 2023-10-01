namespace WebBrowser.Cef
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbExamType = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelExamNo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbExamName = new System.Windows.Forms.Label();
            this.tbExamName = new System.Windows.Forms.TextBox();
            this.cbExamSex = new System.Windows.Forms.ComboBox();
            this.lbExamAge = new System.Windows.Forms.Label();
            this.tbExamAge = new System.Windows.Forms.TextBox();
            this.lbExamIdcardNo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.lbExamType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.lbExamType);
            this.splitContainer1.Size = new System.Drawing.Size(984, 561);
            this.splitContainer1.SplitterDistance = 35;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbExamType);
            this.flowLayoutPanel1.Controls.Add(this.labelDate);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePicker);
            this.flowLayoutPanel1.Controls.Add(this.labelExamNo);
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Controls.Add(this.lbExamName);
            this.flowLayoutPanel1.Controls.Add(this.tbExamName);
            this.flowLayoutPanel1.Controls.Add(this.cbExamSex);
            this.flowLayoutPanel1.Controls.Add(this.lbExamAge);
            this.flowLayoutPanel1.Controls.Add(this.tbExamAge);
            this.flowLayoutPanel1.Controls.Add(this.lbExamIdcardNo);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.btnSearch);
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnSet);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(984, 35);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // cbExamType
            // 
            this.cbExamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExamType.FormattingEnabled = true;
            this.cbExamType.Location = new System.Drawing.Point(3, 5);
            this.cbExamType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cbExamType.Name = "cbExamType";
            this.cbExamType.Size = new System.Drawing.Size(80, 20);
            this.cbExamType.TabIndex = 40;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(89, 4);
            this.labelDate.Margin = new System.Windows.Forms.Padding(3, 4, 0, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelDate.Size = new System.Drawing.Size(29, 22);
            this.labelDate.TabIndex = 45;
            this.labelDate.Text = "日期";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(121, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker.TabIndex = 46;
            // 
            // labelExamNo
            // 
            this.labelExamNo.AutoSize = true;
            this.labelExamNo.Location = new System.Drawing.Point(227, 4);
            this.labelExamNo.Margin = new System.Windows.Forms.Padding(3, 4, 0, 0);
            this.labelExamNo.Name = "labelExamNo";
            this.labelExamNo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.labelExamNo.Size = new System.Drawing.Size(41, 22);
            this.labelExamNo.TabIndex = 43;
            this.labelExamNo.Text = "体检号";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(268, 5);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0, 5, 3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 21);
            this.textBox2.TabIndex = 44;
            this.textBox2.Text = "2207311234";
            // 
            // lbExamName
            // 
            this.lbExamName.AutoSize = true;
            this.lbExamName.Location = new System.Drawing.Point(354, 4);
            this.lbExamName.Margin = new System.Windows.Forms.Padding(3, 4, 0, 0);
            this.lbExamName.Name = "lbExamName";
            this.lbExamName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbExamName.Size = new System.Drawing.Size(29, 22);
            this.lbExamName.TabIndex = 36;
            this.lbExamName.Text = "姓名";
            // 
            // tbExamName
            // 
            this.tbExamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbExamName.Location = new System.Drawing.Point(383, 5);
            this.tbExamName.Margin = new System.Windows.Forms.Padding(0, 5, 3, 3);
            this.tbExamName.Name = "tbExamName";
            this.tbExamName.Size = new System.Drawing.Size(80, 21);
            this.tbExamName.TabIndex = 35;
            this.tbExamName.Text = "默认五个字";
            // 
            // cbExamSex
            // 
            this.cbExamSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExamSex.FormattingEnabled = true;
            this.cbExamSex.Location = new System.Drawing.Point(469, 5);
            this.cbExamSex.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cbExamSex.Name = "cbExamSex";
            this.cbExamSex.Size = new System.Drawing.Size(40, 20);
            this.cbExamSex.TabIndex = 41;
            // 
            // lbExamAge
            // 
            this.lbExamAge.AutoSize = true;
            this.lbExamAge.Location = new System.Drawing.Point(515, 4);
            this.lbExamAge.Margin = new System.Windows.Forms.Padding(3, 4, 0, 0);
            this.lbExamAge.Name = "lbExamAge";
            this.lbExamAge.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbExamAge.Size = new System.Drawing.Size(29, 22);
            this.lbExamAge.TabIndex = 37;
            this.lbExamAge.Text = "年龄";
            // 
            // tbExamAge
            // 
            this.tbExamAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbExamAge.Location = new System.Drawing.Point(544, 5);
            this.tbExamAge.Margin = new System.Windows.Forms.Padding(0, 5, 3, 3);
            this.tbExamAge.Name = "tbExamAge";
            this.tbExamAge.Size = new System.Drawing.Size(50, 21);
            this.tbExamAge.TabIndex = 38;
            this.tbExamAge.Text = "65-70";
            this.tbExamAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbExamIdcardNo
            // 
            this.lbExamIdcardNo.AutoSize = true;
            this.lbExamIdcardNo.Location = new System.Drawing.Point(600, 4);
            this.lbExamIdcardNo.Margin = new System.Windows.Forms.Padding(3, 4, 0, 0);
            this.lbExamIdcardNo.Name = "lbExamIdcardNo";
            this.lbExamIdcardNo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbExamIdcardNo.Size = new System.Drawing.Size(29, 22);
            this.lbExamIdcardNo.TabIndex = 39;
            this.lbExamIdcardNo.Text = "证件";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(629, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 5, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 21);
            this.textBox1.TabIndex = 42;
            this.textBox1.Text = "370831195505051239";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(760, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 23);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "检索";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(816, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 23);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(872, 3);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(58, 23);
            this.btnSet.TabIndex = 34;
            this.btnSet.Text = "配置(&S)";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lbExamType
            // 
            this.lbExamType.AutoSize = true;
            this.lbExamType.Location = new System.Drawing.Point(-75, 7);
            this.lbExamType.Margin = new System.Windows.Forms.Padding(3, 4, 0, 0);
            this.lbExamType.Name = "lbExamType";
            this.lbExamType.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lbExamType.Size = new System.Drawing.Size(29, 22);
            this.lbExamType.TabIndex = 19;
            this.lbExamType.Text = "类型";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "WebBrowser.Cef";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbExamType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbExamType;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelExamNo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbExamName;
        private System.Windows.Forms.TextBox tbExamName;
        private System.Windows.Forms.ComboBox cbExamSex;
        private System.Windows.Forms.Label lbExamAge;
        private System.Windows.Forms.TextBox tbExamAge;
        private System.Windows.Forms.Label lbExamIdcardNo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSet;
    }
}

