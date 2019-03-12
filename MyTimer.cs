using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BEL
{
    public class MyTimer 
    {

        public  Notification notification;
        public Timer timer;

       public MyTimer(string to,string body)
        {
            notification = new Notification(to, body);
             timer = new Timer();

        }


        public void StartTimer()
        {
            timer.Enabled = true;
        }

        public void SetInterval(DateTime date)
        {
            int time;
            DateTime today = DateTime.Now;
            int delta = today.DayOfYear - date.DayOfYear;
            if (delta > 0)
            {
                time = DateTime.Parse("31/12/" + (today.Year)).DayOfYear - today.DayOfYear + 1 + DateTime.Parse(date.Day + "/" + date.Month + "/" + today.Year).DayOfYear;
            }
            else
            {
                time = delta * (-1);
            }
            Timer timer = new Timer();
            timer.Interval = time * 24 * 60 * 60 * 1000;

        }
        public void StopTimer()
        {
            timer.Stop();
        }
        public void BindAction(ElapsedEventHandler OnTimedEvent)
        {
            timer.Elapsed += OnTimedEvent;
        }
    }
}
