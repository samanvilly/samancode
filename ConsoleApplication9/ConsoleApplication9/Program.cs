using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    public class Program
    {
        private string id;
        private string name;
        private string lastname;
        private int hours;
        private int payperonhoure;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        public int Payperhour
        {
            get { return payperonhoure; }
            set
            {
                if (value > 0)
                {
                    payperonhoure = value;
                }
            }
        }
        public long Teacher() { }
        public long Teacher(string id, string name, string lastname, int hours, int payperhour) {
            id = Id;
            name = Name;
            lastname = Lastname;
            hours = Hours;
            payperhour = Payperhour;
        }
        public long payment()
        {
            return hours * payperonhoure;
        }
        static void Main(string[] args)
        {
          
        }
    }
}
