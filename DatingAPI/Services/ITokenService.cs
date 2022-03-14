using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingAPI.Models;

namespace DatingAPI.Services
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}