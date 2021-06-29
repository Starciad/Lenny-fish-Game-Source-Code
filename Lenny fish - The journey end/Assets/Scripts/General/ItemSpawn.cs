using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{
    public LevelMeneger levelMeneger;
    public GameObject[] itensToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        SpawnItem();
    }

    void SpawnItem()
    {
        if (levelMeneger.enemysTotal == 0)
        {
            //int x = Random.RandomRange(0, itensToSpawn.Length);
            Instantiate(itensToSpawn[0], transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        Debug.Log("Cheguei aqui");
    }
}
