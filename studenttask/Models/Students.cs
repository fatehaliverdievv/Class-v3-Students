using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studenttask.Models
{
    internal class Students
    {
        private string _name;
        private string _surname;
        private byte _avgPoint;
        public string Name
        {
            get {return _name;}
            set 
            {   if(value.Trim().Length > 0 && value.Trim().Length<=26)
                { 
                  _name = value.Trim(); 
                }
                else
                {
                    Console.WriteLine("Wrong surname");
                }
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Trim().Length > 0 && value.Trim().Length <= 20)
                {
                    _surname = value.Trim();
                }
                else
                {
                    Console.WriteLine("Wrong name");
                }
            }
        }
        public byte AvgPoint
        {
            get
            {
                return _avgPoint;
            }
            set
            {
                if (value <= 100 & value >= 0)
                {
                    _avgPoint = value;
                }
                else
                {
                    Console.WriteLine("Wrong average point");

                }
            }
        }
        public Students(string name, string surname, byte avgpoint)
        {
            this.Name = name;
            this.Surname = surname;
            this.AvgPoint = avgpoint;
        }


    }
}
