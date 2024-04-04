using Magicite.Utils;
using UnityEngine;

namespace Magicite.Managers
{
    public class GameManager : Singleton<GameManager>
    {
        public Camera MainCamera;
        public GameClientType ClientType;
    }

    public enum GameClientType
    {
        Host,
        Client
    }
}
