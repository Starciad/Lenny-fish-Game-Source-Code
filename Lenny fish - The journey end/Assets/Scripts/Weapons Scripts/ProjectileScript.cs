using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public ProjectObject projectile;
    void Start()
    {
        Invoke("DestroyProjectile", projectile.lifeTime);
        transform.localScale = new Vector3(projectile.size, projectile.size, projectile.size);
    }

    void Update()
    {
        Moviment();
    }

    void Moviment()
    {
        transform.Translate(Vector2.right * projectile.speed * Time.deltaTime);
        AttackShot();
    }

    void AttackShot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.up, projectile.distanceTouch, projectile.whatIsSolid);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy"))
            {
                hitInfo.collider.GetComponent<EnemyScript>().TakeDamage(projectile.damage);
            }
            DestroyProjectile();
        }
    }

    void DestroyProjectile()
    {
        Instantiate(projectile.destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
