using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;

namespace UITestingFlow
{
    public class EndTesting : BaseState, ITestProcess
    {
       
        public TestFlowStatus Process(IE ie)
        {
            this.LogSuccess();
            return TestFlowStatus.Finish;
        }
    }
}
