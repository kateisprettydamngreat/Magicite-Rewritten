using System.Collections;
using BD.Bootstrap;
using Magicite.Managers;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ServerTestUI : MonoBehaviour
{
    [SerializeField] private Button _hostButton;
    [SerializeField] private Button _clientButton;

    private void Start()
    {
        if (SceneManager.GetSceneByBuildIndex((int)MagiciteScene.TestScene).isLoaded)
            StartCoroutine(UnloadGameScene());
        else
            LoadingScreenDisplay.Showing = false;

        _hostButton.onClick.AddListener(HandleHostClick);
        _clientButton.onClick.AddListener(HandleClientClick);

        NetworkManager.Singleton.OnClientConnectedCallback += OnClientConnected;
    }

    private void OnDisable()
    {
        _hostButton.onClick.RemoveListener(HandleHostClick);
        _clientButton.onClick.RemoveListener(HandleClientClick);

        NetworkManager.Singleton.OnClientConnectedCallback -= OnClientConnected;
    }

    private void HandleHostClick()
    {
        Debug.Log("Starting Host");
        WorldRef.Instance.ClientType = GameClientType.Host;
        // NetworkManager.Singleton.StartHost();
        StartCoroutine(LoadGameScene());
        Hide();
    }

    private void HandleClientClick()
    {
        Debug.Log("Starting Client");
        WorldRef.Instance.ClientType = GameClientType.Client;
        StartCoroutine(LoadGameScene());
        // NetworkManager.Singleton.StartClient();
    }

    private void OnClientConnected(ulong clientId)
    {
        Hide();
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }

    /// <summary>
    /// Called when returning from a game session
    /// </summary>
    /// <returns></returns>
    private IEnumerator UnloadGameScene()
    {
        // This happens when we return to the title from the game scene
        var operation = SceneManager.UnloadSceneAsync(2);
        while (!operation.isDone)
        {
            //Unloading the game scene is the second half of the work to do
            LoadingScreenDisplay.Progress = 0.5f + (operation.progress * 0.5f);
            yield return new WaitForEndOfFrame();
        }

        //We are now done unloading
        LoadingScreenDisplay.Showing = false;
    }

    /// <summary>
    /// Called when the player is ready to start a game session
    /// </summary>
    /// <returns></returns>
    private IEnumerator LoadGameScene()
    {
        //First show the loading screen and wait a frame or two for it to actually display

        LoadingScreenDisplay.Progress = 0f;
        LoadingScreenDisplay.Showing = true;

        // yield return new WaitForEndOfFrame();
        // yield return new WaitForEndOfFrame();

        var operation = SceneManager.LoadSceneAsync((int)MagiciteScene.TestScene, LoadSceneMode.Additive);
        // Tell unity to activate the scene soon as its ready
        operation.allowSceneActivation = true;

        // While the game scene is loading update the progress
        while(!operation.isDone)
        {
            //Loading the game scene is only half the effort we need to do
            LoadingScreenDisplay.Progress = operation.progress * 0.5f;
            yield return new WaitForEndOfFrame();
        }

        //The game scene is now loaded and its logic should be starting
        LoadingScreenDisplay.Progress = 0.5f;
    }
}
