using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExample
{
    public class Skier
    {
        private int id;
        private TimeSpan time;
        private string name;
        private string lastName;
        private string sex;
        private string team;


        public Skier()
        {
        }
        public int ID
        {
            get => id;
            set
            {
                id = value;
            }
        }
        public TimeSpan Time
        {
            get => time;
            set
            {
                time = value;
            }
        }
        
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

        public string Team
        {
            get => team;
            set
            {
                team = value;
            }
        }
           
    public override string ToString()
        {
            return $"{this.name} {this.lastName}";
        }
    }
}
