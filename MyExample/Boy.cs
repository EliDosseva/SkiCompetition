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
        public override string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        public Boy(string name)
        {
            this.name = name;
        }
        public override string Team { get; set; }
        public override string ToString()
        {
            return $"{this.name} - {Team}";
        }
    }
}
