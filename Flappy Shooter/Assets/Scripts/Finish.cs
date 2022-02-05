using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public MenuButons win;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Drema_the_Dragon")
        {
            win.Win();
        }
    }
}
