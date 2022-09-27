using System;
using System.Collections.Generic;
using System.Text;
using ThreeBits.Entities.Common;
using ThreeBits.Entities.Security;

namespace ThreeBits.Interfaces.Security
{
    public interface ISecurityService
    {
        ProcessResult<Credential> Login(Credential input);


    }
}
