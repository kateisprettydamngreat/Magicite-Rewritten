using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class Animate : MonoBehaviour
{
    // Determines whether the object should be destroyed after animation.
    public bool nodestroy;

    // Reference to the object's renderer component.
    private Renderer renderer;

    // Custom generator class to handle animation coroutine.
    [Serializable]
    private sealed class AnimationGenerator : GenericGenerator<WaitForSeconds>
    {
        // Enumerator for handling animation steps.
        [Serializable]
        private sealed class AnimationEnumerator : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
        {
            // Current iteration index.
            private int iteration;

            // Offset for animating the texture.
            private float textureOffsetX;

            // Current texture offset.
            private Vector2 currentTextureOffset;

            // Reference to the Animate component.
            private Animate animateComponent;

            // Constructor to initialize with Animate component.
            public AnimationEnumerator(Animate animate)
            {
                animateComponent = animate;
            }

            // Implementation of the IEnumerator's MoveNext method.
            public override bool MoveNext()
            {
                int result;
                switch (_state)
                {
                    default:
                        // Get the renderer component of the Animate object.
                        animateComponent.renderer = animateComponent.GetComponent<Renderer>();
                        // Initialize iteration index.
                        iteration = 0;
                        goto AnimationLoop;
                    case 2:
                        iteration++;
                        goto AnimationLoop;
                    case 1:
                        result = 0;
                        break;
                    AnimationLoop:
                        // Perform animation for a limited number of iterations.
                        if (iteration < 3)
                        {
                            // Calculate new texture offset for animation.
                            textureOffsetX = animateComponent.renderer.material.mainTextureOffset.x + 0.25f;
                            currentTextureOffset = animateComponent.renderer.material.mainTextureOffset;
                            currentTextureOffset.x = textureOffsetX;
                            animateComponent.renderer.material.mainTextureOffset = currentTextureOffset;
                            // Yield for a short duration before the next iteration.
                            result = (Yield(2, new WaitForSeconds(0.1f)) ? 1 : 0);
                            break;
                        }
                        // Check if the object should be destroyed.
                        if (!animateComponent.nodestroy)
                        {
                            UnityEngine.Object.Destroy(animateComponent.gameObject);
                        }
                        // YieldDefault to finish the coroutine.
                        YieldDefault(1);
                        goto case 1;
                }
                return (byte)result != 0;
            }
        }

        // Reference to the Animate component.
        private Animate animateComponent;

        // Constructor to initialize with Animate component.
        public AnimationGenerator(Animate animate)
        {
            animateComponent = animate;
        }

        // Implementation of the IEnumerable's GetEnumerator method.
        public override IEnumerator<WaitForSeconds> GetEnumerator()
        {
            return new AnimationEnumerator(animateComponent);
        }
    }

    // Coroutine to start the animation.
    public virtual IEnumerator Start()
    {
        return new AnimationGenerator(this).GetEnumerator();
    }
}
