using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyTrigger : MonoBehaviour
{
    public MenuButons LoseMenu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Drema_the_Dragon")
        {
            LoseMenu.Lose();
        }
        if (other.gameObject.name == "fire(Clone)")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

}
