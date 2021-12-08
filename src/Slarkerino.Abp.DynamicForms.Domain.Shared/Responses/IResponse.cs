using System;
using Volo.Abp.Data;

namespace Slarkerino.Abp.DynamicForms.Responses
{
    public interface IResponse : IHasExtraProperties
    {
        int Sequence { get; }

        DateTime StartTime { get; }

        DateTime EndTime { get; }

        string Source { get; }

        Guid ProjectId { get; }

    }
}
