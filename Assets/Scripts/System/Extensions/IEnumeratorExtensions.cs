using System.Collections;
using UnityEngine;

namespace DragonPackage
{
    public static class IEnumeratorExtensions
    {
        public static IEnumerator WaitAsync(float interval)
        {
            var t = 0f;
            while (t < interval)
            {
                t += Time.deltaTime;
                yield return null;
            }
            yield return null;
        }
    }
}
