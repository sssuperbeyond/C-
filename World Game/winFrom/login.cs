using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
using World_Game.sql;

namespace World_Game
{
    public partial class login : Form
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public login()
        {
            InitializeComponent();
        }

        private void code_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            ArrayList codelist = new ArrayList();
            for (char i = 'a'; i <= 'z'; i++)
            {
                codelist.Add(i.ToString());
            }
            for (char i = 'A'; i <= 'Z'; i++)
            {
                codelist.Add(i.ToString());
            }
            for (int i = 0; i <= 9; i++)
            {
                codelist.Add(i.ToString());
            }
            string strcode = "";
            //随机获取4个验证码
            for (int i = 0; i < 4; i++)
            {
                int index = ran.Next(0, codelist.Count);
                strcode += codelist[index];
            }
            this.code.Text = strcode;
        }

        //登录按钮事件
        int error = 1;        //记录登录出错的次数
        Boolean codeverify = false;     //验证码没有出现为false,出现了为true
        string emailstr = "";
        string passstr = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string id = config.AppSettings.Settings["id"].Value;
            if (id.Equals("0"))
            {
                emailstr = this.email.Text;
                passstr = this.pass.Text;
            }
            //当没有验证码时进入
            if (!codeverify)
            {
                if (loginVerify(emailstr, passstr))
                {
                    staff sta = new staff();
                    sevenLogin();
                    sta.Show();
                    this.Hide();
                }
                else
                {
                    if (error >= 3)
                    {
                        this.label5.Visible = true;
                        this.vc.Visible = true;
                        this.code.Visible = true;
                        this.code.PerformClick();
                        codeverify = true;
                    }
                    error++;
                }
            }
            //验证码出现时进入
            else
            {
                if (loginVerify(emailstr, passstr) && this.vc.Text.ToUpper().Equals(this.code.Text.ToUpper()))
                {
                    sevenLogin();
                    staff sta = new staff();
                    sta.Show();
                    this.Hide();
                }
            }
            
        }

        //登录验证
        public Boolean loginVerify(string email, string pass) {
            DBUtil db = new DBUtil();
            string passstr = db.queryByName(email);
            if (passstr.Equals(""))
            {
                return false;
            }
            else
            {
                if (pass.Equals(passstr))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        //7天内自动登录功能配置
        public void sevenLogin() {
            //登录成功且选中
            if (this.auto.Checked)
            {
                //将当前date,email和pass设置进去,并且设置id为1
                config.AppSettings.Settings["Date"].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                config.AppSettings.Settings["email"].Value = this.email.Text;
                config.AppSettings.Settings["pass"].Value = this.pass.Text;
                config.AppSettings.Settings["id"].Value = "1";
                config.Save();
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        //自动登录功能
        public void auto_login() {
            string id = config.AppSettings.Settings["id"].Value;
            //获取当前时间与当初设置7天自动登录的时间的间隔毫秒
            string dt = config.AppSettings.Settings["Date"].Value;
            double time = 0;
            try
            {
                time = DateTime.Now.Subtract(DateTime.Parse(dt)).TotalDays;
            }
            catch (Exception e)
            {
            }
            //id为1时且time<7天时,自动填充保存下来的email和pass,并登录
            if (id.Equals("1") && time <= 7)
            {
                emailstr = config.AppSettings.Settings["email"].Value;
                passstr = config.AppSettings.Settings["pass"].Value;
                this.loginbu.PerformClick();

            }
            else
            {
                config.AppSettings.Settings["Date"].Value = "";
                config.AppSettings.Settings["email"].Value = "";
                config.AppSettings.Settings["pass"].Value = "";
                config.AppSettings.Settings["id"].Value = "0";
                config.Save();
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        //在窗口加载完成后调用此方法
        private void login_Activated(object sender, EventArgs e)
        {
            auto_login();
        }

        //close事件
        private void closebu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
