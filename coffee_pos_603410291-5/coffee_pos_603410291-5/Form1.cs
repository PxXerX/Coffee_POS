using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_pos_603410291_5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Americano"); comboBox1.Items.Add("Cappuccino"); comboBox1.Items.Add("CoCoa");
            comboBox1.Items.Add("Esspresso"); comboBox1.Items.Add("GreenTea"); comboBox1.Items.Add("Honey lime Soda");
            comboBox1.Items.Add("Italian Soda"); comboBox1.Items.Add("Latte"); comboBox1.Items.Add("LemonTea");
            comboBox1.Items.Add("Milk"); comboBox1.Items.Add("Milo"); comboBox1.Items.Add("MilkTea");
            comboBox1.Items.Add("Mocha"); comboBox1.Items.Add("Neascafe"); comboBox1.Items.Add("NeasTea");
            comboBox1.Items.Add("Red lime Soda"); comboBox1.Items.Add("ThaiTea");

            comboBox2.Items.Add("Hot"); comboBox2.Items.Add("Ice"); comboBox2.Items.Add("Frappe");

            comboBox3.Items.Add("1"); comboBox3.Items.Add("2"); comboBox3.Items.Add("3"); comboBox3.Items.Add("4"); comboBox3.Items.Add("5");
            comboBox3.Items.Add("6"); comboBox3.Items.Add("7"); comboBox3.Items.Add("8"); comboBox3.Items.Add("9"); comboBox3.Items.Add("10");
            comboBox3.Items.Add("11"); comboBox3.Items.Add("12"); comboBox3.Items.Add("13"); comboBox3.Items.Add("14"); comboBox3.Items.Add("15");
            comboBox3.Items.Add("16"); comboBox3.Items.Add("17"); comboBox3.Items.Add("18"); comboBox3.Items.Add("19"); comboBox3.Items.Add("20");

        }
        int c = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(comboBox3.Text);
                int p;
                switch (comboBox1.Text)
                {
                    case "Americano":
                        switch (comboBox2.Text)
                        {
                            case "Hot":
                                p = num * 35;
                                textBox1.Text += " Hot Americano       " + num + "             " + p + "  Bath" + "\r\n";
                                c += p;
                                textBox2.Text = c.ToString();break;
                                
                            case "Ice":
                                p = num * 45;
                                textBox1.Text += " Ice Americano       " + num + "             " + p + "   Bath" + "\r\n"; ;
                                c += p;
                                textBox2.Text = c.ToString();break;
                                
                            default: MessageBox.Show("ขอโทษค่ะ เมนูนี้มีแค่แบบ Hot และ Ice นะคะ ^^", "KKU Cafe'"); break;
                        }
                        ; break;
                    case "Cappuccino":
                        switch (comboBox2.Text)
                        {
                            case "Hot":
                                p = num * 35;
                                textBox1.Text += "Hot Cappuccino  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Ice":
                                p = num * 45;
                                textBox1.Text += "Ice Cappuccino  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Frappe":
                                p = num * 50;
                                textBox1.Text += "Frappe Cappuccino  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                        }
                        ; break;
                    case "Latte":
                        switch (comboBox2.Text)
                        {
                            case "Hot":
                                p = num * 35;
                                textBox1.Text += "Hot Latte  " + num + "           " + p + "  Bath"+"\r\n";
                                c += p;
                                textBox2.Text = c.ToString(); break;
                            case "Ice":
                                p = num * 45;
                                textBox1.Text += "Ice Latte  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Frappe":
                                p = num * 50;
                                textBox1.Text += "Frappe Latte  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                        }
                        ; break;
                    case "Esspresso":
                        switch (comboBox2.Text)
                        {
                            case "Hot":
                                p = num * 35;
                                textBox1.Text += "Hot Esspresso  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Ice":
                                p = num * 45;
                                textBox1.Text += "Ice Esspresso  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Frappe":
                                p = num * 50;
                                textBox1.Text += "Frappe Esspresso  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                        }
                        ; break;
                    case "Mocha":
                        switch (comboBox2.Text)
                        {
                            case "Hot":
                                p = num * 35;
                                textBox1.Text += "Hot Mocha  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Ice":
                                p = num * 45;
                                textBox1.Text += "Ice Mocha  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Frappe":
                                p = num * 50;
                                textBox1.Text += "Frappe Mocha  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                        }
                        ; break;
                    case "GreenTea":
                        switch (comboBox2.Text)
                        {
                            case "Hot":
                                p = num * 20;
                                textBox1.Text += "Hot GreenTea  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Ice":
                                p = num * 25;
                                textBox1.Text += "Ice GreenTea  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Frappe":
                                p = num * 30;
                                textBox1.Text += "Frappe GreenTea  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                        }
                        ; break;
                    case "ThaiTea":
                        switch (comboBox2.Text)
                        {
                            case "Hot":
                                p = num * 20;
                                textBox1.Text += "Hot ThaiTea  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Ice":
                                p = num * 25;
                                textBox1.Text += "Ice ThaiTea  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Frappe":
                                p = num * 30;
                                textBox1.Text += "Frappe ThaiTea  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                        }
                        ; break;
                    case "CoCoa":
                        switch (comboBox2.Text)
                        {
                            case "Hot":
                                p = num * 20;
                                textBox1.Text += "Hot CoCoa  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Ice":
                                p = num * 25;
                                textBox1.Text += "Ice CoCoa  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Frappe":
                                p = num * 30;
                                textBox1.Text += "Frappe CoCoa  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                        }
                        ; break;
                    case "Milk":
                        switch (comboBox2.Text)
                        {
                            case "Hot":
                                p = num * 20;
                                textBox1.Text += "Hot Milk  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Ice":
                                p = num * 25;
                                textBox1.Text += "Ice Milk  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Frappe":
                                p = num * 30;
                                textBox1.Text += "Frappe Milk  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                        }
                        ; break;
                    case "MilkTea":
                        switch (comboBox2.Text)
                        {
                            case "Ice":
                                p = num * 25;
                                textBox1.Text += "Ice MilkTea  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Frappe":
                                p = num * 30;
                                textBox1.Text += "Frappe MilkTea  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            default: MessageBox.Show("ขอโทษค่ะ เมนูนี้มีแค่แบบ Ice และ Frappe นะคะ ^^", "KKU Cafe'"); break;
                        }
                        ; break;
                    case "LemonTea":
                        switch (comboBox2.Text)
                        {
                            case "Ice":
                                p = num * 25;
                                textBox1.Text += "Ice LemonTea  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Frappe":
                                p = num * 30;
                                textBox1.Text += "Frappe LemonTea  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            default: MessageBox.Show("ขอโทษค่ะ เมนูนี้มีแค่แบบ Ice และ Frappe นะคะ ^^", "KKU Cafe'"); break;
                        }
                        ; break;
                    case "Milo":
                        switch (comboBox2.Text)
                        {
                            case "Hot":
                                p = num * 20;
                                textBox1.Text += "Hot Milo  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Ice":
                                p = num * 25;
                                textBox1.Text += "Ice Milo  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Frappe":
                                p = num * 30;
                                textBox1.Text += "Frappe Milo  " + num + "           " + p + "  Bath"+"\r\n";
                                c += p;
                                textBox2.Text = c.ToString(); break;
                        }
                        ; break;
                    case "Neascafe":
                        switch (comboBox2.Text)
                        {
                            case "Hot":
                                p = num * 20;
                                textBox1.Text += "Hot Neascafe  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Ice":
                                p = num * 25;
                                textBox1.Text += "Ice Neascafe  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Frappe":
                                p = num * 30;
                                textBox1.Text += "Frappe Neascafe  " + num + "           " + p + "  Bath"+"\r\n";
                                c += p;
                                textBox2.Text = c.ToString(); break;
                        }
                        ; break;
                    case "NeasTea":
                        switch (comboBox2.Text)
                        {
                            case "Hot":
                                p = num * 20;
                                textBox1.Text += "Hot NeasTea  " + num + "           " + p + "  Bath"+"\r\n";
                                c += p;
                                textBox2.Text = c.ToString(); break;
                            case "Ice":
                                p = num * 25;
                                textBox1.Text += "Ice NeasTea  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            case "Frappe":
                                p = num * 30;
                                textBox1.Text += "Frappe NeasTea  " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                        }
                        ; break;
                    case "Italian Soda":
                        switch (comboBox2.Text)
                        {

                            case "Ice":
                                p = num * 25;
                                textBox1.Text += "Italian Soda       " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            default: MessageBox.Show("ขอโทษค่ะ เมนูนี้มีแต่แบบ Ice นะคะ ^^", "KKU Cafe'"); break;
                        }
                        ; break;
                    case "Red lime Soda":
                        switch (comboBox2.Text)
                        {
                            case "Ice":
                                p = num * 25;
                                textBox1.Text += "Red lime Soda       " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            default: MessageBox.Show("ขอโทษค่ะ เมนูนี้มีแต่แบบ Ice นะคะ ^^", "KKU Cafe'"); break;
                        }
                        ; break;
                    case "Honey lime Soda":
                        switch (comboBox2.Text)
                        {
                            case "Ice":
                                p = num * 25;
                                textBox1.Text += "Honey lime Soda       " + num + "           " + p + "  Bath"+"\r\n"; 
                                c += p;
                                textBox2.Text = c.ToString();break;
                            default: MessageBox.Show("ขอโทษค่ะ เมนูนี้มีแต่แบบ Ice นะคะ ^^", "KKU Cafe'"); break;
                        }
                        ; break;
                    default: MessageBox.Show("ขอโทษค่ะ ระบุเครื่องดื่ม ประเภท และจำนวนด้วยนะคะ ^^", "KKU Cafe'"); break;

                }
            }
            catch
            {
                MessageBox.Show("ขอโทษค่ะ ระบุเครื่องดื่ม ประเภท และจำนวนด้วยนะคะ ^^", "KKU Cafe'");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog(); //คำสั่งบันทึกไฟล์
            saveDialog.FileName = "kku_"+DateTime.Now.ToString("hh-mm-ss-dd-MM-yyy");
            saveDialog.Filter = "TextFile | *.txt";
            DialogResult savefile = saveDialog.ShowDialog();
            if (savefile == System.Windows.Forms.DialogResult.OK)
            {
                string path = saveDialog.FileName;
                System.IO.File.WriteAllText(path, textBox1.Text + "\r\ntotal  = " + textBox2.Text + "   Bath");
            }
        }
    }
}
