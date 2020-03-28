using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstivaWeb.Services
{
    public static class MailService
    {
        public static bool MailGonder()
        {
            try
            {
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}