using UnityEngine;

namespace Fizz6.Core.Tests
{
    [CreateAssetMenu(fileName = "SingletonScriptableObjectTestImplementer", menuName = "Fizz6/Core/Tests/Singleton Scriptable Object Test Implementer")]
    public class SingletonScriptableObjectTestImplementer : SingletonScriptableObject<SingletonScriptableObjectTestImplementer>
    {
        [SerializeField]
        private bool value;
        public bool Value => value;
    }
}
