using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
//It works, except for the NetCode.
public class YetiScript : EnemyScript
{
    public GameObject ballL;
    public GameObject ballR;
    private RaycastHit hit;
    private int num;

    private void Start()
    {
        //if (isServer)
        //{
        //    Initialize();
        //}
    }

    //[ClientRpc]
    private void RpcATK()
    {
        StartCoroutine(ATKCoroutine());
    }

    //[ClientRpc]
    private void RpcAttackCheck()
    {
        StartCoroutine(AttackCheckCoroutine());
    }

    private void Initialize()
    {
        Animation animation = @base.GetComponent<Animation>();
        animation["i"].layer = 0;
        animation["a"].layer = 1;
        animation["i"].speed = 0.5f;

        int[] drops = new int[3];
        drops[0] = 1;

        SetStats(20, 2, 1, 8, 6f, drops, Random.Range(3, 20), 6);
    }

    private IEnumerator ATKCoroutine()
    {
        yield return new WaitForSeconds(0.3f);
        PerformAttack();
    }

    private IEnumerator AttackCheckCoroutine()
    {
        yield return new WaitForSeconds(0.3f);
        PerformAttackCheck();
    }

    private void PerformAttack()
    {
        Vector3 startPos = new Vector3(t.position.x, t.position.y - 0.3f, 0f);
        Ray ray = new Ray(startPos, Vector3.right);
        Ray ray2 = new Ray(startPos, Vector3.left);

        if (Physics.Raycast(ray, out hit, 20f, 256))
        {
            attacking = true;
            @base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            /*if (isServer)
            {
                NetworkServer.Spawn(Instantiate(ballR, t.position, Quaternion.identity));
            }*/
        }
        else if (Physics.Raycast(ray2, out hit, 20f, 256))
        {
            attacking = true;
            @base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.identity;
            /*if (isServer)
            {
                NetworkServer.Spawn(Instantiate(ballL, t.position, Quaternion.identity));
            }*/
        }
    }

    private void PerformAttackCheck()
    {
        Vector3 startPos = new Vector3(t.position.x, t.position.y - 0.3f, 0f);
        Ray ray = new Ray(startPos, Vector3.right);
        Ray ray2 = new Ray(startPos, Vector3.left);

        if (!attacking)
        {
            if (Physics.Raycast(ray, out hit, 20f, 256))
            {
                attacking = true;
                @base.GetComponent<Animation>().Play("a");
                e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                /*if (isServer)
                {
                    NetworkServer.Spawn(Instantiate(ballR, t.position, Quaternion.identity));
                }*/
            }
            else if (Physics.Raycast(ray2, out hit, 20f, 256))
            {
                attacking = true;
                @base.GetComponent<Animation>().Play("a");
                e.transform.rotation = Quaternion.identity;
                /*if (isServer)
                {
                    NetworkServer.Spawn(Instantiate(ballL, t.position, Quaternion.identity));
                }*/
            }
        }
    }
}