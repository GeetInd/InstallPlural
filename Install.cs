using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class Install
    {
        public Install()
        {
        }
        private string[] InputStringVal;


        public string[] InputString
        {
            set
                {
                InputStringVal = value;
            }
        }

        public string[] OutputString
        {
            get;
            private set;
        }

        public void InstallPackages()
        {

        }
        private void VarifyDependency()
        {
            string[] output;
            output = InputStringVal;
            OutputString = output ;
        }
    }
}
