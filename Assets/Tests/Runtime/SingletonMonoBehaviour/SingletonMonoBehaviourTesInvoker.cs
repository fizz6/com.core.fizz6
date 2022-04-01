using UnityEngine;
using UnityEngine.Assertions;

namespace Fizz6.Core.Test
{
    public class SingletonMonoBehaviourTester : MonoBehaviour
    {
        private void Start()
        {
            Assert.IsTrue(SingletonMonoBehaviourImplementer.Instance.GetType() == typeof(SingletonMonoBehaviourImplementer));
        }
    }
}
