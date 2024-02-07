using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float timeToDespawn;

    private float despawnTimer;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        despawnTimer += Time.deltaTime;
        if (despawnTimer >= timeToDespawn)
        {
            transform.parent.GetComponent<PoolScript>().DespawnObject(gameObject);
            despawnTimer = 0;
        }
    }
}
