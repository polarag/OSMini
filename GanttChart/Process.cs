using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    class Process
    {
        public readonly int priority;
        public  int time;
        public readonly int id;
        public readonly int arrivaltime;
        public readonly System.Drawing.Color color;
        public Process(int id, int time, int priority)
        {
            this.id = id;
            this.time = time;
            this.priority = priority;
            this.color = System.Drawing.Color.White;
        }
        public Process(int id, int time, int priority, int arrivaltime)
        {
            this.id = id;
            this.time = time;
            this.priority = priority;
            this.arrivaltime = arrivaltime;
            this.color = System.Drawing.Color.White;
        }
        public Process(int id, int time, int priority, int arrivaltime, System.Drawing.Color color)
        {
            this.id = id;
            this.time = time;
            this.priority = priority;
            this.arrivaltime = arrivaltime;
            this.color = color;
        }
        public void SetTime(int time)
        {
            this.time = time;
        }
    }
}
