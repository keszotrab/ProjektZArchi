using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {











            int iDontKnowAndIDontCare = 0;
            var b = checkedListBox2.CheckedItems;
            foreach (var item in b)
            {
                Console.WriteLine("tragedia");

                if (iDontKnowAndIDontCare > 0)
                {

                    iDontKnowAndIDontCare = 0;
                    foreach (int i in checkedListBox2.CheckedIndices)
                    {
                        checkedListBox2.SetItemCheckState(i, CheckState.Unchecked);
                    }
                    break;

                }
                iDontKnowAndIDontCare++;

            }

            //checkedListBox2.ClearSelected();
            //iDontKnowAndIDontCare = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }



        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {


            
            if (checkedListBox2.CheckedItems.Contains("MOV") == true)
            {
                switch (textBox17.Text)
                {
                    case "AX":
                        switch (textBox18.Text)
                        {
                            case "AX":
                                Mov(textBox9, textBox9);
                                break;
                            case "BX":
                                Mov(textBox9, textBox10);
                                break;
                            case "CX":
                                Mov(textBox9, textBox11);
                                break;
                            case "DX":
                                Mov(textBox9, textBox12);
                                break;
                            default:
                                // code block
                                break;
                        }

                        break;
                    case "BX":
                        switch (textBox18.Text)
                        {
                            case "AX":
                                Mov(textBox10, textBox9);
                                break;
                            case "BX":
                                Mov(textBox10, textBox10);
                                break;
                            case "CX":
                                Mov(textBox10, textBox11);
                                break;
                            case "DX":
                                Mov(textBox10, textBox12);
                                break;
                            default:
                                // code block
                                break;
                        }
                        break;
                    case "CX":
                        switch (textBox18.Text)
                        {
                            case "AX":
                                Mov(textBox11, textBox9);
                                break;
                            case "BX":
                                Mov(textBox11, textBox10);
                                break;
                            case "CX":
                                Mov(textBox11, textBox11);
                                break;
                            case "DX":
                                Mov(textBox11, textBox12);
                                break;
                            default:
                                // code block
                                break;
                        }
                        break;
                    case "DX":
                        switch (textBox18.Text)
                        {
                            case "AX":
                                Mov(textBox12, textBox9);
                                break;
                            case "BX":
                                Mov(textBox12, textBox10);
                                break;
                            case "CX":
                                Mov(textBox12, textBox11);
                                break;
                            case "DX":
                                Mov(textBox12, textBox12);
                                break;
                            default:
                                // code block
                                break;
                        }
                        break;
                    default:
                        // code block
                        break;
                }
            }
            if (checkedListBox2.CheckedItems.Contains("XCHG") == true)
            {

            }
            if (checkedListBox2.CheckedItems.Contains("ADD") == true)
            {

            }
        }




        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void Mov(TextBox x, TextBox y)
        {
            //string temp = x.Text;
            x.Text = y.Text;
            //y.Text = temp;





        }

        private void button5_Click(object sender, EventArgs e)
        {


            ////textBox17 = "a";
            ////textBox18 = "b";
            //string a = textBox17.Text;
            //string b = textBox17.Text;

            //TextBox result1;
            //TextBox result2;
            //result1 = this.GetType().GetField("a").GetValue("a");
            //result2 = this.GetType().GetField("b").GetValue("b");

            //Mov(result1, result2);
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }




}
