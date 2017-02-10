using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;

namespace UITestingFlow
{
    public class TestWorkflowHandler : ITestWorkflowHandler
    {
        ITestWorkflowHandler nextHandler;
        ITestProcess _state;
        public TestWorkflowHandler(ITestProcess currentState)
        {
            _state = currentState;
        }
        public void RegisterNextStep(ITestWorkflowHandler process)
        {
            this.nextHandler = process;
        }

        public TestFlowStatus Process(IE ie)
        {
            if (_state.Process(ie) == TestFlowStatus.Finish)
            {
                return TestFlowStatus.Finish;
            }
            else
            {
                return nextHandler.Process(ie);
            }
        }
    }

    public interface ITestWorkflowHandler : ITestProcess
    {
        void RegisterNextStep(ITestWorkflowHandler process);

    }

}
