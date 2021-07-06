using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ProgressDisplay
{
    public partial class Form1 : Form
    {

        private string currenttime = string.Empty;
        
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.AutoResizeColumns();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tabPage1.Text = "输入信息";
            this.tabPage2.Text = "查询信息";
            this.monthCalendar1.DateSelected += SelectLocalDate;

            /*禁止下拉框数据输入*/
            this.CompanyName.DropDownStyle = ComboBoxStyle.DropDownList;
            this.CompanyName1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.WorkStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            
            /*设置当前 时间Label*/
            this.label7.Text= this.monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void ButtonWriteData_Click(object sender, EventArgs e)
        {
            

            string connstr = "server = 127.0.0.1; database =factory_manage ; userid = root; password = 123456;";

            if(this.CompanyName1.Text.Length==0)
            {
                MessageBox.Show("请填写公司名称");
                return;
            }

            if(this.WorkStatus.Text.Length==0)
            {
                MessageBox.Show("请填写当前状态");
                return;
            }

            if((this.textBox1.Text.Length==0 && this.WorkStatus.Text!="未买料") ||(this.textBox1.Text.Length != 0 && this.WorkStatus.Text == "未买料"))
            {
                MessageBox.Show("信息不合法，既然已经买料，必须填写图纸编号");
                return;
            }

            int ret=this.WriteDatabase(connstr,this.CompanyName1.Text,this.textBox1.Text,this.WorkStatus.Text,this.RemarkInfomation.Text);
            if(ret==1)
            {
                MessageBox.Show("成功添加一条记录");
            }
            else if(ret==2)
            {
                MessageBox.Show("成功修改一条记录");
            }
        }


        

        #region 写入数据库数据

        public int WriteDatabase(string connectstring,string companyname,string drawingnumber, string workingstatus,string remarkinfo)
        {
            int affect_row = 0;
            MySqlConnection sqlconn = new MySqlConnection(connectstring);
            string current_time = DateTime.Now.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                sqlconn.Open();
            }catch(MySqlException ex)
            {
                MessageBox.Show("连接数据库失败:{0}",ex.ToString());
                return -1;
            }

            

            try
            {
                //判读待插入数据是否存在

                bool isExsit = false;
                
                MySqlCommand sqlcommand = new MySqlCommand();
                sqlcommand.Connection = sqlconn;

                sqlcommand.CommandText = string.Format("select count(*) from table_progress_display where drawing_number='{0}';", drawingnumber);

                
                int counter=int.Parse(sqlcommand.ExecuteScalar().ToString());
                //Console.WriteLine("counter=="+counter);
                
                if(counter==1)
                {
                    isExsit = true;
                    //Console.WriteLine("存在："+isExsit);
                }

                if(isExsit==true)
                {//数据存在,修改数据
                    sqlcommand.CommandText = string.Format("update table_progress_display set working_state='{0}',remark_information='{1}',commit_time='{2}' where drawing_number='{3}'", workingstatus,remarkinfo, current_time, drawingnumber);

                    sqlcommand.ExecuteNonQuery();
                    affect_row = 2;
                }

                else
                {//数据不存在，添加数据
                   sqlcommand.CommandText = string.Format("insert into table_progress_display(company_name,drawing_number,working_state, remark_information,commit_time) values('{0}','{1}','{2}','{3}','{4}')", companyname, drawingnumber,workingstatus,remarkinfo, current_time);
                   sqlcommand.ExecuteNonQuery();
                   affect_row = 1;
                }
                

                //affect_row= sqlcommand.ExecuteNonQuery();
               
                
            }catch(MySqlException ex)
            {
                
                MessageBox.Show(string.Format("写入数据库失败:{0}",ex.ToString()));
                
            }

            sqlconn.Close();
            return affect_row;
        }
        #endregion

        #region 查询数据库

        private DataSet QueryFromDatabase(string connstr,string sql)
        {
            MySqlConnection connection = new MySqlConnection(connstr);
            DataSet ds = new DataSet();
            try
            {
                connection.Open();
            } catch (MySqlException ex)
            {
                MessageBox.Show("数据库未成功连接:"+ex.ToString());
            }
            try
            {
                MySqlDataAdapter sqladapt = new MySqlDataAdapter(sql,connstr);
                
                sqladapt.Fill(ds, "table_progress_display");
               
                connection.Close();
            }catch(MySqlException ex)
            {  
                MessageBox.Show("MySqlDataAdapter适配器发生错误:"+ex.ToString());
            }

            return ds;
        }

        #endregion


        #region 查询信息
        private void ButtonResearch_Click(object sender, EventArgs e)
        {
            string connstr = "server=127.0.0.1;database=factory_manage;userid=root;password=123456;";
            

            string sql = string.Empty;
            
            /*------------------------------------------查询语句------------------------------------------------------*/

            string company_name=(this.CompanyName.Text.Length == 0) ? "%" : this.CompanyName.Text;
            string drawing_number = (this.DrawingNumber2.Text.Length == 0) ? "%" : this.DrawingNumber2.Text;
            string select_date = (this.currenttime.Length == 0) ? "%" : this.currenttime;
            
            sql = string.Format("select id, company_name as 部门名称 ,drawing_number 图纸编号 ,working_state as 加工状态,remark_information as 备注信息 ,commit_time as 提交时间 from table_progress_display where company_name like '{0}' and commit_time like '{1}%' and drawing_number like '{2}'", company_name,select_date,drawing_number);
            /*------------------------------------------查询语句------------------------------------------------------*/


            DataSet ds = QueryFromDatabase(connstr,sql);
            try
            {
                this.dataGridView1.DataSource = ds.Tables["table_progress_display"];
            }catch(MySqlException ex)
            {
            Console.WriteLine("数据集发生错误:" + ex.ToString());
            }
        }
        #endregion

        #region 日期选择
        private void SelectLocalDate(object sender, DateRangeEventArgs e)
        {
           this. currenttime = this.monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
           this.label7.Text= this.currenttime;
           
        }
        #endregion

        private void ButtonReset_Click(object sender, EventArgs e)
        {
           
            this.textBox1.Text = string.Empty;
            
            this.RemarkInfomation.Text = string.Empty;
        }

        private void ButtonAllInfo_Click(object sender, EventArgs e)
        {
            string sql = "select id, company_name as 部门名称 ,drawing_number 图纸编号 ,working_state as 加工状态,remark_information as 备注信息 ,commit_time as 提交时间 from table_progress_display;";
            string connstr = "server=127.0.0.1;database=factory_manage;userid=root;password=123456;";
            DataSet ds = QueryFromDatabase(connstr, sql);
            try
            {
                this.dataGridView1.DataSource = ds.Tables["table_progress_display"];
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("数据集发生错误:" + ex.ToString());
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.CompanyName.Text = string.Empty;
            this.DrawingNumber2.Text = string.Empty;
            this.currenttime = "%";
        }
    }
}
