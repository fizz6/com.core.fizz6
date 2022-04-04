using UnityEngine;

namespace Fizz6.Core.Tests
{
    public class SingletonScriptableObjectTestInvoker : MonoBehaviour
    {
        private void Awake()
        {
            Debug.Log(SingletonScriptableObjectTestImplementer.Instance.Value);
        }
    }
}