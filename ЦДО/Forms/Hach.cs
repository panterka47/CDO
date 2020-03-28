using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ЦДО.Формы
{
    class Hach
    {
        //Хэшируем пароль
        public string GetHash(string input)
        {
           return Convert.ToBase64String(MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(input)));
        }
    }
}
