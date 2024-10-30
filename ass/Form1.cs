﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace ass
{
    public partial class Form1 : Form
    {
        int page = 1;

        public Form1()

        {
            InitializeComponent();
            outputBox.Text = "you are walking in a dark alley and discover a haunted house do you enter through the front door or back door";
            option1.Text = "front door ";
            option2.Text = "back door";
            imageBox.Image = ass.Properties.Resources.haunted_house_start;


        }
        SoundPlayer win = new SoundPlayer(Properties.Resources.win);

        private void option1Button_Click(object sender, EventArgs e)
        {

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 99;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {

                Random randGen = new Random();
                int random = randGen.Next(0, 100);
                if (random > 50)
                {
                    page = 10;
                }
                else
                {
                    page = 11;
                }

            }
            else if (page == 7)
            {
                page = 99;
            }



            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 21;
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 99;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 99)
            {
                page = 1;
            }

            DisplayPage();


        }

        private void option2Button_Click(object sender, EventArgs e)
        {


            if (page == 1)
            {
                page = 12;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 20)
            {
                page = 22;
            }
            else if (page == 22)
            {
                page = 99;
            }
            else if (page == 6)
            {

                Random randGen = new Random();
                int random = randGen.Next(0, 100);
                if (random > 50)
                {
                    page = 10;
                }
                else
                {
                    page = 11;
                }
                
            }

            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 99;
            }

            else if (page == 13)
            {
                page = 15;
            }
          


            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 17;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 99;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 20;
            }
            else if (page == 20)
            {
                page = 21;
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 22)
            {
                page = 99;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 99)
            {
                page = 100;
            }
           
                         
               

            DisplayPage();



        }
        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 2)
            {
                page = 3;
            }
            DisplayPage();
        }

        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    imageBox.Image = ass.Properties.Resources.haunted_house_start;
                    outputBox.Text = "you find a haunted house";
                    option1.Text = "front door";
                    option2.Text = "back door";
                    option3.Text = "";

                    break;
                case 2:
                    imageBox.Image = ass.Properties.Resources.haunted_house_start;
                    outputBox.Text = "as you enter the front door opens on its own ";
                    option1.Text = "go upstairs";
                    option2.Text = "living room";
                    option3.Text = "leave";

                    break;
                case 3:
                    {
                        imageBox.Image = ass.Properties.Resources.you_died;
                        outputBox.Text = "as you are leaving you slip on the pavemnet and die ";
                        option1.Text = "Click";
                        option2.Text = "...";
                        option3.Text = "...";
                    }
                    break;
                case 4:
                    {
                        imageBox.Image = ass.Properties.Resources.haunted_living_room;
                        outputBox.Text = "as you step in the living room you get paralzyed and die standing up";
                        option1.Text = "Click";
                        option2.Text = "";
                        option3.Text = "";
                    }
                    break;
                case 5:
                    {
                        imageBox.Image = ass.Properties.Resources.haunted_staris;
                        outputBox.Text = "as you go up the stairs you hear a scream coming from the bedroom";
                        option1.Text = "bathroom";
                        option2.Text = "bedroom";
                        option3.Text = "";
                    }
                    break;
                case 6:
                    imageBox.Image = ass.Properties.Resources.bathrrom;
                    outputBox.Text = "writien on the wall with blood it say say bloody mary 3 times in the mirro";
                    option1.Text = "say it 3 times";
                    option2.Text = "leave the bathroom";
                    option3.Text = "";

                    break;
                case 7:
                    {
                        imageBox.Image = ass.Properties.Resources.haunted_bedroom;
                        outputBox.Text = "as you go in the girl crying jumps on you and rips you apart leading to your death";
                        option1.Text = "Click";
                        option2.Text = "...";
                        option3.Text = "...";
                    }
                    break;
                case 8:
                    {
                        outputBox.Text = "";
                        option1.Text = "";
                        option2.Text = "";
                        option3.Text = "";
                    }
                    break;
                case 9:
                    {
                        imageBox.Image = ass.Properties.Resources.bloody_marry;
                        outputBox.Text = "as you try to leave she pops in front of you and snaps your neck";
                        option1.Text = "Click";
                        option2.Text = "...";
                        option3.Text = "...";
                    }
                    break;
                case 10:
                    {
                        imageBox.Image = ass.Properties.Resources.bloody_marry;
                        outputBox.Text = "you say bloddy mary 3 times and she appres in front of the mirror you talk to her but she gets bored and kills you";
                        option1.Text = "Click";
                        option2.Text = "...";
                        option3.Text = "...";
                    }
                    break;
                case 11:
                    {
                        imageBox.Image = ass.Properties.Resources.bloody_marry;
                        outputBox.Text = "you say bloody mary 3 times and she appres in fron of the mirror you talk to her and she likes you and helps you escape you win";
                        option1.Text = "Click";
                        option2.Text = "...";
                        option3.Text = "...";
                    }
                    break;
                case 12:
                    {
                        imageBox.Image = ass.Properties.Resources.haunted_back_door;
                        outputBox.Text = "do you go to the kitchen or basment";
                        option1.Text = "kitehcn";
                        option2.Text = "basment";
                        option3.Text = "leave";
                    }
                    break;
                case 13:
                    {
                        imageBox.Image = ass.Properties.Resources.haunted_kitchen;
                        outputBox.Text = "as you enter the kithen a rat jumpcares you do you grab a kife or not";
                        option1.Text = "grab it";
                        option2.Text = "dont grab it";
                        option3.Text = "...";
                    }
                    break;
                case 14:
                    {
                        imageBox.Image = ass.Properties.Resources.ghost;
                        outputBox.Text = "a ghost appres and trys to attack you but you kill it with the kife. do you run out the house or stay";
                        option1.Text = "run";
                        option2.Text = "stay";
                        option3.Text = "...";
                    }
                    break;
                case 15:
                    {
                        imageBox.Image = ass.Properties.Resources.ghost;
                        outputBox.Text = "a ghost appres and kills you because you didnt have a wepon";
                        option1.Text = "Click";
                        option2.Text = "...";
                        option3.Text = "...";
                    }
                    break;
                case 16:
                    {
                        imageBox.Image = ass.Properties.Resources.you_win;
                        outputBox.Text = "you run out the house and stay alive";
                        option1.Text = "Click";
                        option2.Text = "...";
                        option3.Text = "...";
                    }
                    break;
                case 17:
                    {
                        imageBox.Image = ass.Properties.Resources.you_died;
                        outputBox.Text = "another ghost appres and takes your kife and stabs you";
                        option1.Text = "Click";
                        option2.Text = "...";
                        option3.Text = "...";
                    }
                    break;
                case 18:
            
                    imageBox.Image = ass.Properties.Resources.you_died;
                    outputBox.Text = "you leave but as you are leaving a ghost comes and kills you";
                        option1.Text = "Click";
                        option2.Text = "...";
                        option3.Text = "...";
                    
                    break;
                case 19:
                    {
                        imageBox.Image = ass.Properties.Resources.basement_staris;
                        outputBox.Text = "you are going down the staris but slip and fall down";
                        option1.Text = "explore";
                        option2.Text = "run back up";
                        option3.Text = "...";
                    }
                    break;
                case 20:
                    {
                        imageBox.Image = ass.Properties.Resources.basment_monster;
                        outputBox.Text = "you explore but as you turn you see a monster";
                        option1.Text = "say hi";
                        option2.Text = "try to leave";
                        option3.Text = "...";
                    }
                    break;
                case 21:
                    {
                        imageBox.Image = ass.Properties.Resources.you_win;
                        outputBox.Text = "you guys talk and become firends and he helps you escape";
                        option1.Text = "Click";
                        option2.Text = "...";
                        option3.Text = "...";
                    }
                    break;
                case 22:
                    {
                        imageBox.Image = ass.Properties.Resources.you_died;
                        outputBox.Text = "the monster lunges at you and claws you to death";
                        option1.Text = "Click";
                        option2.Text = "...";
                        option3.Text = "...";
                    }
                    break;
                case 23:
                    {
                        imageBox.Image = ass.Properties.Resources.basement;
                        outputBox.Text = "you try to run back upstaris but you slip, fall and die";
                        option1.Text = "Click";
                        option2.Text = "...";
                        option3.Text = "...";
                    }
                    break;
                case 99:
                    {
                        
                        imageBox.Image = ass.Properties.Resources.quetion;
                        outputBox.Text = "Game over. Do you want to play again";
                        option1.Text = "yes";
                        option2.Text = "no";
                        option3.Text = "...";
                        win.Play();
                       
                    }
                    break;
                case 100:
                    {
                        Thread.Sleep(2000);
                        Refresh();
                        Close();
                    }
                    break;
            }
        }


    }
}





