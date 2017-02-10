using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;

namespace UITestingFlow
{
    public interface ITestProcess
    {
        TestFlowStatus Process(IE ie);

    }

    public enum TestFlowStatus
    {
        Finish = 1,
        GoNext = 2
    }

}
