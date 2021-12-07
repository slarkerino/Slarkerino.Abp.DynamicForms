using System;
using System.Collections.Generic;
using System.Text;

namespace Slarkerino.Abp.DynamicForms.Projects
{
    public enum ProjectStatus
    {
        Pending = 0,
        Active = 1,
        Ended = 2,
        Auditing = 99,
        Rejected = 100
    }
}
