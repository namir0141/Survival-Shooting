using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collsion : MonoBehaviour
{

    GameObject obj;
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("Hearse");
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Hearse"))
        {
            Debug.Log("Collision detected with Hearse");
        }
    }
}
