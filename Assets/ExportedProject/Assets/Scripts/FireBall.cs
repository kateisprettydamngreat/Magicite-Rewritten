using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class FireBall : MonoBehaviour
{
    private const float SpeedIncreasePerSecond = 0.2f;

    [SerializeField] private bool isRight;
    [SerializeField] private GameObject baseObj;
    [SerializeField] private GameObject base2Obj;
    [SerializeField] private float wait;

    private Renderer renderer;
    private Renderer base2Renderer;
    private Transform transform;

    private int damage;
    private float speed;
    private bool exiling;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        if (base2Obj != null)
        {
            base2Renderer = base2Obj.GetComponent<Renderer>();
        }

        transform = transform;
        speed = 3f;

        StartCoroutine(AnimateTexture());
    }

    private IEnumerator AnimateTexture()
    {
        while (true)
        {
            // Animate main texture offset
            renderer.material.mainTextureOffset = new Vector2(
                renderer.material.mainTextureOffset.x + 0.25f,
                renderer.material.mainTextureOffset.y);

            if (base2Renderer != null)
            {
                base2Renderer.material.mainTextureOffset = new Vector2(
                    base2Renderer.material.mainTextureOffset.x + 0.25f,
                    base2Renderer.material.mainTextureOffset.y);
            }

            yield return new WaitForSeconds(wait);
        }
    }

    private void Update()
    {
        // Increase speed over time
        speed += SpeedIncreasePerSecond * Time.deltaTime;

        if (isRight)
        {
            transform.Translate(Vector3.left * -speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider c)
    {
        if (ShouldDamage(c))
        {
            c.gameObject.SendMessage("TakeDamage", damage);
            StartCoroutine(Exile());
        }
    }

    private bool ShouldDamage(Collider c)
    {
        return (c.gameObject.layer == 9 || c.gameObject.layer == 12)
            || (c.gameObject.layer == 8 && MenuScript.pvp == 1 && !GetComponent<NetworkView>().isMine);
    }

    private IEnumerator Exile()
    {
        if (!exiling)
        {
            exiling = true;

            transform.position = new Vector3(0f, 0f, -500f);

            yield return new WaitForSeconds(4f);

            Network.Destroy(GetComponent<NetworkView>().viewID);
            Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
        }
    }
}
