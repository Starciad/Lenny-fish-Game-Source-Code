using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPlayer : MonoBehaviour
{
    public float offset;

    public float delayShots;
    public float startDelayshots;

    public GameObject projectPrefab;
    public GameObject effectShoot;
    public Transform shotPoint;

    void Update()
    {
        GunRotation();
        ViewMouse();
    }

    void GunRotation()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ * offset);
        Shoot();
    }

    void Shoot()
    {
        if (delayShots <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(effectShoot, shotPoint.position, transform.rotation);
                Instantiate(projectPrefab, shotPoint.position, transform.rotation);
                delayShots = startDelayshots;
            }
        }
        else
        {
            delayShots -= Time.deltaTime;
        }
    }

    void ViewMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector3 direction = new Vector3(transform.position.x - mousePosition.x, 1, 1);
        if (direction.x > 0.1) //trás
        {
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<SpriteRenderer>().flipY = true;
        }
        else if (direction.x < 0.1) //Frente
        {
            GetComponent<SpriteRenderer>().flipX = false;
            GetComponent<SpriteRenderer>().flipY = false;
        }
    }
}
