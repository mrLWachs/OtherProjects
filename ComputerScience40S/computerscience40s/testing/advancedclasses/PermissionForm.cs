using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience40S.computerscience40s.testing.advancedclasses
{
    /// <summary>
    /// 
    /// </summary>
    interface PermissionForm
    {

        //static const bool SIGNED = true;    
        //static const bool NOT_SIGNED = false;

        /// <summary>
        /// Signing the permission form
        /// </summary>
        void Sign();

        /// <summary>
        /// Determines if the form is signed or not
        /// </summary>
        /// <returns>form is signed or not</returns>
        bool HaveGotSigned();

    }
}
