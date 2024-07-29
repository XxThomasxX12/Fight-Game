using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public GameObject fist;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy")
        {
            print("ENTER");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            print("STAY");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            print("EXIT");
        }
    }
}
    
