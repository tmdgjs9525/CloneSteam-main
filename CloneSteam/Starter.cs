using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloneSteam.Properties;
using Prism.Modularity;
namespace CloneSteam
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App()
                .AddInversionModule<HelperModules>()
                .WireViewModel()
                .Run();
                ;
        }
    }
}
