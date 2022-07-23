using UnityEngine;

namespace DragonPackage
{
    public static class ComponentExtensions
    {
        public static T[] GetComponentsInChildrenOnly<T>(this Component component) where T : class
        {
            T[] array = component.GetComponentsInChildren<T>();
            T[] newArray = new T[array.Length - 1];

            for (int i = 1; i < array.Length; i++)
            {
                var obj = array[i];
                newArray[i - 1] = obj;
                obj = null;
            }
            array = null;
            return newArray;
        }
    }
}