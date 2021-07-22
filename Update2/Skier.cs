using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExample
{
    public class Skier
    {
        private TimeSpan time;
        public TimeSpan Time
        {
            get => time;
            set
            {
                time = value;
            }
        }

        private string name;
        private string lastName;
        private string sex;

        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
            }
        }
        public string Sex
        {
            get => sex;
            set
            {
                sex = value;
            }
        }
        public Skier(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        public Skier()
        {
        }

        public string Team { get; set; }
        public override string ToString()
        {
            return $"{this.name} {this.lastName}";
        }
        //public string Team { get; set; }

        //public string Name { get; set; }
        //public string LastName { get; set; }
        //public string Sex { get; set; }


    }
}
