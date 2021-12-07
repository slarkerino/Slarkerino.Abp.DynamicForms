using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;

namespace Slarkerino.Abp.DynamicForms.Responses
{
    public interface IResponse : IHasExtraProperties
    {
        int Sequence { get; }

        DateTime StartTime { get; }

        DateTime EndTime { get; }

        string IPAddress { get; }

        string Source { get; }

    }
}
