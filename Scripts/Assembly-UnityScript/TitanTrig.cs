using System.Collections;
using UnityEngine;
// likely orphan
[Serializable]
public class TitanTrig : MonoBehaviour
{
    public GameObject parent;

    private TitanScript titanScript;
    private GameObject target;

    public virtual void Awake()
    {
        titanScript = parent.GetComponent<TitanScript>();
        StartCoroutine(Trig());
    }

    private IEnumerator Trig()
    {
        while (true)
        {
            GetComponent<Collider>().enabled = false;
            yield return new WaitForSeconds(0.2f);
            GetComponent<Collider>().enabled = true;
            yield return new WaitForSeconds(1f);
        }
    }

    public virtual void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.layer == 8)
        {
            target = c.gameObject;
            titanScript.Attack(target);
        }
    }
}
