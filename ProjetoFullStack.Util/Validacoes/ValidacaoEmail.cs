using System;
using System.Net.Mail;

namespace ProjetoFullStack.Util.Validacoes
{
    public class ValidacaoEmail
    {
        public static bool Validar(string email)
        {           
            try
            {
                MailAddress  mail = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }            
        }
    }
}
