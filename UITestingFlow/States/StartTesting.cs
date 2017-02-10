
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatiN.Core;

namespace UITestingFlow
{
    public class StartTesting : BaseState, ITestProcess, IDisposable
    {

        IE _ie;
        public StartTesting()
        {
            try
            {
                _ie = new IE("http://localhost/PortalTestApp/Login.aspx");

            }
            catch (Exception exp)
            {
                this.LogException(exp);
                throw exp;
            }

            _ie.ShowWindow(WatiN.Core.Native.Windows.NativeMethods.WindowShowStyle.Maximize);

        }

        public TestFlowStatus Process(IE ie)
        {
            this.LogSuccess();
            return TestFlowStatus.GoNext;
        }

        public IE ie { get { return _ie; } }



        public void Dispose()
        {
            this._ie.Dispose();
        }
    }
}
