using Magicite.Util;
using UnityEngine;

namespace Magicite.Assets
{
    [CreateAssetMenu(fileName = "BiomeAsset", menuName = EditorMenuConstants.MagiciteAsset + "Biome Asset")]
    public class BiomeAsset : ScriptableObject
    {
        [Header("Defines the elements used to construct a level according to its biome.")]
        [Space]
        [Header("Entry/Exit Level Chunks")]
        public Material Entrance;
        public Material Exit;
        public Material ExitDoor;

        [Header("Level Zone Materials")]
        public Material Zone1;
        public Material Zone2;
        public Material Zone3;
        public Material Zone4;
        public Material Zone5;
        public Material Zone6;
        public Material Zone7;
        public Material Zone8;
    }
}
