using System;
using System.ComponentModel;
using Volo.Abp.ObjectExtending;

namespace Slarkerino.Abp.DynamicForms.Projects.Dtos
{
    [Serializable]
    public class ProjectUpdateDto : ExtensibleObject
    {
        public string Title { get; set; }

        public int ResponseCount { get; set; }

        public string ProjectType { get; set; }

        public ProjectStatus ProjectStatus { get; set; }

        public string Tags { get; set; }

    }
}