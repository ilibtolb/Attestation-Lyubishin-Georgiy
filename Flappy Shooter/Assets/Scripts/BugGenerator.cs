using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugGenerator : MonoBehaviour
{
    public GameObject bug;
    public float speed = 2;
    private Vector3 bugPosition;
    private int maxBugs = 10;
    public Transform parent;
    private Vector3 finishPosition;
    public GameObject finish;


    public void CreateLvl()
    {
        Quaternion Rotation = Quaternion.Euler(0, 0, 0);
        for (int i = 0; i < maxBugs; i++)
        {
            bugPosition = new Vector3(-3.3f, Random.Range(-3.85f, 2.65f), 20 + (i * 5));
            GameObject projectile = Instantiate(bug, bugPosition, Rotation);
            projectile.transform.parent = parent;
            projectile.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -speed);
        }

        finishPosition = new Vector3(-3.3f, 2, 20 + (maxBugs * 5));
        GameObject end = Instantiate(finish, finishPosition, Rotation);
        end.transform.parent = parent;
        end.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -speed);
    }

    public void NextLvl()
    {
        speed += 0.5f;
        maxBugs += 2;
        CreateLvl();
    }
}
