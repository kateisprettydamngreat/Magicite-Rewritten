using System;
using UnityEngine;
using UnityEngine.UI;

namespace BD.Bootstrap
{
    public class LoadingScreenDisplay : MonoBehaviour
    {
        /// <summary>
        /// Use of singletons like this is not a great design and will cause maintainabiliy issues down the road
        /// It is used here for simplicity sake, simple only because this is a very small and simple project
        /// You should avoid using singletons like this where you can
        /// </summary>
        internal static LoadingScreenDisplay instance;

        [SerializeField]
        private Image progressBar_fill;

        private void Awake()
        {
            instance = this;
        }

        /// <summary>
        /// This simply exposes the parent game object's active self flag as a simple static boolean
        /// </summary>
        public static bool Showing
        {
            get => instance.gameObject.activeSelf;
            set => instance.gameObject.SetActive(value);
        }
        /// <summary>
        /// This simply exposes the progressBar's fillAmount as a static float value
        /// </summary>
        public static float Progress
        {
            get => instance.progressBar_fill.fillAmount;
            set => instance.progressBar_fill.fillAmount = value;
        }
    }
}
