using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObject : ScriptableObject
{
    [Header("Basic infos")]
    public string enemyName;

    [Header("Status")]
    public int life;
    public int maxLife;
    public int attackDamage;

    [Header("Moviment")]
    public float speed;

    [Header("Projectile")]
    public bool shoot;
    public GameObject projectile;
}
