using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addcollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("OtherObjectTag"))
        {
            Debug.Log("Collision detected");
        }
    }
}
