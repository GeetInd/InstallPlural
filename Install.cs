using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Install
    {
        public string[,] InputStringVal { get; set; }

        public bool VarifyDependency()
        {
            if (InputStringVal != null)
            {
                int len = InputStringVal.Length;
                for (int i = 0; i < len; i++)
                {
                    if (InputStringVal[i, 1].Trim() == "")
                    {
                        InstallPackages(InputStringVal[1, 0]);
                    }
                    else {
                        for (int j = i+1; j < ((InputStringVal.Length)-i); j++)
                        {
                            if (InputStringVal[i, 1] == InputStringVal[j, 1])
                            {
                                InstallPackages(InputStringVal[j, 0]);
                                return true;
                            }
                        }
                    }
                }
            }
            else
                return false;
        }
        public void InstallPackages(string strPackageName)
        {
            try
            {
                //code to install package.
            }
            catch
            { }
        }
    }

   
}
