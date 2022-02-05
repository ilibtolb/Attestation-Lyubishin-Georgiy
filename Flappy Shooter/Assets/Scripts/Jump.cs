using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody player;
    public float power;

    private bool click;

    private void Update()
    {
            if (Input.GetMouseButton(0))
            {
                click = true;
            }

    }

    private void FixedUpdate()
    {
        if (click)
        {
            player.AddForce(transform.up * power);
            click = false;
        }
    }
}
