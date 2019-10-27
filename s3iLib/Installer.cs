using System;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace s3iLib
{
    public abstract class Installer
    {
        public abstract int Install(Uri uri, ProductPropertiesDictionary props, string extraArgs, bool dryrun, TimeSpan timeout);
        public abstract int Uninstall(Uri uri, string extraArgs, bool dryrun, TimeSpan timeout);
        public static Installer SelectInstaller(Uri uri)
        {
            if(MsiInstaller.CanInstall(uri)) return new MsiInstaller();
            //return new MockInstaller();
            return null;
        }
    }
}