using System;
using System.Collections.Generic;
using System.Text;

namespace ST.Utility
{
    public enum GeneralError
    {
        Success,
        Failed,
        ModelStateError,
        IdentityError,
        RequiresTwoFator,
        SessionExpried
    }
}
