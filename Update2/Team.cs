using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExample
{
    public class Team
    {        
        private string name;
        private TimeSpan averageTime;
        public Team(string name)
        {
            this.name = name;
        }

        public TimeSpan AverageTime
        {
            get => averageTime;
            set
            {
                averageTime = value;
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
        public override string ToString()
        {
            return $"{this.name}";
        }

        public override bool Equals(object obj)
        {
            var team = obj as Team;
            if (team == null)
                return false;

            return Name.Equals(team.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

    }
}
