using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThemeParkProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Declarations and Assignments

        string strName; //Name of Guest
        string strSeason; //Name of Season
        string strPark; //Name of Park
        string strAttraction; //Name of Attraction
        
        int intAge; //Age
        int intTemp; //Temperature

        bool blnOpen = true; //Park Closed Flag
        bool blnError = false; //Invalid Input Flag

        //Button RecomMend Code

        private void btnRecommend_Click(object sender, EventArgs e)
        {
            //Reset Pictures

            picAmusement.Visible = false;
            picSki.Visible = false;
            picWater.Visible = false;
            picStormLandClosed.Visible = false;

            //Reset Flags

            blnOpen = true;
            blnError = false;

            //Retrieve Name from Text Box and Trim
            strName = txtName.Text;
            strName = strName.Trim();

            //Retrieve Age from Text Box and Catch Invalid Input

            try
            {
                intAge = Int32.Parse(txtAge.Text);
            }
            catch
            {
                blnError = true; //set blnError to true
                MessageBox.Show("You did not enter a valid Age.", "Invlaid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            //Retrieve Season from Text box and Trim and covert to lower case.

                strSeason = txtSeason.Text;
                strSeason = strSeason.Trim();
                strSeason = strSeason.ToLower();


            //Convert to first two letters with Substring, and catch Invalid Input
                
            try
            {
                strSeason = strSeason.Substring(0, 2);

                if ((strSeason != "wi") && (strSeason != "sp") && (strSeason != "su") && (strSeason != "fa"))
                {
                    blnError = true;
                    MessageBox.Show("You did not enter a valid Season.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                blnError = true;
                MessageBox.Show("You did not enter a valid Season.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

           /// var strSeasonOptions = new List<string>() { "wi", "sp", "su", "fa" };
           // if (strSeasonOptions.Contains(strSeason, StringComparer.OrdinalIgnoreCase))
           // {
           // }
           // else
           // {
            //    blnError = true;
           //     MessageBox.Show("You did not enter a valid Season.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }


            //Retrieve Temperature from Text Box and catch Invalid Input

            if (int.TryParse(txtTemp.Text, out intTemp))
            {
            }
            else
            {
                blnError = true; //set blnError to true
                MessageBox.Show("You did not enter a valid Temperature.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

//////////////////////////////Recommendation If Statement////////////////////////////////////////////////

            if (blnError == false)
            {
                if (strSeason == "wi") //Check if its Winter
                {
                    //set Season String to Winter for Output
                    strPark = "Ski Park";

                    if (intTemp <= 50) //check temperature
                    {
                        picStormLand.Visible = false; //disable Storm Land Pic
                        picSki.Visible = true; //enable Ski Resort Pic

                        //Check Age and set Attraction Name

                        if (intAge <= 6)
                            strAttraction = "Snow Drift Slope";
                        else if ((intAge <= 13) && (intAge >= 7))
                            strAttraction = "Blizzard Slope";
                        else if (intAge >= 14)
                            strAttraction = "Avalanche Slope";
                    }

                    else //Close Park and Change Pictures
                    {
                        blnOpen = false; //set park to close
                    }
                }

                else if (strSeason == "su")
                {
                    strSeason = "Summer";

                    if (intTemp >= 74) //check temperature
                    {
                        strPark = "Water Park";

                        picStormLand.Visible = false; //disable Storm Land Pic
                        picWater.Visible = true; //enable Water Park Pic
                        
                        //Check Age and set Attraction Name

                        if (intAge <= 6)
                            strAttraction = "Rain Storm";
                        else if ((intAge <= 13) && (intAge >= 7))
                            strAttraction = "Summer Storm";
                        else if (intAge >= 14)
                            strAttraction = "Thunder Storm";
                    }
                    else
                    {

                        strPark = "Amusment Park";

                        picStormLand.Visible = false; //disable Storm Land Pic
                        picAmusement.Visible = true; //enable Amusement Park Pic

                        //Check Age and set Attraction Name

                        if (intAge <= 6)
                            strAttraction = "Lil' Tornado";
                        else if ((intAge <= 13) && (intAge >= 7))
                            strAttraction = "Storm Chaser";
                        else if (intAge >= 14)
                            strAttraction = "Storm Buster";
                    }

               }

               else if ((strSeason == "sp") | (strSeason == "fa")) //Check if Spring or Fall
               {

                    strPark = "Amusment Park"; //Reset 
 
                    picStormLand.Visible = false; //Disable Storm Land Pic
                    picAmusement.Visible = true; //Enable Amusement Park Pic

                    //Check Age and set Attraction Name

                    if (intAge <= 6)
                        strAttraction = "Lil' Tornado";
                    else if ((intAge <= 13) && (intAge >= 7))
                        strAttraction = "Storm Chaser";
                    else if (intAge >= 15)
                        strAttraction = "Storm Buster";
                }

//////////////////////Output//////////////////////////////

                switch (strSeason) //Convert 2 Letter season abbreviations back to full spelling
                {
                    case "wi":
                        strSeason = "Winter";
                        break;
                    case "sp":
                        strSeason = "Spring";
                        break;
                    case "su":
                        strSeason = "Summer";
                        break;
                    case "fa":
                        strSeason = "Fall";
                        break;
                }

                if (blnOpen == true) //Display Reccomendatino if Park is Opened
                {
                    lblPark.Text = strPark;
                    lblAttraction.Text = strAttraction;

                    MessageBox.Show(strName + ", because you are " + intAge + " and it is " + intTemp + " degrees this " + strSeason + " you should ride the "
                    + strAttraction + " in the " + strPark + "!", "Our Reccomendation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else  ///Display Message Box indicating Park is closed due to Temparture                {

                    picStormLand.Visible = false; //disable Storm Land Pic
                    picStormLandClosed.Visible = true; //enable Storm Land Closed Pic

                    lblPark.Text = ""; //Clears lblPark
                    lblAttraction.Text = ""; //Clears lblAttraction

                    //Displays Message Box
                    MessageBox.Show(strName + ", because it is " + intTemp + " degrees this " + strSeason + " all our parks are closed. We're sorry. :(",
                    "Our Reccomendation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }



        //Clear and Reset

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Reset Variables and Declarations

            strName = ""; //Name of Guest
            strSeason = ""; //Name of Season
            strPark = ""; //Name of Park
            strAttraction = ""; //Name of Attraction

            intAge = 0; //Age
            intTemp = 0; //Temperature

            blnOpen = true; //Park Closed Flag
            blnError = false; //Invalid Input Flag

            //Reset Text Boxes

            txtName.Text = "";
            txtAge.Text = "";
            txtSeason.Text = "";
            txtTemp.Text = "";

            //Reset Labels

            lblPark.Text = "";
            lblAttraction.Text = "";

            //Reset Pictures

            picAmusement.Visible = false;
            picSki.Visible = false;
            picWater.Visible = false;
            picStormLandClosed.Visible = false;
            picStormLand.Visible = true;

            //Reset Focus
            txtName.Focus();
        }

        //Close the Program


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //Disable Recommend Button until Items have been input into Text Boxes
    }
}

