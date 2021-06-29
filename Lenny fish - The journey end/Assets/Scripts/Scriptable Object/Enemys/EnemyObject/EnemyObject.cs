using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new enemy", menuName = "Scriptable Objects/NPCs/new enemy", order = 1)]
public class EnemyObject : ScriptableObject
{
    [Header("Basic infos")]
    public string enemyName;

    [Header("IA")]
    public float rangeVision;

    [Header("Status")]
    public int life;
    public int maxLife;
    public int attackDamage;

    [Header("Moviment")]
    public float speed;

    [Header("Projectile")]
    public bool shoot;
    public GameObject projectile;

    [Header("Effects")]
    public GameObject deathEffect;
}
