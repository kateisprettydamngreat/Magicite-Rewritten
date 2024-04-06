using Magicite.Utils;
using UnityEngine;

namespace Magicite.Managers
{
    public class WorldRef : Singleton<WorldRef>
    {
        public Camera MainCamera;
        public GameClientType ClientType;
    }

    public enum GameClientType
    {
        Host,
        Client
    }

    /// <summary>
    /// Get the sceneIndex number for a given scene.
    /// <remarks>IMPORTANT!!!:  These enums should correspond to the scene index number in the build settings.</remarks>
    /// </summary>
    public enum MagiciteScene
    {
        BootstrapScene = 0,
        TestMenu = 1,
        TestScene = 2,
    }
}
