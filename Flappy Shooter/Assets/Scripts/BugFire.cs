using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugFire : MonoBehaviour
{
    public GameObject jelly;
    public Transform bug;
    private Vector3 deltaPosition;
    public float speed = 4;
    public Transform player;
    private Vector3 playerDelta;
    public bool shot;
    private float timeDelta = 0;
    public Transform parent;

    private void Update()
    {
        if (shot)
        {
            if (Time.time - timeDelta > 2.5f)
            {
                this.Shoot();
                timeDelta = Time.time;
            }
        }
    }

    private void Shoot()
    {

        deltaPosition = new Vector3(2.3f, 4f, -1.8f);
        playerDelta = new Vector3(0, -5f, 0);
        Vector3 vector = player.position - bug.position + playerDelta;
        Quaternion Rotation = Quaternion.Euler(0, -90, 0);
        GameObject projectile = Instantiate(jelly, bug.position + deltaPosition, Rotation);
        projectile.transform.parent = parent;
        projectile.GetComponent<Rigidbody>().velocity = vector.normalized * speed;
    }

    public void NextLvl()
    {
        speed += 1;
    }
}
