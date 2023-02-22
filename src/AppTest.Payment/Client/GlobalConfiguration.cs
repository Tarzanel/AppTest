using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace AppTest.Payment.Client
{
    /// <summary>
    /// <see cref="GlobalConfiguration"/> provides a compile-time extension point for globally configuring
    /// API Clients.
    /// </summary>
    /// <remarks>
    /// A customized implementation via partial class may reside in another file and may
    /// be excluded from automatic generation via a .swagger-codegen-ignore file.
    /// </remarks>
    public partial class GlobalConfiguration : Configuration
    {      
        public static string PowerTranzId;
        public static string PowerTranzPassword;
        public static void Initialize(string powerTranzId, string powerTranzPassword)
        {
            PowerTranzId = powerTranzId;
            PowerTranzPassword = powerTranzPassword;
        }
        public GlobalConfiguration()
        { 
            DefaultHeader = new Dictionary<string, string> { { "PowerTranz-PowerTranzId", PowerTranzId }, { "PowerTranz-PowerTranzPassword", PowerTranzPassword } };            
        }
    }
}