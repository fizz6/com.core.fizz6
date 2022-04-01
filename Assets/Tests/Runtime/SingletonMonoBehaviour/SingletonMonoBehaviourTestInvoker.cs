using UnityEngine;
using UnityEngine.Assertions;

namespace Fizz6.Core.Test
{
    public class SingletonMonoBehaviourTestInvoker : MonoBehaviour
    {
        private void Start()
        {
            Assert.IsTrue(SingletonMonoBehaviourTestImplementer.Instance.GetType() == typeof(SingletonMonoBehaviourTestImplementer));
        }
    }
}
