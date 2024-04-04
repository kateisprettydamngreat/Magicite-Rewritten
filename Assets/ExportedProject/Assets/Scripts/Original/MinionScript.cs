using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

[Serializable]
public class MinionScript : MonoBehaviour
{
    [SerializeField] private GameObject fireballPrefab;

    private Transform myTransform;
    private Animation myAnimation;
    private NetworkView myNetworkView;

    private ObjectPool fireballPool;

    private int idleLayer;
    private int attackLayer;

    private bool isMovingUp;

    void Awake()
    {
        myTransform = transform;
        myAnimation = base.GetComponent<Animation>();
        myNetworkView = GetComponent<NetworkView>();

        idleLayer = myAnimation["i"].layer;
        attackLayer = myAnimation["a"].layer;
    }

    void Start()
    {
        fireballPool = new ObjectPool(fireballPrefab);

        StartCoroutine(VerticalMovement());
    }

    void Attack()
    {
        GameObject fireball = fireballPool.GetObject();

        if (fireball != null)
        {
            fireball.SetActive(true);
            fireball.transform.position = myTransform.position;
        }
    }

    IEnumerator VerticalMovement()
    {
        while (true)
        {
            myTransform.Translate(Vector3.up * Time.deltaTime * 2f);
            isMovingUp = true;
            yield return new WaitForSeconds(0.5f);

            myTransform.Translate(Vector3.up * Time.deltaTime * -2f);
            isMovingUp = false;
            yield return new WaitForSeconds(1f);
        }
    }
}

// TODO:  Caleb, this is temporary as later version of Unity come with this class under UnityEngine.Pool
public class ObjectPool
{
    private List<GameObject> pool;
    private GameObject prefab;

    public ObjectPool(GameObject prefab, int initialSize = 1)
    {
        this.prefab = prefab;
        pool = new List<GameObject>(initialSize);

        for (int i = 0; i < initialSize; i++)
        {
            GameObject instance = Object.Instantiate(prefab);
            instance.gameObject.SetActive(false);
            pool.Add(instance);
        }
    }

    public GameObject GetObject()
    {
        foreach (GameObject obj in pool)
        {
            if (!obj.gameObject.activeInHierarchy)
            {
                obj.gameObject.SetActive(true);
                return obj;
            }
        }

        GameObject newInstance = Object.Instantiate(prefab);
        pool.Add(newInstance);
        return newInstance;
    }

    public void ReturnObject(GameObject obj)
    {
        obj.gameObject.SetActive(false);
    }
}
