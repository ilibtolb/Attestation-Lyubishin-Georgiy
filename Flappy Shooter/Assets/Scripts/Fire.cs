using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private float timeDelta = 0;
    public GameObject bullet;
    public Transform player;
    private Vector3 deltaPosition;
    public float speed = 2;
    public Transform parent;
    private float shootTime = 1;


    void Update()
    {
        if (Time.time - timeDelta > shootTime)
        {
            this.Shoot();
            timeDelta = Time.time;
        }
    }
    private void Shoot()
    {
        deltaPosition = new Vector3(-3f, 2.35f, 0.6f);
        Quaternion Rotation = Quaternion.Euler(-90, 0, 0);
        GameObject projectile = Instantiate(bullet, player.position + deltaPosition, Rotation);
        projectile.transform.parent = parent;
        projectile.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, speed);
    }

    public void NextLvl()
    {
        shootTime -= 0.1f;
        speed += 0.5f;
    }
}
