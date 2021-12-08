using System;
using System.ComponentModel;
using Volo.Abp.ObjectExtending;

namespace Slarkerino.Abp.DynamicForms.Responses.Dtos
{
    [Serializable]
    public class ResponseUpdateDto : ExtensibleObject
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Source { get; set; }
    }
}