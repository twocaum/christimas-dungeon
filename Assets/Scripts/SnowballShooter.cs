using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballShooter : MonoBehaviour
{
    public GameObject snowballPrefab;
    public Vector3 _initialVelocity;
    public float _initialInterval;

    void Start()
    {
        InvokeRepeating("_fire", _initialInterval, 1.0f);
    }

    private void _fire()
    {
        GameObject snowball = Instantiate(snowballPrefab, transform.position, Quaternion.identity);
        Rigidbody rb = snowball.GetComponent<Rigidbody>();

        rb.AddForce(_initialVelocity, ForceMode.VelocityChange);
    }
}