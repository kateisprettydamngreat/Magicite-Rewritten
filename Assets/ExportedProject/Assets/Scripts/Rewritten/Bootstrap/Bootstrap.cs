using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BD.Bootstrap
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private LoadingScreenDisplay _loadingScreenDisplay;

        private void Start()
        {
            LoadingScreenDisplay.instance = _loadingScreenDisplay;
            StartCoroutine(Validate());
        }


        private IEnumerator Validate()
        {
            yield return null;

            // In a real validate method we would check the state of any dependent systems or integrations such as Steam and make sure we have loaded any required data such as system settings

            Debug.Log("Loading the title scene!");

            // When ready would load the title scene, which we can do by index since we know its the second scene in the build. This is much faster than loading by name

            //Show the loading screen
            LoadingScreenDisplay.Progress = 0;
            LoadingScreenDisplay.Showing = true;

            var operation = SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
            // Tell unity to activate the scene soon as its ready
            operation.allowSceneActivation = true;

            // While the title scene is loading update the progress
            while (!operation.isDone)
            {
                //Loading the title scene
                LoadingScreenDisplay.Progress = operation.progress;
                yield return new WaitForEndOfFrame();
            }

            //The title scene is now loaded and its logic should be starting
            LoadingScreenDisplay.Progress = 1f;
        }
    }
}
