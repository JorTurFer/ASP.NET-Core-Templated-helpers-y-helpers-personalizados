using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Formularios_de_datos.Models.Services
{
    public class UserServices : IUserServices
    {
        public bool Exists(string nickName)
        {
            var invalidNames = new[] { "jorge", "sandra", "mark", "jose" };
            return invalidNames.Any(n => n == nickName);
        }
    }
}
