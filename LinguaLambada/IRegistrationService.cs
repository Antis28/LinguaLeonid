using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguaLambada
{
   public  interface IRegistrationService
    {
        int RegisterUser(int id, string name);
    }
}
