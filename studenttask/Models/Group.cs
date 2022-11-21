using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace studenttask.Models
{
    internal class Group
    {
        private string _no;
        private Students[] _student;
        private byte _studentLimit;

        public string No
        {
            get
            {
                return _no;
            }
            set
            {
                value = value.Trim();
                Regex regex= new Regex("^[A-Z]{2}[0-9]{3}$");
                if ( regex.IsMatch(value)==true)
                {
                    _no = value;
                    Console.WriteLine("Group Name:" + value);
                }
                else
                {
                    Console.WriteLine("Wrong group name");
                }
            }
        }
        public Group(string No,byte StudentLimit)
        {
            _student = new Students[0];
            this.No = No;
            this.StudentLimit = StudentLimit;
        }
        public void Add(Students student)
        {
            Array.Resize(ref _student, _student.Length + 1);
            _student[_student.Length - 1] = student;
        }
        public void FilterByName(string symbol)
        {
            Console.WriteLine("Filtered fullname:");
            symbol=symbol.ToLower();
            string full = null;
            for (int i = 0; i < _student.Length; i++)
            {
                string Fullname = _student[i].Name +" " + _student[i].Surname;
                full = _student[i].Name.ToLower() + _student[i].Surname.ToLower();
                if (full.Contains(symbol) == true)
                {
                    Console.WriteLine(Fullname);
                }
            }

        }
        public byte StudentLimit
            {
            get { return _studentLimit; }
            set
            {
                if(value<=18 && value >= 5)
                {
                    _studentLimit = value;
                }
                else
                {
                    Console.WriteLine("yeteri qeder sagird yoxdu");
                }
            }
            }
    }
}
