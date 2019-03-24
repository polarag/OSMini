using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanttChart
{
    class Process
    {
        public readonly int priority;
        public readonly int time;
        public readonly int id;
        public readonly int arrivaltime;
        public Process(int id, int time, int priority)
        {
            this.id = id;
            this.time = time;
            this.priority = priority;
        }
        public Process(int id, int time, int priority,int arrivaltime)
        {
            this.id = id;
            this.time = time;
            this.priority = priority;
            this.arrivaltime = arrivaltime;
        }
    }
}
