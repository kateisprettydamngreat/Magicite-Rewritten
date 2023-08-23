using System.Collections;
using UnityEngine;

public class YetiScript : EnemyScript
{
    public GameObject ballL;
    public GameObject ballR;

    private RaycastHit hit;
    private int num;

    private void Start()
    {
        StartCoroutine(StartCoroutine());
    }

    [RPC]
    private IEnumerator ATK()
    {
        yield return StartCoroutine(AttackCoroutine());
    }

    private IEnumerator AttackCheck()
    {
        yield return StartCoroutine(AttackCheckCoroutine());
    }

    private IEnumerator StartCoroutine()
    {
        @base.GetComponent<Animation>()["i"].layer = 0;
        @base.GetComponent<Animation>()["a"].layer = 1;
        @base.GetComponent<Animation>()["i"].speed = 0.5f;

        int[] drops = new int[] { 1, 0, 0 };
        SetStats(20, 2, 1, 8, 6f, drops, UnityEngine.Random.Range(3, 20), 6);

        yield return StartCoroutine(AttackCheck());
    }

    private IEnumerator AttackCoroutine()
    {
        Vector3 startPos;
        Ray ray;
        Ray ray2;
        int num;
        WaitForSeconds waitForSeconds;

        startPos = new Vector3(t.position.x, t.position.y - 0.3f, 0f);
        ray = new Ray(startPos, new Vector3(1f, 0f, 0f));
        ray2 = new Ray(startPos, new Vector3(-1f, 0f, 0f));

        if (Physics.Raycast(ray, out hit, 20f, 256))
        {
            attacking = true;
            num = Random.Range(0, 5);
            @base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);

            if (Network.isServer)
            {
                Network.Instantiate(ballR, t.position, Quaternion.identity, 0);
            }

            waitForSeconds = new WaitForSeconds(2f);
            yield return waitForSeconds;

            if (Network.isServer)
            {
                Network.Instantiate(ballL, t.position, Quaternion.identity, 0);
            }

            waitForSeconds = new WaitForSeconds(2f);
            yield return waitForSeconds;

            attacking = false;
            waitForSeconds = new WaitForSeconds(0.3f);
            yield return waitForSeconds;
        }
        else if (Physics.Raycast(ray2, out hit, 20f, 256))
        {
            attacking = true;
            @base.GetComponent<Animation>().Play("a");
            e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);

            if (Network.isServer)
            {
                Network.Instantiate(ballL, t.position, Quaternion.identity, 0);
            }

            waitForSeconds = new WaitForSeconds(2f);
            yield return waitForSeconds;

            attacking = false;
            waitForSeconds = new WaitForSeconds(0.3f);
            yield return waitForSeconds;
        }
    }

    private IEnumerator AttackCheckCoroutine()
    {
        Vector3 startPos;
        Ray ray;
        Ray ray2;
        int num;
        WaitForSeconds waitForSeconds;

        startPos = new Vector3(t.position.x, t.position.y - 0.3f, 0f);
        ray = new Ray(startPos, new Vector3(1f, 0f, 0f));
        ray2 = new Ray(startPos, new Vector3(-1f, 0f, 0f));

        if (!attacking)
        {
            if (Physics.Raycast(ray, out hit, 20f, 256))
            {
                num = Random.Range(0, 5);

                if (Network.isServer)
                {
                    r.velocity = new Vector3(r.velocity.x, 20f, r.velocity.z);
                }

                @base.GetComponent<Animation>().Play("a");
                e.transform.rotation = Quaternion.Euler(0f, 180f, 0f);

                waitForSeconds = new WaitForSeconds(0.3f);
                yield return waitForSeconds;
            }
            else if (Physics.Raycast(ray2, out hit, 20f, 256))
            {
                if (Network.isServer)
                {
                    r.velocity = new Vector3(r.velocity.x, 20f, r.velocity.z);
                }

                @base.GetComponent<Animation>().Play("a");
                e.transform.rotation = Quaternion.Euler(0f, 0f, 0f);

                waitForSeconds = new WaitForSeconds(0.3f);
                yield return waitForSeconds;
            }
        }
    }
}