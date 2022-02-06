using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
   //Operasyon varsa service var
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
