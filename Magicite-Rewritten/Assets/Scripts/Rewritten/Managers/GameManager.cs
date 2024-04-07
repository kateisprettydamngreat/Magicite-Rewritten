using System.Collections;
using BD.Bootstrap;
using Magicite.Player;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Magicite.Managers
{
    public class GameManager : NetworkBehaviour
    {
        [SerializeField] private PlayerReplicator _playerReplicatorPrefab;
        [SerializeField] private GameObject _level;

        private IEnumerator Start()
        {
            yield return StartCoroutine(UnloadTitle());

            if (WorldRef.Instance.ClientType == GameClientType.Host)
            {
                NetworkManager.Singleton.StartHost();
                yield return new WaitUntil(() => NetworkManager.Singleton.IsHost && NetworkManager.Singleton.IsServer);
            }
            else if (WorldRef.Instance.ClientType == GameClientType.Client)
            {
                NetworkManager.Singleton.StartClient();
                yield return new WaitUntil(() => NetworkManager.Singleton.IsClient);
            }

            Scene scene = SceneManager.GetSceneByBuildIndex((int)MagiciteScene.TestScene);
            SceneManager.SetActiveScene(scene);

            if (IsClient)
            {
                RequestSpawnAndTakeOwnershipServerRpc();
            }

        }

        private IEnumerator UnloadTitle()
        {
            // We would check if we loaded the game scene correctly and that all was ready to play without error before unloading title
            // When the validation for game was done we would start the process to unload the title scene

            var operation = SceneManager.UnloadSceneAsync((int)MagiciteScene.TestMenu);
            while (!operation.isDone)
            {
                //Unloading the title scene is the second half of the work to do
                LoadingScreenDisplay.Progress = 0.5f + (operation.progress * 0.5f);
                yield return new WaitForEndOfFrame();
            }

            //We are now done unloading
            LoadingScreenDisplay.Showing = false;
        }

        [ServerRpc(RequireOwnership = false)]
        private void RequestSpawnAndTakeOwnershipServerRpc(ServerRpcParams rpcParams = default)
        {
            var clientId = rpcParams.Receive.SenderClientId;
            var newReplicatorGO = Instantiate(_playerReplicatorPrefab.gameObject, Vector3.zero, Quaternion.identity);
            var newReplicator = newReplicatorGO.GetComponent<PlayerReplicator>();
            newReplicator.PlayerId.Value = clientId;

            newReplicator.NetworkObject.SpawnAsPlayerObject(clientId);
        }
    }
}
