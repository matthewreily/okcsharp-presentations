using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    public class AutoPropertInitializers
    {

        #region old  

        private string _first = "Foo";
        public string First { get { return _first; } }

        private string _last;
        public string Last
        {
            get
            {
                return _last;
            }
            set
            {
                _last = value;
            }
        }

        #endregion

        #region new
        //Any .NET developer who has ever properly implemented a struct has undoubtedly been bothered by 
        //how much syntax it takes to make the type immutable (as .NET standards suggest it should be).  

        #region immutable examples

        public DateTime TimeStamp { get; } = DateTime.UtcNow;
        public string User { get; } = System.Security.Principal.WindowsPrincipal.Current.Identity.Name;
        public string Process { get; } = System.Diagnostics.Process.GetCurrentProcess().ProcessName;

        #endregion

        //mutable
        public string Person { get; set; } = "Matt";

        #endregion
    }
}
