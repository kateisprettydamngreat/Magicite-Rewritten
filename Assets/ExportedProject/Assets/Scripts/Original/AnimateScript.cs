// using System;
// using System.Collections;
// using UnityEngine;
//
// [Serializable]
// public class Animate : MonoBehaviour
// {
//     public bool nodestroy;
//     private Renderer renderer;
//     [Serializable]
//     private sealed class AnimationGenerator : GenericGenerator<WaitForSeconds>
//     {
//         [Serializable]
//         private sealed class AnimationEnumerator : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
//         {
//             private int iteration;
//             private float textureOffsetX;
//             private Vector2 currentTextureOffset;
//             private Animate animateComponent;
//             public AnimationEnumerator(Animate animate)
//             {
//                 animateComponent = animate;
//             }
//             public override bool MoveNext()
//             {
//                 int result;
//                 switch (_state)
//                 {
//                     default:
//                         animateComponent.renderer = animateComponent.GetComponent<Renderer>();
//                         iteration = 0;
//                         goto AnimationLoop;
//                     case 2:
//                         iteration++;
//                         goto AnimationLoop;
//                     case 1:
//                         result = 0;
//                         break;
//                     AnimationLoop:
//                         if (iteration < 3)
//                         {
//                             textureOffsetX = animateComponent.renderer.material.mainTextureOffset.x + 0.25f;
//                             currentTextureOffset = animateComponent.renderer.material.mainTextureOffset;
//                             currentTextureOffset.x = textureOffsetX;
//                             animateComponent.renderer.material.mainTextureOffset = currentTextureOffset;
//                             result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
//                             break;
//                         }
//                         if (!animateComponent.nodestroy)
//                         {
//                             UnityEngine.Object.Destroy(animateComponent.gameObject);
//                         }
//
//                         YieldDefault(1);
//                         goto case 1;
//                 }
//                 return (byte)result != 0;
//             }
//         }
//
//
//         private Animate animateComponent;
//
//         public AnimationGenerator(Animate animate)
//         {
//             animateComponent = animate;
//         }
//
//         public override IEnumerator<WaitForSeconds> GetEnumerator()
//         {
//             return new AnimationEnumerator(animateComponent);
//         }
//     }
// 		private IEnumerator Die()
//     {
//         yield return new WaitForSeconds(10f);
//         UnityEngine.Object.Destroy(gameObject);
//     }
//     public virtual IEnumerator Start()
//     {
//         yield return new AnimationGenerator(this).GetEnumerator();
//         StartCoroutine(Die());
//     }
// }
