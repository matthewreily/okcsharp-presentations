using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    public class AutoPropertInitializers
    {
        //Any .NET developer who has ever properly implemented a struct has undoubtedly been bothered by 
        //how much syntax it takes to make the type immutable (as .NET standards suggest it should be).  

        #region immutable examples

        public DateTime TimeStamp { get; } = DateTime.UtcNow;
        public string User { get; } = System.Security.Principal.WindowsPrincipal.Current.Identity.Name;
        public string Process { get; } = System.Diagnostics.Process.GetCurrentProcess().ProcessName;

        #endregion

        //mutable
        public string Person { get; set; } = "Matt";
    }
}
