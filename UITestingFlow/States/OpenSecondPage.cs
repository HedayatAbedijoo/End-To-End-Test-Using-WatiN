using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;

namespace UITestingFlow
{
    public class OpenSecondPage : BaseState, ITestProcess
    {

        public TestFlowStatus Process(IE ie)
        {

            try
            {
                ie.Links.Where(i => i.Id == "openLink").FirstOrDefault().Click();
                ie.WaitForComplete();
                if (ie.Spans.Where(i => i.Id == "lblContent").Count() == 1)
                {
                    this.LogSuccess();
                    return TestFlowStatus.GoNext;
                }
                else
                {
                    
                    return TestFlowStatus.Finish;
                }
            }
            catch (Exception exp)
            {
                this.LogException(exp);
                return TestFlowStatus.Finish;
            }
        }

    }
}
