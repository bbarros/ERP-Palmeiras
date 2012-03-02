using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP_Palmeiras_RH.Core
{
    /// <summary>
    /// Exceptions do ERP.
    /// </summary>
    public class ERPException : Exception
    {
        public ERPException(String message) : base(message) { }
    }
}
