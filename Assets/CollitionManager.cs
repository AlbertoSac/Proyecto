using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionManager : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("touched something");
    }
}