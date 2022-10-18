using System;
using System.Collections.Generic;
using System.Text;
using ThreeBits.Business.Login;
using ThreeBits.Entities.Common;
using ThreeBits.Entities.Security;
using ThreeBits.Interfaces.Security;

namespace ThreeBits.Services.Security
{
    public class SecurityService : _BaseService, ISecurityService
    {

        public ProcessResult Login(Credential input)
        {
            var respuesta = new ProcessResult();
            Login oLoginBr = new Login();
            try
            {
               respuesta = oLoginBr.authenticate(input);    

            }
            catch (Exception ex)
            {
                respuesta.flag = false;
                respuesta.errorMessage = "Vaya, algo salió mal Error - " + ex.Message;
            }
            return respuesta;
        }


    }
}
