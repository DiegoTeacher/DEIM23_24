using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float bulletSpeed;
    public GameObject gunPoint;
    public GOPool bulletPool;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // acceder a un objeto inactivo de la pool
            GameObject bullet = bulletPool.GetInactiveGameObject();
            if (bullet != null)
            {
                // activar el objeto
                bullet.SetActive(true);
                // cambiar posicion bala a punta pistola
                bullet.transform.position = gunPoint.transform.position;
                bullet.GetComponent<Bullet>().direction = gunPoint.transform.right;
                bullet.GetComponent<Bullet>().speed = bulletSpeed;
            }
        }
    }
}
