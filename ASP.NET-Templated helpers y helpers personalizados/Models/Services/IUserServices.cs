using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Formularios_de_datos.Models.Services
{
    public interface IUserServices
    {
        bool Exists(string nickname);
    }
}
