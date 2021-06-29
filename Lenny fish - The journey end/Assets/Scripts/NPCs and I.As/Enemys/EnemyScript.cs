using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public LevelMeneger levelMeneger;
    public EnemyObject enemyConfig;
    public Transform target;

    public Rigidbody2D rb;
    void Start()
    {
        target = FindObjectOfType<PlayerControl>().GetComponent<Transform>();
        enemyConfig.life = enemyConfig.maxLife;
        rb = GetComponent<Rigidbody2D>();
        levelMeneger.enemysTotal += 1;
    }

    void Update()
    {
        AIMovimentX();
        AIMovimentY();
    }

    public void TakeDamage(int damage)
    {
        //camAnim.SetTrigger("shake");
        //Instantiate(explosion, transform.position, Quaternion.identity);
        enemyConfig.life -= damage;
        StartCoroutine(ChangeColor());

        if (enemyConfig.life <= 0)
        {
            //Instantiate(enemyConfig.deathEffect, transform.position, Quaternion.identity);
            levelMeneger.enemysTotal -= 1;
            Destroy(gameObject);
        }
    }

    IEnumerator ChangeColor()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(0.3f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    void AIMovimentX()
    {
        if (target.position.x < transform.position.x)
        {
            this.transform.position += new Vector3(-enemyConfig.speed * Time.deltaTime, 0f, 0f);
        }
        else if (target.position.x > transform.position.x)
        {
            this.transform.position += new Vector3(enemyConfig.speed * Time.deltaTime, 0f, 0f);
        }
    }

    void AIMovimentY()
    {
        if (target.position.y < transform.position.y)
        {
            this.transform.position += new Vector3(0f, -enemyConfig.speed * Time.deltaTime, 0f);
        }
        else if (target.position.y > transform.position.y)
        {
            this.transform.position += new Vector3(0f, enemyConfig.speed * Time.deltaTime, 0f);
        }
    }
}

