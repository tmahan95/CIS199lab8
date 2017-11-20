using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Date
    {
        //date fields
        private int _month;
        private int _day;
        private int _year;

        //Precondition: 0 < month <= 12
        //              0 < day <= 31
        //              0 <= year
        //Postcondition: The date object will be initialized with the following day, month, and year
        //constructor
        public Date()
        {
            _month = 1;
            _day = 1;
            _year = 2000;
        }

        //Properties

        //Preconditions: _month >=1 and <=12
        //Postconditions: The month will be returned
        //Month
        public int Month
        {
            //precondition:
            //postcondition:
            get { return _month; }
            //precondition: month >=1 and <=31
            //postcondtion: month will be set by user
            set { if(value >=1 && value <=12)//when valid, set to user month
                _month = value; }
        }
        //Preconditions: day >=1 and <=31
        //Postconditions: the day will be returned
         //Day
         public int Day
         {
             //precondition: none
             //postcondition: the day will be returned
             get {return _day;}
             //precondtion:day >=1 and <=31
             //postcondition: day will be set by user
             set{if (value >=1 && value <=31)//if valid, set to user day
                 _day = value;}
         }
        //Preconditions: year >=0
        //Postconditions: year will be returned.
         //Year
         public int Year
         {
             //precondition:none
             //postcondition:year will be returned
             get { return _year; } 
             //precondition: year <=0
             //postdoncition:year will be set by user
             set {if(value >=0)//if valid, set to user year
                 _year = value; }
         }
        //Preconditions:None
        //Postconditions: a string with the date in the MM/DD/YYYY format will be returned.
         public override string ToString()
         {
             string result = Month.ToString("D2") + "/" + 
                 Day.ToString("D2") + "/" + Year.ToString("D4");//override the Object ToString method
             return result;
         }
        } 
    }