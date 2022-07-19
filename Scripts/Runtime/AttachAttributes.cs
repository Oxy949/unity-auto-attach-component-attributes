using System;
using UnityEngine;

namespace Dev.Agred.Tools.AttachAttributes
{
    [AttributeUsage(System.AttributeTargets.Field)] public class GetComponentAttribute : AttachPropertyAttribute { }

    [AttributeUsage(System.AttributeTargets.Field)]
    public class GetComponentInChildrenAttribute : AttachPropertyAttribute
    {
        public GetComponentInChildrenAttribute(bool includeInactive = false)
        {
            IncludeInactive = includeInactive;
        }

        public GetComponentInChildrenAttribute(string childName)
        {
            ChildName = childName;
        }

        public bool IncludeInactive { get; set; }
        
        public string ChildName { get; set; }
    }

    [AttributeUsage(System.AttributeTargets.Field)]
    public class GetComponentsInChildrenAttribute : AttachPropertyAttribute
    {
        public GetComponentsInChildrenAttribute(bool includeInactive = false)
        {
            IncludeInactive = includeInactive;
        }

        public GetComponentsInChildrenAttribute(string propertyName, string childName)
        {
            PropertyName = propertyName;
            ChildName = childName;
        }

        public bool IncludeInactive { get; set; }
        
		public string ChildName { get; set; }

        public string PropertyName { get; set; }
    }

    [AttributeUsage(System.AttributeTargets.Field)] public class AddComponentAttribute : AttachPropertyAttribute { }
    [AttributeUsage(System.AttributeTargets.Field)] public class FindObjectOfTypeAttribute : AttachPropertyAttribute { }
    [AttributeUsage(System.AttributeTargets.Field)] public class GetComponentInParentAttribute : AttachPropertyAttribute { }

    [AttributeUsage(System.AttributeTargets.Field)]
    public class GetComponentsInParentAttribute : AttachPropertyAttribute
    {
        public GetComponentsInParentAttribute(string propertyName)
        {
            PropertyName = propertyName;
        }
        
        public string PropertyName { get; set; }
    }

    [AttributeUsage(System.AttributeTargets.Field)]
    public class GetPrefabAttribute : AttachPropertyAttribute
    {
        public string Path;

        public GetPrefabAttribute(string path)
        {
            Path = path;
        }
    }

    public class AttachPropertyAttribute : PropertyAttribute { }
}
