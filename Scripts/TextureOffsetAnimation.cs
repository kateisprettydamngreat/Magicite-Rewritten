using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TextureOffsetAnimation : MonoBehaviour
{
    public GameObject baseObject;
    private Renderer renderer;

    [Serializable]
    internal class TextureOffsetAnimationCoroutine : IEnumerator
    {
        private float xOffset;
        private Vector2 textureOffset;
        private TextureOffsetAnimation owner;

        public TextureOffsetAnimationCoroutine(TextureOffsetAnimation owner)
        {
            this.owner = owner;
        }

        public bool MoveNext()
        {
            int state = 0;

            switch (state)
            {
                default:
                    owner.renderer = owner.baseObject.GetComponent<Renderer>();
                    goto case 2;

                case 2:
                    xOffset = owner.renderer.material.mainTextureOffset.x + 0.5f;
                    textureOffset = owner.renderer.material.mainTextureOffset;
                    textureOffset.x = xOffset;
                    owner.renderer.material.mainTextureOffset = textureOffset;
                    state = 1;
                    break;

                case 1:
                    state = 0;
                    break;
            }

            return state != 0;
        }

        public void Reset() { }
        public object Current => null;
    }

    public IEnumerator Start()
    {
        return new TextureOffsetAnimationCoroutine(this);
    }
}
