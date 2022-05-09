using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;

namespace NetCore.Utilities.Utils
{
    public static class Common
    {
        public static void SetDataProtection(IServiceCollection services, string keyPath, string applicationName, Enum cryptoType)
        {
            var builder = services.AddDataProtection()
                .PersistKeysToFileSystem(new DirectoryInfo(@""))
                .SetDefaultKeyLifetime(TimeSpan.FromDays(7))
                .SetApplicationName("NetCore");
            switch (cryptoType)
            {
                case Enums.CryptoType.Unmanaged:
                    break;
                case Enums.CryptoType.Managed:
                    break;
            }
        } 
        
    } 
}