using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication57
{
    public partial class Form1 : Form
    {
        int f, d;
        bool q = true, m1 = true;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.show("CCCCCCCCCCCCCCCCCCCC");
            if (q == true && button1.Text == "")
            {
                button1.BackColor = Color.Green;
                button1.Text = "X";
                q = !q;
                label1.Text = "my tern";
                //=============================================================
                if ((button1.Text == "X" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || 
                    (button1.Text == "" && button2.Text == "X" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "X" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || 
                    (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "X" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "X" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "X" && button8.Text == "" && button9.Text == "") || 
                    (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "X" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "X"))
                {
                    if (button5.Text == "")
                    {
                        button5.BackColor = Color.Red;
                        button5.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                }
                //=======H
                if ((button8.Text == "O" && button7.Text == "O" && button9.Text == "") || (button7.Text == "O" && button9.Text == "O" && button8.Text == "") || (button9.Text == "O" && button8.Text == "O" && button7.Text == "") || (button7.Text == "O" && button4.Text == "O" && button1.Text == "") || (button7.Text == "O" && button1.Text == "O" && button4.Text == "") || 
                    (button4.Text == "O" && button1.Text == "O" && button7.Text == "") || (button7.Text == "O" && button5.Text == "O" && button3.Text == "") || (button7.Text == "O" && button3.Text == "O" && button5.Text == "") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "") || 
                    (button9.Text == "O" && button5.Text == "O" && button1.Text == "") || (button9.Text == "O" && button1.Text == "O" && button5.Text == "") || (button1.Text == "O" && button5.Text == "O" && button9.Text == "") || (button8.Text == "O" && button5.Text == "O" && button2.Text == "") || (button8.Text == "O" && button2.Text == "O" && button5.Text == "") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "") || 
                    (button9.Text == "O" && button6.Text == "O" && button3.Text == "") || (button9.Text == "O" && button3.Text == "O" && button6.Text == "") || (button6.Text == "O" && button3.Text == "O" && button9.Text == "") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "") || (button4.Text == "O" && button6.Text == "O" && button5.Text == "") || (button6.Text == "O" && button5.Text == "O" && button4.Text == "") || (button1.Text == "O" && button2.Text == "O" && button3.Text == "") || (button1.Text == "O" && button3.Text == "O" && button2.Text == "") || (button3.Text == "O" && button2.Text == "O" && button1.Text == ""))
                {
                    if (q == false)
                    {
                        if (button8.Text == "O" && button7.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button4.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button1.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button1.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button5.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button3.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button3.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button5.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button1.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button1.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button5.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button2.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button2.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button6.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button3.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "O" && button3.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button6.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "O" && button2.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                }
                //=======H

                //=======D
                if (q == false)
                {
                    if ((button1.Text == "X" && button3.Text == "X" && button2.Text == "") || (button1.Text == "X" && button2.Text == "X" && button3.Text == "") || (button1.Text == "X" && button4.Text == "X" && button7.Text == "") || (button1.Text == "X" && button7.Text == "X" && button4.Text == "") || (button1.Text == "X" && button5.Text == "X" && button9.Text == "") || (button1.Text == "X" && button9.Text == "X" && button5.Text == ""))
                    {

                        if (button1.Text == "X" && button3.Text == "X" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "X" && button2.Text == "X" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "X" && button4.Text == "X" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "X" && button7.Text == "X" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "X" && button5.Text == "X" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "X" && button9.Text == "X" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }

                    }
                    //=======D
                    if (q == false)
                    {
                        if ((button1.Text == "" && button2.Text == "" && button3.Text == "") || (button4.Text == "" && button5.Text == "" && button6.Text == "") || (button7.Text == "" && button8.Text == "" && button9.Text == "") || (button7.Text == "" && button4.Text == "" && button1.Text == "") || (button8.Text == "" && button5.Text == "" && button2.Text == "") || (button9.Text == "" && button6.Text == "" && button3.Text == "") || (button1.Text == "" && button5.Text == "" && button8.Text == "") || (button7.Text == "" && button5.Text == "" && button3.Text == ""))
                        {
                            if (button1.Text == "" && button2.Text == "" && button3.Text == "" && q == false)
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button4.Text == "" && button5.Text == "" && button6.Text == "" && q == false)
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button8.Text == "" && button9.Text == "" && q == false)
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button4.Text == "" && button1.Text == "" && q == false)
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button8.Text == "" && button5.Text == "" && button2.Text == "" && q == false)
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button9.Text == "" && button6.Text == "" && button3.Text == "" && q == false)
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button5.Text == "" && button3.Text == "" && q == false)
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button1.Text == "" && button5.Text == "" && button9.Text == "" && q == false)
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                        }
                    }
                    if (q == false)
                    {

                    }
                    if (q == false)
                    {
                        //========A
                        if (button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        //=======A
                    }
                    //=============================================================
                }
            }
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X") || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") || (button1.Text == "X" && button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") || (button9.Text == "X" && button6.Text == "6X" && button3.Text == "X") || (button1.Text == "X" && button9.Text == "X" && button5.Text == "X") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "X"))
            {
                label1.Text = "You win!";
                panel1.Enabled = false;
                

            }
            if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O") || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O") || (button1.Text == "O" && button4.Text == "O" && button7.Text == "O") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O") || (button9.Text == "O" && button6.Text == "O" && button3.Text == "O") || (button1.Text == "O" && button9.Text == "O" && button5.Text == "O") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "O"))
            {
                label1.Text = "I win!";
                panel1.Enabled = false;

            }
            if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
                label1.Text = "Nobody win!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (q == true && button2.Text == "")
            {
                button2.BackColor = Color.Green;
                button2.Text = "X";
                q = !q;
                label1.Text = "my tern";
                //=============================================================
                if ((button1.Text == "X" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "X" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "X" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "X" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "X" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "X" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "X" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "X"))
                {
                    if (button5.Text == "")
                    {
                        button5.BackColor = Color.Red;
                        button5.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                }
                //=======H
                if ((button8.Text == "O" && button7.Text == "O" && button9.Text == "") || (button7.Text == "O" && button9.Text == "O" && button8.Text == "") || (button9.Text == "O" && button8.Text == "O" && button7.Text == "") || (button7.Text == "O" && button4.Text == "O" && button1.Text == "") || (button7.Text == "O" && button1.Text == "O" && button4.Text == "") || (button4.Text == "O" && button1.Text == "O" && button7.Text == "") || (button7.Text == "O" && button5.Text == "O" && button3.Text == "") || (button7.Text == "O" && button3.Text == "O" && button5.Text == "") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "") || (button9.Text == "O" && button5.Text == "O" && button1.Text == "") || (button9.Text == "O" && button1.Text == "O" && button5.Text == "") || (button1.Text == "O" && button5.Text == "O" && button9.Text == "") || (button8.Text == "O" && button5.Text == "O" && button2.Text == "") || (button8.Text == "O" && button2.Text == "O" && button5.Text == "") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "") || (button9.Text == "O" && button6.Text == "O" && button3.Text == "") || (button9.Text == "O" && button3.Text == "O" && button6.Text == "") || (button6.Text == "O" && button3.Text == "O" && button9.Text == "") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "") || (button4.Text == "O" && button6.Text == "O" && button5.Text == "") || (button6.Text == "O" && button5.Text == "O" && button4.Text == "") || (button1.Text == "O" && button2.Text == "O" && button3.Text == "") || (button1.Text == "O" && button3.Text == "O" && button2.Text == "") || (button3.Text == "O" && button2.Text == "O" && button1.Text == ""))
                {
                    if (q == false)
                    {
                        if (button8.Text == "O" && button7.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button4.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button1.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button1.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button5.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button3.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button3.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button5.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button1.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button1.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button5.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button2.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button2.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button6.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button3.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "O" && button3.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button6.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "O" && button2.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                }
                //=======H

                //=======D
                if (q == false)
                {
                    if ((button2.Text == "X" && button1.Text == "X" && button3.Text == "") || (button2.Text == "X" && button3.Text == "X" && button1.Text == "") || (button2.Text == "X" && button5.Text == "X" && button8.Text == "") || (button2.Text == "X" && button8.Text == "X" && button5.Text == ""))
                    {

                        if (button2.Text == "X" && button3.Text == "X" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button2.Text == "X" && button1.Text == "X" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button2.Text == "X" && button5.Text == "X" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button2.Text == "X" && button8.Text == "X" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                    if (q == false)
                    {
                        if ((button1.Text == "" && button2.Text == "" && button3.Text == "") || (button4.Text == "" && button5.Text == "" && button6.Text == "") || (button7.Text == "" && button8.Text == "" && button9.Text == "") || (button7.Text == "" && button4.Text == "" && button1.Text == "") || (button8.Text == "" && button5.Text == "" && button2.Text == "") || (button9.Text == "" && button6.Text == "" && button3.Text == "") || (button1.Text == "" && button5.Text == "" && button8.Text == "") || (button7.Text == "" && button5.Text == "" && button3.Text == ""))
                        {
                            if (button1.Text == "" && button2.Text == "" && button3.Text == "" && q == false)
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button4.Text == "" && button5.Text == "" && button6.Text == "" && q == false)
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button8.Text == "" && button9.Text == "" && q == false)
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button4.Text == "" && button1.Text == "" && q == false)
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button8.Text == "" && button5.Text == "" && button2.Text == "" && q == false)
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button9.Text == "" && button6.Text == "" && button3.Text == "" && q == false)
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button5.Text == "" && button3.Text == "" && q == false)
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button1.Text == "" && button5.Text == "" && button9.Text == "" && q == false)
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                        }
                    }
                    //=======D
                    if (q == false)
                    {
                        //========A
                        if (button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        //=======A
                    }
                    //=============================================================
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (q == true && button3.Text == "")
            {
                button3.BackColor = Color.Green;
                button3.Text = "X";
                q = !q;
                label1.Text = "my tern";
                //=============================================================
                if ((button1.Text == "X" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "X" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "X" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "X" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "X" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "X" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "X" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "X"))
                {
                    if (button5.Text == "")
                    {
                        button5.BackColor = Color.Red;
                        button5.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                }
                //=======H
                if ((button8.Text == "O" && button7.Text == "O" && button9.Text == "") || (button7.Text == "O" && button9.Text == "O" && button8.Text == "") || (button9.Text == "O" && button8.Text == "O" && button7.Text == "") || (button7.Text == "O" && button4.Text == "O" && button1.Text == "") || (button7.Text == "O" && button1.Text == "O" && button4.Text == "") || (button4.Text == "O" && button1.Text == "O" && button7.Text == "") || (button7.Text == "O" && button5.Text == "O" && button3.Text == "") || (button7.Text == "O" && button3.Text == "O" && button5.Text == "") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "") || (button9.Text == "O" && button5.Text == "O" && button1.Text == "") || (button9.Text == "O" && button1.Text == "O" && button5.Text == "") || (button1.Text == "O" && button5.Text == "O" && button9.Text == "") || (button8.Text == "O" && button5.Text == "O" && button2.Text == "") || (button8.Text == "O" && button2.Text == "O" && button5.Text == "") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "") || (button9.Text == "O" && button6.Text == "O" && button3.Text == "") || (button9.Text == "O" && button3.Text == "O" && button6.Text == "") || (button6.Text == "O" && button3.Text == "O" && button9.Text == "") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "") || (button4.Text == "O" && button6.Text == "O" && button5.Text == "") || (button6.Text == "O" && button5.Text == "O" && button4.Text == "") || (button1.Text == "O" && button2.Text == "O" && button3.Text == "") || (button1.Text == "O" && button3.Text == "O" && button2.Text == "") || (button3.Text == "O" && button2.Text == "O" && button1.Text == ""))
                {
                    if (q == false)
                    {
                        if (button8.Text == "O" && button7.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button4.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button1.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button1.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button5.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button3.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button3.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button5.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button1.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button1.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button5.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button2.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button2.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button6.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button3.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "O" && button3.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button6.Text == "O" && button4.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "O" && button2.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                }
                //=======H

                //=======D
                if (q == false)
                {
                    if ((button3.Text == "X" && button2.Text == "X" && button1.Text == "") || (button3.Text == "X" && button1.Text == "X" && button2.Text == "") || (button3.Text == "X" && button6.Text == "X" && button9.Text == "") || (button3.Text == "X" && button9.Text == "X" && button6.Text == "") || (button3.Text == "X" && button5.Text == "X" && button7.Text == "") || (button3.Text == "X" && button7.Text == "X" && button5.Text == ""))
                    {

                        if (button3.Text == "X" && button6.Text == "X" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "X" && button9.Text == "X" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "X" && button1.Text == "X" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "X" && button2.Text == "X" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "X" && button7.Text == "X" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "X" && button5.Text == "X" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }

                    }
                    if (q == false)
                    {
                        if ((button1.Text == "" && button2.Text == "" && button3.Text == "") || (button4.Text == "" && button5.Text == "" && button6.Text == "") || (button7.Text == "" && button8.Text == "" && button9.Text == "") || (button7.Text == "" && button4.Text == "" && button1.Text == "") || (button8.Text == "" && button5.Text == "" && button2.Text == "") || (button9.Text == "" && button6.Text == "" && button3.Text == "") || (button1.Text == "" && button5.Text == "" && button8.Text == "") || (button7.Text == "" && button5.Text == "" && button3.Text == ""))
                        {
                            if (button1.Text == "" && button2.Text == "" && button3.Text == "" && q == false)
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button4.Text == "" && button5.Text == "" && button6.Text == "" && q == false)
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button8.Text == "" && button9.Text == "" && q == false)
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button4.Text == "" && button1.Text == "" && q == false)
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button8.Text == "" && button5.Text == "" && button2.Text == "" && q == false)
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button9.Text == "" && button6.Text == "" && button3.Text == "" && q == false)
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button5.Text == "" && button3.Text == "" && q == false)
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button1.Text == "" && button5.Text == "" && button9.Text == "" && q == false)
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                        }
                    }
                    //=======D
                    if (q == false)
                    {
                        //========A
                        if (button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        //=======A
                    }
                    //=============================================================
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (q == true && button4.Text == "")
            {
                button4.BackColor = Color.Green;
                button4.Text = "X";
                q = !q;
                label1.Text = "my tern";
                //=============================================================
                if ((button1.Text == "X" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "X" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "X" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "X" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "X" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "X" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "X" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "X"))
                {
                    if (button5.Text == "")
                    {
                        button5.BackColor = Color.Red;
                        button5.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                }
                //=======H
                if ((button8.Text == "O" && button7.Text == "O" && button9.Text == "") || (button7.Text == "O" && button9.Text == "O" && button8.Text == "") || (button9.Text == "O" && button8.Text == "O" && button7.Text == "") || (button7.Text == "O" && button4.Text == "O" && button1.Text == "") || (button7.Text == "O" && button1.Text == "O" && button4.Text == "") || (button4.Text == "O" && button1.Text == "O" && button7.Text == "") || (button7.Text == "O" && button5.Text == "O" && button3.Text == "") || (button7.Text == "O" && button3.Text == "O" && button5.Text == "") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "") || (button9.Text == "O" && button5.Text == "O" && button1.Text == "") || (button9.Text == "O" && button1.Text == "O" && button5.Text == "") || (button1.Text == "O" && button5.Text == "O" && button9.Text == "") || (button8.Text == "O" && button5.Text == "O" && button2.Text == "") || (button8.Text == "O" && button2.Text == "O" && button5.Text == "") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "") || (button9.Text == "O" && button6.Text == "O" && button3.Text == "") || (button9.Text == "O" && button3.Text == "O" && button6.Text == "") || (button6.Text == "O" && button3.Text == "O" && button9.Text == "") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "") || (button4.Text == "O" && button6.Text == "O" && button5.Text == "") || (button6.Text == "O" && button5.Text == "O" && button4.Text == "") || (button1.Text == "O" && button2.Text == "O" && button3.Text == "") || (button1.Text == "O" && button3.Text == "O" && button2.Text == "") || (button3.Text == "O" && button2.Text == "O" && button1.Text == ""))
                {
                    if (q == false)
                    {
                        if (button8.Text == "O" && button7.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button4.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button1.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button1.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button5.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button3.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button3.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button5.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button1.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button1.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button5.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button2.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button2.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button6.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button3.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "O" && button3.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button6.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "O" && button2.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                }
                //=======H

                //=======D
                if (q == false)
                {
                    if ((button4.Text == "X" && button6.Text == "X" && button5.Text == "") || (button4.Text == "X" && button5.Text == "X" && button6.Text == "") || (button4.Text == "X" && button7.Text == "X" && button1.Text == "") || (button4.Text == "X" && button1.Text == "X" && button7.Text == ""))
                    {

                        if (button4.Text == "X" && button6.Text == "X" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "X" && button5.Text == "X" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "X" && button1.Text == "X" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "X" && button7.Text == "X" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                    if (q == false)
                    {
                        if ((button1.Text == "" && button2.Text == "" && button3.Text == "") || (button4.Text == "" && button5.Text == "" && button6.Text == "") || (button7.Text == "" && button8.Text == "" && button9.Text == "") || (button7.Text == "" && button4.Text == "" && button1.Text == "") || (button8.Text == "" && button5.Text == "" && button2.Text == "") || 
                            (button9.Text == "" && button6.Text == "" && button3.Text == "") || (button1.Text == "" && button5.Text == "" && button8.Text == "") || (button7.Text == "" && button5.Text == "" && button3.Text == ""))
                        {
                            if (button1.Text == "" && button2.Text == "" && button3.Text == "" && q == false)
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button4.Text == "" && button5.Text == "" && button6.Text == "" && q == false)
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button8.Text == "" && button9.Text == "" && q == false)
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button4.Text == "" && button1.Text == "" && q == false)
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button8.Text == "" && button5.Text == "" && button2.Text == "" && q == false)
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button9.Text == "" && button6.Text == "" && button3.Text == "" && q == false)
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button5.Text == "" && button3.Text == "" && q == false)
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button1.Text == "" && button5.Text == "" && button9.Text == "" && q == false)
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                        }
                    }
                    //=======D
                    if (q == false)
                    {
                        //========A
                        if (button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        //=======A
                    }
                    //=============================================================
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (q == true && button8.Text == "")
            {
                button8.BackColor = Color.Green;
                button8.Text = "X";
                q = !q;
                label1.Text = "my tern";
                //=============================================================
                if ((button1.Text == "X" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "X" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "X" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "X" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "X" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "X" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "X" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "X"))
                {
                    if (button5.Text == "")
                    {
                        button5.BackColor = Color.Red;
                        button5.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                }
                //=======H
                if ((button8.Text == "O" && button7.Text == "O" && button9.Text == "") || (button7.Text == "O" && button9.Text == "O" && button8.Text == "") || (button9.Text == "O" && button8.Text == "O" && button7.Text == "") || (button7.Text == "O" && button4.Text == "O" && button1.Text == "") || (button7.Text == "O" && button1.Text == "O" && button4.Text == "") || (button4.Text == "O" && button1.Text == "O" && button7.Text == "") || (button7.Text == "O" && button5.Text == "O" && button3.Text == "") || (button7.Text == "O" && button3.Text == "O" && button5.Text == "") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "") || (button9.Text == "O" && button5.Text == "O" && button1.Text == "") || (button9.Text == "O" && button1.Text == "O" && button5.Text == "") || (button1.Text == "O" && button5.Text == "O" && button9.Text == "") || (button8.Text == "O" && button5.Text == "O" && button2.Text == "") || (button8.Text == "O" && button2.Text == "O" && button5.Text == "") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "") || (button9.Text == "O" && button6.Text == "O" && button3.Text == "") || (button9.Text == "O" && button3.Text == "O" && button6.Text == "") || (button6.Text == "O" && button3.Text == "O" && button9.Text == "") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "") || (button4.Text == "O" && button6.Text == "O" && button5.Text == "") || (button6.Text == "O" && button5.Text == "O" && button4.Text == "") || (button1.Text == "O" && button2.Text == "O" && button3.Text == "") || (button1.Text == "O" && button3.Text == "O" && button2.Text == "") || (button3.Text == "O" && button2.Text == "O" && button1.Text == ""))
                {
                    if (q == false)
                    {
                        if (button8.Text == "O" && button7.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button4.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button1.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button1.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button5.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button3.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button3.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button5.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button1.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button1.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button5.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button2.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button2.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button6.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button3.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "O" && button3.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button6.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "O" && button2.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                }
                //=======H

                //=======D
                if (q == false)
                {
                    if ((button8.Text == "X" && button5.Text == "X" && button2.Text == "") || (button8.Text == "X" && button2.Text == "X" && button5.Text == "") || (button8.Text == "X" && button7.Text == "X" && button9.Text == "") || (button8.Text == "X" && button9.Text == "X" && button7.Text == ""))
                    {

                        if (button8.Text == "X" && button2.Text == "X" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "X" && button5.Text == "X" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "X" && button7.Text == "X" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "X" && button9.Text == "X" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                    if (q == false)
                    {
                        if ((button1.Text == "" && button2.Text == "" && button3.Text == "") || (button4.Text == "" && button5.Text == "" && button6.Text == "") || (button7.Text == "" && button8.Text == "" && button9.Text == "") || (button7.Text == "" && button4.Text == "" && button1.Text == "") || (button8.Text == "" && button5.Text == "" && button2.Text == "") || (button9.Text == "" && button6.Text == "" && button3.Text == "") || (button1.Text == "" && button5.Text == "" && button8.Text == "") || (button7.Text == "" && button5.Text == "" && button3.Text == ""))
                        {
                            if (button1.Text == "" && button2.Text == "" && button3.Text == "" && q == false)
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button4.Text == "" && button5.Text == "" && button6.Text == "" && q == false)
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button8.Text == "" && button9.Text == "" && q == false)
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button4.Text == "" && button1.Text == "" && q == false)
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button8.Text == "" && button5.Text == "" && button2.Text == "" && q == false)
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button9.Text == "" && button6.Text == "" && button3.Text == "" && q == false)
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button5.Text == "" && button3.Text == "" && q == false)
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button1.Text == "" && button5.Text == "" && button9.Text == "" && q == false)
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                        }
                    }
                    //=======D
                    if (q == false)
                    {
                        //========A
                        if (button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        //=======A
                    }
                    //=============================================================
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (q == true && button6.Text == "")
            {
                button6.BackColor = Color.Green;
                button6.Text = "X";
                q = !q;
                label1.Text = "my tern";
                //=============================================================
                if ((button1.Text == "X" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "X" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "X" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "X" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "X" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "X" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "X" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "X"))
                {
                    if (button5.Text == "")
                    {
                        button5.BackColor = Color.Red;
                        button5.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                }
                //=======H
                if ((button8.Text == "O" && button7.Text == "O" && button9.Text == "") || (button7.Text == "O" && button9.Text == "O" && button8.Text == "") || (button9.Text == "O" && button8.Text == "O" && button7.Text == "") || (button7.Text == "O" && button4.Text == "O" && button1.Text == "") || (button7.Text == "O" && button1.Text == "O" && button4.Text == "") || (button4.Text == "O" && button1.Text == "O" && button7.Text == "") || (button7.Text == "O" && button5.Text == "O" && button3.Text == "") || (button7.Text == "O" && button3.Text == "O" && button5.Text == "") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "") || (button9.Text == "O" && button5.Text == "O" && button1.Text == "") || (button9.Text == "O" && button1.Text == "O" && button5.Text == "") || (button1.Text == "O" && button5.Text == "O" && button9.Text == "") || (button8.Text == "O" && button5.Text == "O" && button2.Text == "") || (button8.Text == "O" && button2.Text == "O" && button5.Text == "") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "") || (button9.Text == "O" && button6.Text == "O" && button3.Text == "") || (button9.Text == "O" && button3.Text == "O" && button6.Text == "") || (button6.Text == "O" && button3.Text == "O" && button9.Text == "") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "") || (button4.Text == "O" && button6.Text == "O" && button5.Text == "") || (button6.Text == "O" && button5.Text == "O" && button4.Text == "") || (button1.Text == "O" && button2.Text == "O" && button3.Text == "") || (button1.Text == "O" && button3.Text == "O" && button2.Text == "") || (button3.Text == "O" && button2.Text == "O" && button1.Text == ""))
                {
                    if (q == false)
                    {
                        if (button8.Text == "O" && button7.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button4.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button1.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button1.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button5.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button3.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button3.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button5.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button1.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button1.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button5.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button2.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button2.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button6.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button3.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "O" && button3.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button6.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "O" && button2.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                }
                //=======H

                //=======D
                if (q == false)
                {
                    if ((button6.Text == "X" && button5.Text == "X" && button4.Text == "") || (button6.Text == "X" && button4.Text == "X" && button5.Text == "") || (button6.Text == "X" && button3.Text == "X" && button9.Text == "") || (button6.Text == "X" && button9.Text == "X" && button3.Text == ""))
                    {

                        if (button6.Text == "X" && button5.Text == "X" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "X" && button4.Text == "X" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "X" && button9.Text == "X" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "X" && button3.Text == "X" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                    if (q == false)
                    {
                        if ((button1.Text == "" && button2.Text == "" && button3.Text == "") || (button4.Text == "" && button5.Text == "" && button6.Text == "") || (button7.Text == "" && button8.Text == "" && button9.Text == "") || (button7.Text == "" && button4.Text == "" && button1.Text == "") || (button8.Text == "" && button5.Text == "" && button2.Text == "") || (button9.Text == "" && button6.Text == "" && button3.Text == "") || (button1.Text == "" && button5.Text == "" && button8.Text == "") || (button7.Text == "" && button5.Text == "" && button3.Text == ""))
                        {
                            if (button1.Text == "" && button2.Text == "" && button3.Text == "" && q == false)
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button4.Text == "" && button5.Text == "" && button6.Text == "" && q == false)
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button8.Text == "" && button9.Text == "" && q == false)
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button4.Text == "" && button1.Text == "" && q == false)
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button8.Text == "" && button5.Text == "" && button2.Text == "" && q == false)
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button9.Text == "" && button6.Text == "" && button3.Text == "" && q == false)
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button5.Text == "" && button3.Text == "" && q == false)
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button1.Text == "" && button5.Text == "" && button9.Text == "" && q == false)
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                        }
                    }
                    //=======D
                    if (q == false)
                    {
                        //========A
                        if (button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        //=======A
                    }
                    //=============================================================
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (q == true && button7.Text == "")
            {
                button7.BackColor = Color.Green;
                button7.Text = "X";
                q = !q;
                label1.Text = "my tern";
                //=============================================================
                if ((button1.Text == "X" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "X" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "X" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "X" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "X" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "X" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "X" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "X"))
                {
                    if (button5.Text == "")
                    {
                        button5.BackColor = Color.Red;
                        button5.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                }
                //=======H
                if ((button8.Text == "O" && button7.Text == "O" && button9.Text == "") || (button7.Text == "O" && button9.Text == "O" && button8.Text == "") || (button9.Text == "O" && button8.Text == "O" && button7.Text == "") || (button7.Text == "O" && button4.Text == "O" && button1.Text == "") || (button7.Text == "O" && button1.Text == "O" && button4.Text == "") || (button4.Text == "O" && button1.Text == "O" && button7.Text == "") || (button7.Text == "O" && button5.Text == "O" && button3.Text == "") || (button7.Text == "O" && button3.Text == "O" && button5.Text == "") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "") || (button9.Text == "O" && button5.Text == "O" && button1.Text == "") || (button9.Text == "O" && button1.Text == "O" && button5.Text == "") || (button1.Text == "O" && button5.Text == "O" && button9.Text == "") || (button8.Text == "O" && button5.Text == "O" && button2.Text == "") || (button8.Text == "O" && button2.Text == "O" && button5.Text == "") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "") || (button9.Text == "O" && button6.Text == "O" && button3.Text == "") || (button9.Text == "O" && button3.Text == "O" && button6.Text == "") || (button6.Text == "O" && button3.Text == "O" && button9.Text == "") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "") || (button4.Text == "O" && button6.Text == "O" && button5.Text == "") || (button6.Text == "O" && button5.Text == "O" && button4.Text == "") || (button1.Text == "O" && button2.Text == "O" && button3.Text == "") || (button1.Text == "O" && button3.Text == "O" && button2.Text == "") || (button3.Text == "O" && button2.Text == "O" && button1.Text == ""))
                {
                    if (q == false)
                    {
                        if (button8.Text == "O" && button7.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button4.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button1.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button1.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button5.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button3.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button3.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button5.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button1.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button1.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button5.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button2.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button2.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button6.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button3.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "O" && button3.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button6.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "O" && button2.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                }
                //=======H

                //=======D
                if (q == false)
                {
                    if ((button7.Text == "X" && button8.Text == "X" && button9.Text == "") || (button7.Text == "X" && button9.Text == "X" && button8.Text == "") || (button7.Text == "X" && button4.Text == "X" && button1.Text == "") || (button7.Text == "X" && button1.Text == "X" && button4.Text == "") || (button7.Text == "X" && button3.Text == "X" && button5.Text == "") || (button7.Text == "X" && button5.Text == "X" && button3.Text == ""))
                    {

                        if (button7.Text == "X" && button5.Text == "X" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "X" && button3.Text == "X" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "X" && button8.Text == "X" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "X" && button9.Text == "X" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "X" && button1.Text == "X" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "X" && button4.Text == "X" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                    //=======D
                    if (q == false)
                    {
                        //========A
                        if (button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        //=======A
                    }
                    //=============================================================
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (q == true && button9.Text == "")
            {
                button9.BackColor = Color.Green;
                button9.Text = "X";
                q = !q;
                label1.Text = "my tern";

                if ((button1.Text == "X" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "X" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "X" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "X" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "X" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "X" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "X" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "X"))
                {
                    if (button5.Text == "")
                    {
                        button5.BackColor = Color.Red;
                        button5.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                }
                //=======H
                if ((button8.Text == "O" && button7.Text == "O" && button9.Text == "") || (button7.Text == "O" && button9.Text == "O" && button8.Text == "") || (button9.Text == "O" && button8.Text == "O" && button7.Text == "") || (button7.Text == "O" && button4.Text == "O" && button1.Text == "") || (button7.Text == "O" && button1.Text == "O" && button4.Text == "") || (button4.Text == "O" && button1.Text == "O" && button7.Text == "") || (button7.Text == "O" && button5.Text == "O" && button3.Text == "") || (button7.Text == "O" && button3.Text == "O" && button5.Text == "") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "") || (button9.Text == "O" && button5.Text == "O" && button1.Text == "") || (button9.Text == "O" && button1.Text == "O" && button5.Text == "") || (button1.Text == "O" && button5.Text == "O" && button9.Text == "") || (button8.Text == "O" && button5.Text == "O" && button2.Text == "") || (button8.Text == "O" && button2.Text == "O" && button5.Text == "") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "") || (button9.Text == "O" && button6.Text == "O" && button3.Text == "") || (button9.Text == "O" && button3.Text == "O" && button6.Text == "") || (button6.Text == "O" && button3.Text == "O" && button9.Text == "") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "") || (button4.Text == "O" && button6.Text == "O" && button5.Text == "") || (button6.Text == "O" && button5.Text == "O" && button4.Text == "") || (button1.Text == "O" && button2.Text == "O" && button3.Text == "") || (button1.Text == "O" && button3.Text == "O" && button2.Text == "") || (button3.Text == "O" && button2.Text == "O" && button1.Text == ""))
                {
                    if (q == false)
                    {
                        if (button8.Text == "O" && button7.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button4.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button1.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button1.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button5.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button3.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button3.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button5.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button1.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button1.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button5.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button2.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button2.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button6.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button3.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "O" && button3.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button6.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "O" && button2.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                }
                //=======H

                //=======D
                if (q == false)
                {
                    if ((button9.Text == "X" && button6.Text == "X" && button3.Text == "") || (button9.Text == "X" && button3.Text == "X" && button6.Text == "") || (button9.Text == "X" && button7.Text == "X" && button8.Text == "") || (button9.Text == "X" && button8.Text == "X" && button7.Text == "") || (button9.Text == "X" && button5.Text == "X" && button1.Text == "") || (button9.Text == "X" && button1.Text == "X" && button5.Text == ""))
                    {
                        if (button9.Text == "X" && button5.Text == "X" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "X" && button1.Text == "X" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "X" && button6.Text == "X" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "X" && button3.Text == "X" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "X" && button8.Text == "X" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "X" && button7.Text == "X" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                }

                //=======D
                if (q == false)
                {
                    //========A
                    if (button5.Text == "" && q == false)
                    {
                        button5.BackColor = Color.Red;
                        button5.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                    if (button7.Text == "" && q == false)
                    {
                        button7.BackColor = Color.Red;
                        button7.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                    if (button9.Text == "" && q == false)
                    {
                        button9.BackColor = Color.Red;
                        button9.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                    if (button1.Text == "" && q == false)
                    {
                        button1.BackColor = Color.Red;
                        button1.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                    if (button3.Text == "" && q == false)
                    {
                        button3.BackColor = Color.Red;
                        button3.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                    if (button2.Text == "" && q == false)
                    {
                        button2.BackColor = Color.Red;
                        button2.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                    if (button4.Text == "" && q == false)
                    {
                        button4.BackColor = Color.Red;
                        button4.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                    if (button8.Text == "" && q == false)
                    {
                        button8.BackColor = Color.Red;
                        button8.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                    if (button6.Text == "" && q == false)
                    {
                        button6.BackColor = Color.Red;
                        button6.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                    //=======A
                }
                //=============================================================
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (q == true && button5.Text == "")
            {
                button5.BackColor = Color.Green;
                button5.Text = "X";
                q = !q;
                label1.Text = "my tern";
                //=============================================================
                if ((button1.Text == "X" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "X" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "X" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "X" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "X" && button7.Text == "" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "X" && button8.Text == "" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "X" && button9.Text == "") || (button1.Text == "" && button2.Text == "" && button3.Text == "" && button4.Text == "" && button5.Text == "" && button6.Text == "" && button7.Text == "" && button8.Text == "" && button9.Text == "X"))
                {
                    if (button5.Text == "")
                    {
                        button5.BackColor = Color.Red;
                        button5.Text = "O";
                        q = !q;
                        label1.Text = "your tern";
                    }
                }
                //=======H
                if ((button8.Text == "O" && button7.Text == "O" && button9.Text == "") || (button7.Text == "O" && button9.Text == "O" && button8.Text == "") || (button9.Text == "O" && button8.Text == "O" && button7.Text == "") || (button7.Text == "O" && button4.Text == "O" && button1.Text == "") || (button7.Text == "O" && button1.Text == "O" && button4.Text == "") || (button4.Text == "O" && button1.Text == "O" && button7.Text == "") || (button7.Text == "O" && button5.Text == "O" && button3.Text == "") || (button7.Text == "O" && button3.Text == "O" && button5.Text == "") || (button3.Text == "O" && button5.Text == "O" && button7.Text == "") || (button9.Text == "O" && button5.Text == "O" && button1.Text == "") || (button9.Text == "O" && button1.Text == "O" && button5.Text == "") || (button1.Text == "O" && button5.Text == "O" && button9.Text == "") || (button8.Text == "O" && button5.Text == "O" && button2.Text == "") || (button8.Text == "O" && button2.Text == "O" && button5.Text == "") || (button2.Text == "O" && button5.Text == "O" && button8.Text == "") || (button9.Text == "O" && button6.Text == "O" && button3.Text == "") || (button9.Text == "O" && button3.Text == "O" && button6.Text == "") || (button6.Text == "O" && button3.Text == "O" && button9.Text == "") || (button4.Text == "O" && button5.Text == "O" && button6.Text == "") || (button4.Text == "O" && button6.Text == "O" && button5.Text == "") || (button6.Text == "O" && button5.Text == "O" && button4.Text == "") || (button1.Text == "O" && button2.Text == "O" && button3.Text == "") || (button1.Text == "O" && button3.Text == "O" && button2.Text == "") || (button3.Text == "O" && button2.Text == "O" && button1.Text == ""))
                {
                    if (q == false)
                    {
                        if (button8.Text == "O" && button7.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button9.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button9.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button4.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button1.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button1.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button5.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "O" && button3.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button3.Text == "O" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button5.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button1.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button1.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button5.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "O" && button2.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button2.Text == "O" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button6.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "O" && button3.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "O" && button3.Text == "O" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "O" && button6.Text == "O" && button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "O" && button6.Text == "O" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "O" && button3.Text == "O" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "O" && button2.Text == "O" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                }
                //=======H

                //=======D
                if (q == false)
                {
                    if ((button5.Text == "X" && button4.Text == "X" && button6.Text == "") || (button5.Text == "X" && button6.Text == "X" && button4.Text == "") || (button5.Text == "X" && button7.Text == "X" && button3.Text == "") || (button5.Text == "X" && button3.Text == "X" && button7.Text == "") || (button5.Text == "X" && button9.Text == "X" && button1.Text == "") || (button5.Text == "X" && button1.Text == "X" && button9.Text == "") || (button5.Text == "X" && button8.Text == "X" && button2.Text == "") || (button5.Text == "X" && button2.Text == "X" && button8.Text == ""))
                    {

                        if (button5.Text == "X" && button8.Text == "X" && button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "X" && button2.Text == "X" && button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "X" && button4.Text == "X" && button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "X" && button6.Text == "X" && button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "X" && button7.Text == "X" && button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "X" && button3.Text == "X" && button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "X" && button9.Text == "X" && button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button5.Text == "X" && button1.Text == "X" && button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                    }
                    if (q == false)
                    {
                        if ((button1.Text == "" && button2.Text == "" && button3.Text == "") || (button4.Text == "" && button5.Text == "" && button6.Text == "") || (button7.Text == "" && button8.Text == "" && button9.Text == "") || (button7.Text == "" && button4.Text == "" && button1.Text == "") || (button8.Text == "" && button5.Text == "" && button2.Text == "") || (button9.Text == "" && button6.Text == "" && button3.Text == "") || (button1.Text == "" && button5.Text == "" && button8.Text == "") || (button7.Text == "" && button5.Text == "" && button3.Text == ""))
                        {
                            if (button1.Text == "" && button2.Text == "" && button3.Text == "" && q == false)
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button4.Text == "" && button5.Text == "" && button6.Text == "" && q == false)
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button8.Text == "" && button9.Text == "" && q == false)
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button4.Text == "" && button1.Text == "" && q == false)
                            {
                                button4.BackColor = Color.Red;
                                button4.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button8.Text == "" && button5.Text == "" && button2.Text == "" && q == false)
                            {
                                button8.BackColor = Color.Red;
                                button8.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button9.Text == "" && button6.Text == "" && button3.Text == "" && q == false)
                            {
                                button9.BackColor = Color.Red;
                                button9.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button7.Text == "" && button5.Text == "" && button3.Text == "" && q == false)
                            {
                                button7.BackColor = Color.Red;
                                button7.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                            if (button1.Text == "" && button5.Text == "" && button9.Text == "" && q == false)
                            {
                                button1.BackColor = Color.Red;
                                button1.Text = "O";
                                q = !q;
                                label1.Text = "your tern";
                            }
                        }
                    }
                    //=======D
                    if (q == false)
                    {
                        //========A
                        if (button5.Text == "" && q == false)
                        {
                            button5.BackColor = Color.Red;
                            button5.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button7.Text == "" && q == false)
                        {
                            button7.BackColor = Color.Red;
                            button7.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button9.Text == "" && q == false)
                        {
                            button9.BackColor = Color.Red;
                            button9.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button1.Text == "" && q == false)
                        {
                            button1.BackColor = Color.Red;
                            button1.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button3.Text == "" && q == false)
                        {
                            button3.BackColor = Color.Red;
                            button3.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button2.Text == "" && q == false)
                        {
                            button2.BackColor = Color.Red;
                            button2.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button4.Text == "" && q == false)
                        {
                            button4.BackColor = Color.Red;
                            button4.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button8.Text == "" && q == false)
                        {
                            button8.BackColor = Color.Red;
                            button8.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        if (button6.Text == "" && q == false)
                        {
                            button6.BackColor = Color.Red;
                            button6.Text = "O";
                            q = !q;
                            label1.Text = "your tern";
                        }
                        //=======A
                    }
                    //=============================================================
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "your tern";
            button1.BackColor = Color.White;
            button1.Text = "";

            button2.BackColor = Color.White;
            button2.Text = "";

            button3.BackColor = Color.White;
            button3.Text = "";

            button5.BackColor = Color.White;
            button5.Text = "";

            button4.BackColor = Color.White;
            button4.Text = "";

            button6.BackColor = Color.White;
            button6.Text = "";

            button7.BackColor = Color.White;
            button7.Text = "";

            button8.BackColor = Color.White;
            button8.Text = "";

            button9.BackColor = Color.White;
            button9.Text = "";

            q = true;
            label1.Text = "your tern";
            panel1.Enabled = true;

        }

        private void panel2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (m1 == true)
            {
                WindowState = FormWindowState.Maximized;
                m1 = !m1;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                m1 = !m1;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (m1 == true)
            {
                WindowState = FormWindowState.Maximized;
                m1 = !m1;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                m1 = !m1;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Top += e.Y - f; this.Left += e.X - d;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            d = e.X; f = e.Y;
        }
    }
}