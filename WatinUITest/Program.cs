using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITestingFlow;

namespace WatinUITest
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            //Defining States
            StartTesting startClass = new StartTesting();
            TestWorkflowHandler startState = new TestWorkflowHandler(startClass);
            TestWorkflowHandler logingState = new TestWorkflowHandler(new Login());
            TestWorkflowHandler OpenSecondPage = new TestWorkflowHandler(new OpenSecondPage());
            TestWorkflowHandler end = new TestWorkflowHandler(new EndTesting());

            // Defining Test Flow
            startState.RegisterNextStep(logingState);
            logingState.RegisterNextStep(OpenSecondPage);
            OpenSecondPage.RegisterNextStep(end);

            // Start Test Flow
            startState.Process(startClass.ie);
           
            
            Console.ReadLine();
            startClass.Dispose();
        }
    }
}
