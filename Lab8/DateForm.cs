//Timothy Mahan
//Lab 8
//Due: 4/19/2016
//Section: 01
//This program takes a date object and allows a user to manipulate it by entering different days, months, and years in the 
//corresponding text boxes. If the restrcitions set in the date object are not met, nothing changes, if the parse is not successful,
//and error message is displayed.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class DateForm : Form
    {
        public DateForm()
        {
            InitializeComponent();
        }
        private Date myDate = new Date();//new date object
         
        //precondition: year >= 0
        //postcondition: year will be set to user entry
        private void updateYearBttn_Click(object sender, EventArgs e)
        {
            int year = -1; //variable to hold year entered by user
            int.TryParse(yearTxtBox.Text, out year);//make sure year is a number
            myDate.Year = year;//set myDate.year to value entered by user
            dispLbl.Text = myDate.ToString(); //show year is dispLbl
        }

        //precondition: day > 0 and day <= 31
        //postcondition:day will be set to user entry
        private void updateDayBttn_Click(object sender, EventArgs e)
        {
            int day = -1;// variable to hold day entered by user
            int.TryParse(dayTxtBox.Text, out day);//day is number
            myDate.Day = day;//myDate day set to value user entered
            dispLbl.Text = myDate.ToString();//show day is dispLbl
        }

        //precondition: month >=1 and <= 12
        //postcondition: month will be set to user entry
        private void monthUpdateBttn_Click(object sender, EventArgs e)
        {
            int month = -1;//variable to hold month entered by user
            int.TryParse(monthTxtBox.Text, out month);//month is valid
            myDate.Month = month;//nyDate month set to value entered by user
            dispLbl.Text = myDate.ToString();//show month in disLbl
        }

        //precondition: none
        //postcondition: starting date will be visible in dispLbl
       private void makeDateObject(object sender, EventArgs e)
        {
            dispLbl.Text = myDate.ToString();//show month in disLbl
        }
    }
}
