using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PKE_1
{
   public class Izm
    {
        private string uid;
        private string name;
        private long timeStart;  
        private long timeStop; 
        private int averaging_interval_time;
        private string active_cxema;
     

        public string UID
        {
            get { return uid; }
            set { uid = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public long TimeStart
        {
            get { return timeStart; }
            set { timeStart = value; }
        }
        public long TimeStop
        {
            get { return timeStop; }
            set { timeStop = value; }
        }
        public int Averaging_interval_time
        {
            get { return averaging_interval_time; }
            set { averaging_interval_time = value; }
        }
        public string Active_cxema
        {
            get { return active_cxema; }
            set { active_cxema = value; }
        }
        public Izm()
        {

        }
        public Izm(string uid, string name, long timeStart, long timeStop, int averaging_interval_time, string active_cxema)
        {
            this.UID = uid;
            this.Name = name;
            this.TimeStart = timeStart;
            this.TimeStop = timeStop;
            this.Averaging_interval_time = averaging_interval_time;
            this.Active_cxema = active_cxema;
        }
    }
}
