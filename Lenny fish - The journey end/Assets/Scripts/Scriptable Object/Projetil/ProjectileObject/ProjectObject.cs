using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Project", menuName = "Scriptable Objects/Project/New Projectile", order = 1)]
public class ProjectObject : ScriptableObject
{
    [Header("Project Config")]
    public float lifeTime;
    public float distanceTouch;
    public LayerMask whatIsSolid;

    [Header("Status projetil")]
    public int damage;
    public float speed;
    public float size;

    [Header("Efeitos do projetil")]
    public bool explodes;
    public bool fire;
    public bool poison;

    [Header("Effects")]
    public GameObject destroyEffect;
}
