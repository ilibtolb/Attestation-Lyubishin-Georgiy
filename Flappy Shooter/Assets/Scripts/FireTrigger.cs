using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "fire(Clone)")
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.name == "Lowpoly_Lady_Bug(Clone)")
        {
            other.GetComponent<BugFire>().shot = true;
        }
    }
}
