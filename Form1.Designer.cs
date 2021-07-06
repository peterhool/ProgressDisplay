
namespace ProgressDisplay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DrawingNumbers = new System.Windows.Forms.Label();
            this.ProcessingState = new System.Windows.Forms.Label();
            this.WorkStatus = new System.Windows.Forms.ComboBox();
            this.RemarkInfomation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonWriteData = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CompanyName1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ResearchRole = new System.Windows.Forms.GroupBox();
            this.ButtonResearch = new System.Windows.Forms.Button();
            this.DrawingNumber2 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.CompanyName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonAllInfo = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ResearchRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(405, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(470, 42);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DrawingNumbers
            // 
            this.DrawingNumbers.AutoSize = true;
            this.DrawingNumbers.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DrawingNumbers.Location = new System.Drawing.Point(216, 155);
            this.DrawingNumbers.Name = "DrawingNumbers";
            this.DrawingNumbers.Size = new System.Drawing.Size(124, 28);
            this.DrawingNumbers.TabIndex = 2;
            this.DrawingNumbers.Text = "图纸编号";
            // 
            // ProcessingState
            // 
            this.ProcessingState.AutoSize = true;
            this.ProcessingState.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ProcessingState.Location = new System.Drawing.Point(216, 234);
            this.ProcessingState.Name = "ProcessingState";
            this.ProcessingState.Size = new System.Drawing.Size(124, 28);
            this.ProcessingState.TabIndex = 3;
            this.ProcessingState.Text = "加工状态";
            // 
            // WorkStatus
            // 
            this.WorkStatus.BackColor = System.Drawing.SystemColors.Info;
            this.WorkStatus.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WorkStatus.FormattingEnabled = true;
            this.WorkStatus.Items.AddRange(new object[] {
            "",
            "未买料",
            "有料未加工",
            "在加工",
            "半成品加工完成",
            "半成品外发",
            "成品入库"});
            this.WorkStatus.Location = new System.Drawing.Point(405, 234);
            this.WorkStatus.Name = "WorkStatus";
            this.WorkStatus.Size = new System.Drawing.Size(470, 35);
            this.WorkStatus.TabIndex = 4;
            // 
            // RemarkInfomation
            // 
            this.RemarkInfomation.BackColor = System.Drawing.SystemColors.Info;
            this.RemarkInfomation.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RemarkInfomation.Location = new System.Drawing.Point(221, 338);
            this.RemarkInfomation.Multiline = true;
            this.RemarkInfomation.Name = "RemarkInfomation";
            this.RemarkInfomation.Size = new System.Drawing.Size(831, 203);
            this.RemarkInfomation.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(564, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "备注信息";
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.DarkSalmon;
            this.ButtonExit.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonExit.Location = new System.Drawing.Point(281, 566);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(172, 50);
            this.ButtonExit.TabIndex = 7;
            this.ButtonExit.Text = "退出系统";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonWriteData
            // 
            this.ButtonWriteData.BackColor = System.Drawing.Color.Chartreuse;
            this.ButtonWriteData.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonWriteData.Location = new System.Drawing.Point(544, 566);
            this.ButtonWriteData.Name = "ButtonWriteData";
            this.ButtonWriteData.Size = new System.Drawing.Size(218, 50);
            this.ButtonWriteData.TabIndex = 8;
            this.ButtonWriteData.Text = "提交信息";
            this.ButtonWriteData.UseVisualStyleBackColor = false;
            this.ButtonWriteData.Click += new System.EventHandler(this.ButtonWriteData_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1245, 742);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage1.Controls.Add(this.ButtonReset);
            this.tabPage1.Controls.Add(this.CompanyName1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.DrawingNumbers);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.ButtonWriteData);
            this.tabPage1.Controls.Add(this.ProcessingState);
            this.tabPage1.Controls.Add(this.ButtonExit);
            this.tabPage1.Controls.Add(this.WorkStatus);
            this.tabPage1.Controls.Add(this.RemarkInfomation);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1237, 713);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // CompanyName1
            // 
            this.CompanyName1.BackColor = System.Drawing.SystemColors.Info;
            this.CompanyName1.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CompanyName1.FormattingEnabled = true;
            this.CompanyName1.Items.AddRange(new object[] {
            "",
            "线缆厂",
            "自动化"});
            this.CompanyName1.Location = new System.Drawing.Point(405, 88);
            this.CompanyName1.Name = "CompanyName1";
            this.CompanyName1.Size = new System.Drawing.Size(470, 35);
            this.CompanyName1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(218, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "公司名称";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.ResearchRole);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1237, 713);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(905, 707);
            this.dataGridView1.TabIndex = 6;
            // 
            // ResearchRole
            // 
            this.ResearchRole.BackColor = System.Drawing.Color.LightSalmon;
            this.ResearchRole.Controls.Add(this.label7);
            this.ResearchRole.Controls.Add(this.label5);
            this.ResearchRole.Controls.Add(this.ButtonClear);
            this.ResearchRole.Controls.Add(this.ButtonAllInfo);
            this.ResearchRole.Controls.Add(this.ButtonResearch);
            this.ResearchRole.Controls.Add(this.DrawingNumber2);
            this.ResearchRole.Controls.Add(this.monthCalendar1);
            this.ResearchRole.Controls.Add(this.CompanyName);
            this.ResearchRole.Controls.Add(this.label2);
            this.ResearchRole.Controls.Add(this.label3);
            this.ResearchRole.Controls.Add(this.label6);
            this.ResearchRole.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResearchRole.Location = new System.Drawing.Point(6, 6);
            this.ResearchRole.Name = "ResearchRole";
            this.ResearchRole.Size = new System.Drawing.Size(353, 701);
            this.ResearchRole.TabIndex = 5;
            this.ResearchRole.TabStop = false;
            this.ResearchRole.Text = "查询条件";
            // 
            // ButtonResearch
            // 
            this.ButtonResearch.BackColor = System.Drawing.Color.Chartreuse;
            this.ButtonResearch.Location = new System.Drawing.Point(25, 551);
            this.ButtonResearch.Name = "ButtonResearch";
            this.ButtonResearch.Size = new System.Drawing.Size(154, 41);
            this.ButtonResearch.TabIndex = 6;
            this.ButtonResearch.Text = "条件查询";
            this.ButtonResearch.UseVisualStyleBackColor = false;
            this.ButtonResearch.Click += new System.EventHandler(this.ButtonResearch_Click);
            // 
            // DrawingNumber2
            // 
            this.DrawingNumber2.Location = new System.Drawing.Point(25, 502);
            this.DrawingNumber2.Name = "DrawingNumber2";
            this.DrawingNumber2.Size = new System.Drawing.Size(262, 34);
            this.DrawingNumber2.TabIndex = 7;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(29, 207);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // CompanyName
            // 
            this.CompanyName.FormattingEnabled = true;
            this.CompanyName.Items.AddRange(new object[] {
            "",
            "线缆厂",
            "自动化"});
            this.CompanyName.Location = new System.Drawing.Point(26, 124);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(267, 31);
            this.CompanyName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "公司名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "图纸编号查询";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "日期查询";
            // 
            // ButtonReset
            // 
            this.ButtonReset.BackColor = System.Drawing.Color.Red;
            this.ButtonReset.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonReset.Location = new System.Drawing.Point(850, 566);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(152, 50);
            this.ButtonReset.TabIndex = 11;
            this.ButtonReset.Text = "清空";
            this.ButtonReset.UseVisualStyleBackColor = false;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonAllInfo
            // 
            this.ButtonAllInfo.BackColor = System.Drawing.Color.Snow;
            this.ButtonAllInfo.Location = new System.Drawing.Point(26, 598);
            this.ButtonAllInfo.Name = "ButtonAllInfo";
            this.ButtonAllInfo.Size = new System.Drawing.Size(153, 33);
            this.ButtonAllInfo.TabIndex = 8;
            this.ButtonAllInfo.Text = "全部记录";
            this.ButtonAllInfo.UseVisualStyleBackColor = false;
            this.ButtonAllInfo.Click += new System.EventHandler(this.ButtonAllInfo_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.Red;
            this.ButtonClear.Location = new System.Drawing.Point(193, 552);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 79);
            this.ButtonClear.TabIndex = 9;
            this.ButtonClear.Text = "清空";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "当前选择日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1304, 766);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "工作进度展示";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResearchRole.ResumeLayout(false);
            this.ResearchRole.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label DrawingNumbers;
        private System.Windows.Forms.Label ProcessingState;
        private System.Windows.Forms.ComboBox WorkStatus;
        private System.Windows.Forms.TextBox RemarkInfomation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonWriteData;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox ResearchRole;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox CompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DrawingNumber2;
        private System.Windows.Forms.Button ButtonResearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CompanyName1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonAllInfo;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

