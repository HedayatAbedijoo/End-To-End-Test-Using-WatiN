using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;

namespace UITestingFlow
{
    public class Login : BaseState, ITestProcess
    {

        public TestFlowStatus Process(IE ie)
        {
            if (ie.ContainsText("logOut"))
            {
                this.LogSuccess();
                return TestFlowStatus.GoNext;
            }
            else
            {
                try
                {
                    ie.TextField(Find.ById("txtUserName")).TypeText("admin");
                    ie.TextField(Find.ById("txtPassword")).TypeText("admin");
                    ie.Button(Find.ById(url => url != null && url.Contains("btnLogin"))).Click();
                    ie.WaitForComplete();
                    //  if (ie.ContainsText("logOut"))
                    if (ie.Links.Where(i => i.Id == "logOut").Count() == 1)
                    {
                        this.LogSuccess();
                        return TestFlowStatus.GoNext;
                    }
                    else
                    {
                        //you can log informatin here
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
}
