using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StampTaxHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();        
             
            //comboBox1.Items.Add(new MyItem("機車"));
            //comboBox1.Items.Add(new MyItem("貨車"));
            //comboBox1.Items.Add(new MyItem("大客車"));
            //comboBox1.Items.Add(new MyItem("自用小客車"));
            //comboBox1.Items.Add(new MyItem("營業用小客車"));           
        }

        //struct MyItem
        //{
        //    public MyItem(string displayName)
        //    {
        //        DisplayName = displayName;               
        //    }
        //    public string DisplayName { get; set; }

        //    public override string ToString()
        //    {
        //        return DisplayName;
        //    }
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)   //只是為了跳不同選項
        {
            //comboBox2.Text = ((MyItem)comboBox1.SelectedItem).DisplayName;
            //comboBox2.Items.Add("100CC");
            //comboBox2.Items.Add("123423354656");

            if (comboBox1.Text == "機車")
            {
                comboBox2.Items.Add("150 以下");
                comboBox2.Items.Add("151cc~ 250cc");
                comboBox2.Items.Add("251cc~ 500cc");
                comboBox2.Items.Add("501cc~ 600cc");
                comboBox2.Items.Add("1201cc~1800cc");
                comboBox2.Items.Add("1801cc 以上");                
            }
           else if (comboBox1.Text == "貨車" || comboBox1.Text == "大客車")
            {
                comboBox2.Items.Add("500cc 以下");
                comboBox2.Items.Add("501cc - 600cc");
                comboBox2.Items.Add("601cc - 1200cc	");
                comboBox2.Items.Add("1201cc - 1800cc");
                comboBox2.Items.Add("1801cc - 2400cc");
                comboBox2.Items.Add("2401cc - 3000cc");
                comboBox2.Items.Add("3001cc~3600cc");
                comboBox2.Items.Add("3601cc~4200cc");
                comboBox2.Items.Add("4201cc~4800cc");
                comboBox2.Items.Add("4801cc~5400cc");
                comboBox2.Items.Add("5401cc~6000cc");
                comboBox2.Items.Add("6001cc~6600cc");
                comboBox2.Items.Add("6601cc~7200cc");
                comboBox2.Items.Add("7201cc~7800cc");
                comboBox2.Items.Add("7801cc~8400cc");
                comboBox2.Items.Add("8401cc~9000cc");
                comboBox2.Items.Add("9001cc~9600cc");
                comboBox2.Items.Add("9601cc~10200cc");
                comboBox2.Items.Add("10201cc 以上");              
            }
            else if (comboBox1.Text == "自用小客車" || comboBox1.Text == "營業用小客車")
            {
                comboBox2.Items.Add("500cc 以下");
                comboBox2.Items.Add("501cc - 600cc");
                comboBox2.Items.Add("601cc - 1200cc");
                comboBox2.Items.Add("1201cc - 1800cc");
                comboBox2.Items.Add("1801cc - 2400cc");
                comboBox2.Items.Add("2401cc - 3000cc");
                comboBox2.Items.Add("3001cc - 4200cc");
                comboBox2.Items.Add("4201cc - 5400cc");
                comboBox2.Items.Add("5401cc - 6600cc");
                comboBox2.Items.Add("6601cc - 7800cc");
                comboBox2.Items.Add("7801cc 以上");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Items()
        {
            this.comboBox2.Items.Add("150 / 12HP以下(12.5PS以下)");
            this.comboBox2.Items.Add("151-250 / 12.1-20HP(12.0-20.3PS)");
            this.comboBox2.Items.Add("251-500 /20.1以上(20.4PS以上)");
            this.comboBox2.Items.Add("501-600");
            this.comboBox2.Items.Add("601-1200");
            this.comboBox2.Items.Add("1801或以上");
        }

        private void Items2()
        {
            this.comboBox2.Items.Add("500cc 以下");
            this.comboBox2.Items.Add("501cc - 600cc");
            this.comboBox2.Items.Add("601cc - 1200cc");
            this.comboBox2.Items.Add("1801cc - 2400cc");
            this.comboBox2.Items.Add("2401cc - 3000cc");
            this.comboBox2.Items.Add("3001cc~3600cc");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Init();
            this.comboBox1.Enabled = true;
            this.comboBox2.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //顯示日期
            this.label6.Text = "從";
            this.label7.Text = "到 ";
            this.dateTimePicker1.Visible = true;
            this.dateTimePicker2.Visible = true;
            this.comboBox1.Enabled = true;
            this.comboBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Init();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //算式
            this.label1.Text = 
                $"使用期間:\r\n" +
                $"計算天數:  \r\n" +
                $"汽缸CC數: \r\n用途: \r\n" +
                $"計算公式: \r\n" +
                $"應納稅額: 共  元";
        }

        private double GetTaxPercentage()
        {
            string taxType = this.comboBox2.Text;  //判斷下拉選單選到的項目

            switch (taxType)                       //當選到甚麼字就回傳多少
            {
                case "150cc 以下": return 0;
                case "151cc~ 250cc": return 800;
                case "251cc~ 500cc": return 1620;
                case "501cc~ 600cc": return 2160;
                case "601cc~1200cc": return 4320;
                case "1201cc~1800cc": return 7120;
                case "1801cc 以上": return 11230;
                default:return 0;
            }
        }

        private void Init()
        {
            this.comboBox1.Text = " ";
            this.comboBox2.Text = " ";
            this.comboBox1.Enabled = false;
            this.comboBox2.Enabled = false;
            this.label6.Text = " ";
            this.label7.Text = " ";
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker2.Visible = false;
            this.label1.Text = " ";
        }
    }
}
