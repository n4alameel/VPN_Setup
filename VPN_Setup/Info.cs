using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPN_Setup
{
    public class Info
    {
        
        bool agree = true;
        string folder = "C:/Program Files(x86)/VPN Unlimited";
        string shortcutFolder = "VPN Unlimited";
        bool additionalShortcuts = true;
        bool launchVPN = true;
        public Info() { }
        public void setAgree (bool a) { agree = a; }
        public void setFolder(string f) { folder = f; }
        public void setShortcutFolder(string f) { shortcutFolder = f; }
        public void setAdditionalShortcuts(bool a) { additionalShortcuts = a; }
        public void setLaunchVPN(bool l) { launchVPN = l; }

        public bool getAgree() {return agree; }
        public string getFolder() { return folder; }
        public string getShortcutFolder() { return shortcutFolder; }
        public bool getAdditionalShortcuts() { return additionalShortcuts ; }
        public bool getLaunchVPN() { return launchVPN; }


    }
}
