using System;

namespace Projeny.Internal
{
    // This is used to indicate to the IL2CPP to preserve classes/methods/etc.
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class PreserveAttribute : Attribute
    {
    }
}
