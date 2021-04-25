using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public ProjectObject playerBullet;

    public int addDamage;
    public float addLifeBullet;
    public int addSize;
    public int addSpeed;


    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Player"))
        {
            playerBullet.damage += addDamage;
            playerBullet.lifeTime += addLifeBullet;
            playerBullet.size += addSize;
            playerBullet.speed += addSpeed;

            Destroy(gameObject);
        }
    }
}
//StatusBullet(addDamage, addSize, addSpeed, addLifeTime);