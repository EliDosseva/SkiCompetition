using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExample
{
    abstract public class Skier
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
        public abstract string Team { get; set; }
        
        public abstract string Name { get; set; }
        
    }
}
