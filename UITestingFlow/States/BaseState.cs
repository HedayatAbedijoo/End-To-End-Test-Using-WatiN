using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITestingFlow
{
    public class BaseState
    {

        internal void LogException(Exception exp)
        {
            Console.WriteLine(String.Format("State: {0} => has NOT been done successfully", this.GetType().Name));

        }

        internal void LogException(string Title, Exception exp)
        {
            var className = this.GetType().Name;
            Console.WriteLine(String.Format("State : {0} => " + Title, this.GetType().Name));

        }

        internal void LogSuccess()
        {
            Console.WriteLine(String.Format("State: {0} => has been done successfully", this.GetType().Name));
            // you can log the success states
        }
    }
}
