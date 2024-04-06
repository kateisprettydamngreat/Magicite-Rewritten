using System;
using UnityEngine;

namespace Magicite.Utils
{

    public interface ISingleton {}
    public class Singleton<T> : MonoBehaviour, ISingleton where T : MonoBehaviour
    {
        public static T Instance;

        protected virtual void Awake()
        {
            var instances = FindObjectsOfType<T>();
            if (instances.Length > 1)
            {
                Debug.LogWarning("Singleton warning! An instance of " + typeof(T).FullName + " already exists. Destroying second instance.");
                Destroy(gameObject);
            }
            else
            {
                // DontDestroyOnLoad(gameObject);
            }

            Instance = this as T;
        }

        protected virtual void OnDestroy()
        {
            if (Instance == this)
            {
                Instance = null;
            }
        }
    }
}
