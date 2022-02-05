using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugDestroy : MonoBehaviour
{
    public GameObject bug;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "fire(Clone)")
        {
            Destroy(other.gameObject);
            Destroy(bug);
        }
    }
}
