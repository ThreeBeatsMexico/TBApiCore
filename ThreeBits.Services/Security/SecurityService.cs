using System;
using System.Collections.Generic;
using System.Text;
using ThreeBits.Entities.Common;
using ThreeBits.Entities.Security;
using ThreeBits.Interfaces.Security;

namespace ThreeBits.Services.Security
{
    public class SecurityService : _BaseService, ISecurityService
    {

        public ProcessResult<Credential> Login(Credential input)
        {
            var respuesta = new ProcessResult<Credential>();
            Login oLoginBr = new Login();
            try
            {
               
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
