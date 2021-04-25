using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public EnemyObject enemyConfig;

    void Start()
    {
        enemyConfig.life = enemyConfig.maxLife;
    }

    void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        //camAnim.SetTrigger("shake");
        //Instantiate(explosion, transform.position, Quaternion.identity);
        enemyConfig.life -= damage;
        if (enemyConfig.life <= 0)
        {
            //Instantiate(enemyConfig.deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
