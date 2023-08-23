using System.Collections;
using UnityEngine;
//Untested, but compiles!
public class WhelpFire : MonoBehaviour
{
    public bool isFast;
    public bool yeti;

    private Vector3 playerPos;
    private Rigidbody r;
    private Vector3 finalVec;
    private Transform t;
    private bool canShoot;
    private int speed = 10;
    private bool exiling;

    private void Awake()
    {
        if (isFast)
        {
            speed = UnityEngine.Random.Range(5, 18);
        }

        t = transform;
        r = GetComponent<Rigidbody>();
    }

    [RPC]
    public void Set(Vector3 v)
    {
        playerPos = v;
        finalVec = !yeti ? Vector3.Normalize(playerPos - transform.position) : v;
        canShoot = true;
    }

    public IEnumerator Start()
    {
        yield return new WaitForSeconds(6f);

        if (Network.isServer)
        {
            StartCoroutine(ExileCoroutine());
        }
    }

    [RPC]
    public IEnumerator Exile()
    {
        if (!exiling)
        {
            exiling = true;
            t.position = new Vector3(0f, 0f, -500f);
            yield return new WaitForSeconds(4f);
        }

        Network.Destroy(GetComponent<NetworkView>().viewID);
        Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
    }

    private IEnumerator ExileCoroutine()
    {
        if (!exiling)
        {
            exiling = true;
            t.position = new Vector3(0f, 0f, -500f);
            yield return new WaitForSeconds(4f);
        }

        Network.Destroy(GetComponent<NetworkView>().viewID);
        Network.RemoveRPCs(GetComponent<NetworkView>().viewID);
    }

    private void Update()
    {
        if (canShoot)
        {
            t.Translate(finalVec * speed * Time.deltaTime);
        }
    }
}
