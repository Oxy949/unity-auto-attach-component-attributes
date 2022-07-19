using System;
using UnityEngine;

namespace Dev.Agred.Tools.AttachAttributes
{
    [AttributeUsage(System.AttributeTargets.Field)] public class GetComponentAttribute : AttachPropertyAttribute { }

    [AttributeUsage(System.AttributeTargets.Field)]
    public class GetComponentInChildrenAttribute : AttachPropertyAttribute
    {
        public bool IncludeInactive { get; private set; }
        public string ChildName;

        public GetComponentInChildrenAttribute(bool includeInactive = false)
        {
            IncludeInactive = includeInactive;
        }

        public GetComponentInChildrenAttribute(string childName)
        {
            ChildName = childName;
        }
    }

    [AttributeUsage(System.AttributeTargets.Field)]
    public class GetComponentsInChildrenAttribute : AttachPropertyAttribute
    {
        public bool IncludeInactive { get; private set; }
        public string ChildName;

        public GetComponentsInChildrenAttribute(bool includeInactive = false)
        {
            IncludeInactive = includeInactive;
        }

        public GetComponentsInChildrenAttribute(string childName)
        {
            ChildName = childName;
        }
    }

    [AttributeUsage(System.AttributeTargets.Field)] public class AddComponentAttribute : AttachPropertyAttribute { }
    [AttributeUsage(System.AttributeTargets.Field)] public class FindObjectOfTypeAttribute : AttachPropertyAttribute { }
    [AttributeUsage(System.AttributeTargets.Field)] public class GetComponentInParent : AttachPropertyAttribute { }
    [AttributeUsage(System.AttributeTargets.Field)] public class GetComponentsInParent : AttachPropertyAttribute { }

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
