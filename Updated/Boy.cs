using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExample
{
    public class Boy:Skier
    {
        private string name;
        private string lastName;

        public override string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        public override string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
            }
        }
        public Boy(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
        public override string Team { get; set; }
        public override string ToString()
        {
            return $"{this.name} {this.lastName} - {Team}";
        }
    }
}
