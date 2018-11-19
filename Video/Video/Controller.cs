using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video
{
    class Controller
    {
        private void Start()
        {
            Console.WriteLine("Program start...");
        }
        private void Stop()
        {
            Console.WriteLine("Program stop...");
        }
        public void Run()
        {
            Start();
            InternalRun();
            Stop();
        }
        protected virtual void InternalRun()
        {
            Console.WriteLine("Program is running...");
        }
    }
    class SubController : Controller
    {
        protected override void InternalRun()
        {
            Console.WriteLine("Sub program is running...");
        }
    }
}
