using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("aaaa");
        if (other.CompareTag("Player"))
        {
            Debug.Log("fdp");
            Destroy(gameObject);
        }
    }
}
