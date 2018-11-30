using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool fristmove = false;
        bool secondchek = false;
        int onechose = 0;

        //89 if til now


        void cpu_mind()
        {
            
            ///ACTION FOR FRIST MOVE
            if (button5.Text == "O")
            {
                if (fristmove == true && secondchek == false)
                {
                    secondchek = true;
                    Random rnd = new Random();
                    int which = rnd.Next(1, 9);
                    if (which == 1 && onechose == 0)
                    {
                        button1.Text = "X";
                        button1.Enabled = false;
                        onechose = 1;
                    }
                    else if (which == 2 && onechose == 0)
                    {
                        button2.Text = "X";
                        button2.Enabled = false;
                        onechose = 1;
                    }
                    else if (which == 3 && onechose == 0)
                    {
                        button3.Text = "X";
                        button3.Enabled = false;
                        onechose = 1;
                    }
                    else if (which == 4 && onechose == 0)
                    {
                        button4.Text = "X";
                        button4.Enabled = false;
                        onechose = 1;
                    }
                    ///becuse the button clicked by player
                    /* else if (which == 5)
                     {
                         button5.Text = "X";
                         button5.Enabled = false;
                     }*/
                    else if (which == 6 && onechose == 0)
                    {
                        button6.Text = "X";
                        button6.Enabled = false;
                        onechose = 1;
                    }
                    else if (which == 7 && onechose == 0)
                    {
                        button7.Text = "X";
                        button7.Enabled = false;
                        onechose = 1;
                    }
                    else if (which == 8 && onechose == 0)
                    {
                        button8.Text = "X";
                        button8.Enabled = false;
                        onechose = 1;
                    }
                    else if (which == 9 && onechose == 0)
                    {
                        button9.Text = "X";
                        button9.Enabled = false;
                        onechose = 1;
                    }
                }
            }
            else
            {

                if (button5.Text == "")
                {
                    onechose = 1;
                    button5.Text = "X";
                    button5.Enabled = false;
                }
            }


            //////////////////////////Defence///////////////////////////////
            //////////////////////////Defence///////////////////////////////
            //////////////////////////Defence///////////////////////////////
            //////////////////////////Defence///////////////////////////////
            //////////////////////////Defence///////////////////////////////
            //////////////////////////Defence///////////////////////////////
            //////////////////////////Defence///////////////////////////////

            //top
            //OO-
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "" && onechose == 0)
            {

                button3.Text = "X";
                button3.Enabled = false;
                onechose = 1;

            }
            //top
            //-OO
            if (button1.Text == "" && button2.Text == "O" && button3.Text == "O" && onechose == 0)
            {

                button1.Text = "X";
                button1.Enabled = false;
                onechose = 1;

            }
            //top
            //O-O
            if (button1.Text == "O" && button2.Text == "" && button3.Text == "O" && onechose == 0)
            {

                button2.Text = "X";
                button2.Enabled = false;
                onechose = 1;

            }





            //center
            //OO-
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "" && onechose == 0)
            {

                button6.Text = "X";
                button6.Enabled = false;
                onechose = 1;

            }
            //center
            //-OO
            if (button4.Text == "" && button5.Text == "O" && button6.Text == "O" && onechose == 0)
            {

                button4.Text = "X";
                button4.Enabled = false;
                onechose = 1;

            }
            //center
            //O-O
            if (button4.Text == "O" && button5.Text == "" && button6.Text == "O" && onechose == 0)
            {

                button5.Text = "X";
                button5.Enabled = false;
                onechose = 1;

            }



            //down
            //OO-
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "" && onechose == 0)
            {

                button9.Text = "X";
                button9.Enabled = false;
                onechose = 1;

            }
            //down
            //-OO
            if (button7.Text == "" && button8.Text == "O" && button9.Text == "O" && onechose == 0)
            {

                button7.Text = "X";
                button7.Enabled = false;
                onechose = 1;

            }
            //down
            //O-O
            if (button7.Text == "O" && button8.Text == "" && button9.Text == "O" && onechose == 0)
            {

                button8.Text = "X";
                button8.Enabled = false;
                onechose = 1;

            }




            ////////////////////////////////

            //left
            //O
            //O
            //-
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "" && onechose == 0)
            {

                button7.Text = "X";
                button7.Enabled = false;
                onechose = 1;

            }


            //left
            //O
            //-
            //O
            if (button1.Text == "O" && button4.Text == "" && button7.Text == "O" && onechose == 0)
            {

                button4.Text = "X";
                button4.Enabled = false;
                onechose = 1;

            }

            //left
            //-
            //O
            //O
            if (button1.Text == "" && button4.Text == "O" && button7.Text == "O" && onechose == 0)
            {

                button1.Text = "X";
                button1.Enabled = false;
                onechose = 1;

            }






            //center
            //O
            //O
            //-
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "" && onechose == 0)
            {

                button8.Text = "X";
                button8.Enabled = false;
                onechose = 1;

            }


            //center
            //O
            //-
            //O
            if (button2.Text == "O" && button5.Text == "" && button8.Text == "O" && onechose == 0)
            {

                button5.Text = "X";
                button5.Enabled = false;
                onechose = 1;

            }

            //center
            //-
            //O
            //O
            if (button2.Text == "" && button5.Text == "O" && button8.Text == "O" && onechose == 0)
            {

                button2.Text = "X";
                button2.Enabled = false;
                onechose = 1;

            }







            //right
            //O
            //O
            //-
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "" && onechose == 0)
            {

                button9.Text = "X";
                button9.Enabled = false;
                onechose = 1;

            }


            //right
            //O
            //-
            //O
            if (button3.Text == "O" && button6.Text == "" && button9.Text == "O" && onechose == 0)
            {

                button6.Text = "X";
                button6.Enabled = false;
                onechose = 1;

            }

            //right
            //-
            //O
            //O
            if (button3.Text == "" && button6.Text == "O" && button9.Text == "O" && onechose == 0)
            {

                button3.Text = "X";
                button3.Enabled = false;
                onechose = 1;

            }







          
              //O
             //O
            //-
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "" && onechose == 0)
            {

                button7.Text = "X";
                button7.Enabled = false;
                onechose = 1;

            }


              //O
             //-
            //O
            if (button3.Text == "O" && button5.Text == "" && button7.Text == "O" && onechose == 0)
            {

                button5.Text = "X";
                button5.Enabled = false;
                onechose = 1;

            }

            
              //-
             //O
            //O
            if (button3.Text == "" && button5.Text == "O" && button7.Text == "O" && onechose == 0)
            {

                button3.Text = "X";
                button3.Enabled = false;
                onechose = 1;

            }







            //O
             //O
              //-
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "" && onechose == 0)
            {

                button9.Text = "X";
                button9.Enabled = false;
                onechose = 1;

            }


            //O
             //-
              //O
            if (button1.Text == "O" && button5.Text == "" && button9.Text == "O" && onechose == 0)
            {

                button5.Text = "X";
                button5.Enabled = false;
                onechose = 1;

            }


            //-
             //O
              //O
            if (button1.Text == "" && button5.Text == "O" && button9.Text == "O" && onechose==0)
            {

                button1.Text = "X";
                button1.Enabled = false;
                onechose = 1;

            }


            //////////////////////////Attack///////////////////////////////
            //////////////////////////Attack///////////////////////////////
            //////////////////////////Attack///////////////////////////////
            //////////////////////////Attack///////////////////////////////
            //////////////////////////Attack///////////////////////////////
            //////////////////////////Attack///////////////////////////////
            //////////////////////////Attack///////////////////////////////

            //left
            //X
            //X
            //-
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "" && onechose == 0)
            {

                button7.Text = "X";
                button7.Enabled = false;
                onechose = 1;

            }

            //left
            //X
            //-
            //X
            if (button1.Text == "X" && button4.Text == "" && button7.Text == "X" && onechose == 0)
            {

                button4.Text = "X";
                button4.Enabled = false;
                onechose = 1;

            }

            //left
            //-
            //X
            //X
            if (button1.Text == "" && button4.Text == "X" && button7.Text == "X" && onechose == 0)
            {

                button1.Text = "X";
                button1.Enabled = false;
                onechose = 1;

            }





            //center
            //X
            //X
            //-
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "" && onechose == 0)
            {

                button8.Text = "X";
                button8.Enabled = false;
                onechose = 1;

            }

            //center
            //X
            //-
            //X
            if (button2.Text == "X" && button5.Text == "" && button8.Text == "X" && onechose == 0)
            {

                button5.Text = "X";
                button5.Enabled = false;
                onechose = 1;

            }

            //center
            //-
            //X
            //X
            if (button2.Text == "" && button5.Text == "X" && button8.Text == "X" && onechose == 0)
            {

                button2.Text = "X";
                button2.Enabled = false;
                onechose = 1;

            }




            //right
            //X
            //X
            //-
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "" && onechose == 0)
            {

                button9.Text = "X";
                button9.Enabled = false;
                onechose = 1;

            }

            //right
            //X
            //-
            //X
            if (button3.Text == "X" && button6.Text == "" && button9.Text == "X" && onechose == 0)
            {

                button6.Text = "X";
                button6.Enabled = false;
                onechose = 1;

            }

            //right
            //-
            //X
            //X
            if (button3.Text == "" && button6.Text == "X" && button9.Text == "X" && onechose == 0)
            {

                button3.Text = "X";
                button3.Enabled = false;
                onechose = 1;

            }







            //top
           //XX-
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "" && onechose == 0)
            {

                button3.Text = "X";
                button3.Enabled = false;
                onechose = 1;

            }

            //top
            //X-X
            if (button1.Text == "X" && button2.Text == "" && button3.Text == "X" && onechose == 0)
            {

                button2.Text = "X";
                button2.Enabled = false;
                onechose = 1;

            }

            //top
            //-XX
            if (button1.Text == "" && button2.Text == "X" && button3.Text == "X" && onechose == 0)
            {

                button1.Text = "X";
                button1.Enabled = false;
                onechose = 1;

            }






            //center
            //XX-
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "" && onechose == 0)
            {

                button6.Text = "X";
                button6.Enabled = false;
                onechose = 1;

            }

            //center
            //X-X
            if (button4.Text == "X" && button5.Text == "" && button6.Text == "X" && onechose == 0)
            {

                button5.Text = "X";
                button5.Enabled = false;
                onechose = 1;

            }

            //center
            //-XX
            if (button4.Text == "" && button5.Text == "X" && button6.Text == "X" && onechose == 0)
            {

                button4.Text = "X";
                button4.Enabled = false;
                onechose = 1;

            }






            //down
            //XX-
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "" && onechose == 0)
            {

                button9.Text = "X";
                button9.Enabled = false;
                onechose = 1;

            }

            //down
            //X-X
            if (button7.Text == "X" && button8.Text == "" && button9.Text == "X" && onechose == 0)
            {

                button8.Text = "X";
                button8.Enabled = false;
                onechose = 1;

            }

            //down
            //-XX
            if (button7.Text == "" && button8.Text == "X" && button9.Text == "X" && onechose == 0)
            {

                button7.Text = "X";
                button7.Enabled = false;
                onechose = 1;

            }








              //X
             //X
            //-
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "" && onechose == 0)
            {

                button7.Text = "X";
                button7.Enabled = false;
                onechose = 1;

            }


              //X
             //-
            //X
            if (button3.Text == "X" && button5.Text == "" && button7.Text == "X" && onechose == 0)
            {

                button5.Text = "X";
                button5.Enabled = false;
                onechose = 1;

            }


              //-
             //X
            //X
            if (button3.Text == "" && button5.Text == "X" && button7.Text == "X" && onechose == 0)
            {

                button3.Text = "X";
                button3.Enabled = false;
                onechose = 1;

            }







            //X
             //X
              //-
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "" && onechose == 0)
            {

                button9.Text = "X";
                button9.Enabled = false;
                onechose = 1;

            }


            //X
             //-
              //X
            if (button1.Text == "X" && button5.Text == "" && button9.Text == "X" && onechose == 0)
            {

                button5.Text = "X";
                button5.Enabled = false;
                onechose = 1;

            }


            //-
             //X
              //X
            if (button1.Text == "" && button5.Text == "X" && button9.Text == "X" && onechose == 0)
            {

                button1.Text = "X";
                button1.Enabled = false;
                onechose = 1;

            }





            if (button1.Text == "" && onechose == 0)
            {
                button1.Text = "X";
                button1.Enabled = false;
                onechose = 1;
            }
            else if (button2.Text == "" && onechose == 0)
            {
                button2.Text = "X";
                button2.Enabled = false;
                onechose = 1;
            }
            else if (button3.Text == "" && onechose == 0)
            {
                button3.Text = "X";
                button3.Enabled = false;
                onechose = 1;
            }
            else if (button4.Text == "" && onechose == 0)
            {
                button4.Text = "X";
                button4.Enabled = false;
                onechose = 1;
            }
            else if (button5.Text == "" && onechose == 0)
            {
                button5.Text = "X";
                button5.Enabled = false;
                onechose = 1;
            }
            else if (button6.Text == "" && onechose == 0)
            {
                button6.Text = "X";
                button6.Enabled = false;
                onechose = 1;
            }
            else if (button7.Text == "" && onechose == 0)
            {
                button7.Text = "X";
                button7.Enabled = false;
                onechose = 1;
            }
            else if (button8.Text == "" && onechose == 0)
            {
                button8.Text = "X";
                button8.Enabled = false;
                onechose = 1;
            }
            else if (button9.Text == "" && onechose == 0)
            {
                button9.Text = "X";
                button9.Enabled = false;
                onechose = 1;
            }
            






























            whois_win();

            onechose = 0;
        }












        void whois_win()
        {
            int dreow = 0;
            //left
            //X 
            //X
            //X
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Red; button4.BackColor = Color.Red; button7.BackColor = Color.Red;
                MessageBox.Show("Cpu Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;

            }

            //center
            //X
            //X
            //X
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = Color.Red; button5.BackColor = Color.Red; button8.BackColor = Color.Red;
                MessageBox.Show("Cpu Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;
            }

            //Right
            //X
            //X
            //X
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = Color.Red; button6.BackColor = Color.Red; button9.BackColor = Color.Red;
                MessageBox.Show("Cpu Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;
            }




            //top
            //XXX
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.Red; button2.BackColor = Color.Red; button3.BackColor = Color.Red;
                MessageBox.Show("Cpu Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;
            }

            //center
            //XXX
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Red; button5.BackColor = Color.Red; button6.BackColor = Color.Red;
                MessageBox.Show("Cpu Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;
            }

            //down
            //XXX
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Red; button8.BackColor = Color.Red; button9.BackColor = Color.Red;
                MessageBox.Show("Cpu Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;
            }









              //X
             //X
            //X
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = Color.Red; button5.BackColor = Color.Red; button7.BackColor = Color.Red;

                MessageBox.Show("Cpu Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;
            }

            //X
             //X
              //X
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Red; button5.BackColor = Color.Red; button9.BackColor = Color.Red;

                MessageBox.Show("Cpu Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;
            }












            //left
            //O 
            //O
            //O
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = Color.Green; button4.BackColor = Color.Green; button7.BackColor = Color.Green;
                MessageBox.Show("You Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;
            }

            //center
            //O
            //O
            //O
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = Color.Green; button5.BackColor = Color.Green; button8.BackColor = Color.Green;
                MessageBox.Show("You Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;
            }

            //Right
            //O
            //O
            //O
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = Color.Green; button6.BackColor = Color.Green; button9.BackColor = Color.Green;
                MessageBox.Show("You Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;
            }




            //top
            //OOO
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = Color.Green; button2.BackColor = Color.Green; button3.BackColor = Color.Green;
                MessageBox.Show("You Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;
            }

            //center
            //OOO
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = Color.Green; button5.BackColor = Color.Green; button6.BackColor = Color.Green;
                MessageBox.Show("You Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;
            }

            //down
            //OOO
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = Color.Green; button8.BackColor = Color.Green; button9.BackColor = Color.Green;
                MessageBox.Show("You Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;
            }









              //O
             //O
            //O
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = Color.Green; button5.BackColor = Color.Green; button7.BackColor = Color.Green;

                MessageBox.Show("You Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;
            }

            //O
             //O
              //O
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                
                button1.BackColor = Color.Green; button5.BackColor = Color.Green; button9.BackColor = Color.Green;
                MessageBox.Show("You Win!!");
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
                button4.Enabled = false; button5.Enabled = false; button6.Enabled = false;
                button7.Enabled = false; button8.Enabled = false; button9.Enabled = false;
                dreow = 1;
            }


            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false && dreow==0)
            {
                if(MessageBox.Show("The Game Dreaw.Do You Want Start New Game ? ", "Notic", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)==DialogResult.OK)
                                {
                    button1.Text = ""; button2.Text = ""; button3.Text = "";
                    button4.Text = ""; button5.Text = ""; button6.Text = "";
                    button7.Text = ""; button8.Text = ""; button9.Text = "";
                    button1.Enabled = true; button2.Enabled = true; button3.Enabled = true;
                    button4.Enabled = true; button5.Enabled = true; button6.Enabled = true;
                    button7.Enabled = true; button8.Enabled = true; button9.Enabled = true;
                    button1.BackColor = Color.Gray; button2.BackColor = Color.Gray; button3.BackColor = Color.Gray;
                    button4.BackColor = Color.Gray; button5.BackColor = Color.Gray; button6.BackColor = Color.Gray;
                    button7.BackColor = Color.Gray; button8.BackColor = Color.Gray; button9.BackColor = Color.Gray;
                    fristmove = false;
                    secondchek = false;
                    onechose = 0;


                }
                else { Application.Exit(); }



            }
        }













        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "O";
            button1.Enabled = false;
            fristmove = true;
            cpu_mind();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "O";
            button2.Enabled = false;
            fristmove = true;
            cpu_mind();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "O";
            button3.Enabled = false;
            fristmove = true;
            cpu_mind();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "O";
            button4.Enabled = false;
            fristmove = true;
            cpu_mind();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "O";
            button5.Enabled = false;
            fristmove = true;
            cpu_mind();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "O";
            button6.Enabled = false;
            fristmove = true;
            cpu_mind();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "O";
            button7.Enabled = false;
            fristmove = true;
            cpu_mind();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "O";
            button8.Enabled = false;
            fristmove = true;
            cpu_mind();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "O";
            button9.Enabled = false;
            fristmove = true;
            cpu_mind();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Let Start New Game...");
            button1.Text = ""; button2.Text = ""; button3.Text = "";
            button4.Text = ""; button5.Text = ""; button6.Text = "";
            button7.Text = ""; button8.Text = ""; button9.Text = "";
            button1.Enabled = true; button2.Enabled = true; button3.Enabled = true;
            button4.Enabled = true; button5.Enabled = true; button6.Enabled = true;
            button7.Enabled = true; button8.Enabled = true; button9.Enabled = true;
            button1.BackColor = Color.Gray; button2.BackColor = Color.Gray; button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray; button5.BackColor = Color.Gray; button6.BackColor = Color.Gray;
            button7.BackColor = Color.Gray; button8.BackColor = Color.Gray; button9.BackColor = Color.Gray;
            fristmove = false;
            secondchek = false;
            onechose = 0;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

     
       

     

       
    }
}