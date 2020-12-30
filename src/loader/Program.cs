using System;
using System.IO;
using System.Reflection;

namespace loader
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bSwitch = false;
            while (true)
            {
                callDll(bSwitch);
                Console.WriteLine("Press Enter to Switch");
                Console.ReadKey();
                bSwitch = !bSwitch;
            }
        }

        private static void callDll(bool bSwitch)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string path1 = currentDirectory + "/../dllToImport/out/dllToImport.dll";
            string path2 = currentDirectory + "/../dllToImport/out2/dllToImport.dll";


            var DLL = Assembly.LoadFile((!bSwitch) ? path1 : path2);

            var type = DLL.GetType("dllToImport.Class1");
            var c = Activator.CreateInstance(type);

            var method = type.GetMethod("GetString");
            string str = (string)method.Invoke(c, null);

            Console.WriteLine("DLL Output: " + str);
        }
    }
}
