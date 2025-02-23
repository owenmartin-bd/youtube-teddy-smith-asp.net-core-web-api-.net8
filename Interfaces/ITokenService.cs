using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_Web_API_.NET_8.Models;

namespace ASP.NET_Core_Web_API_.NET_8.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}