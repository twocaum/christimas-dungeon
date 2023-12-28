using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GuardSnowmanManager : MonoBehaviour
{

    public Transform[] points;
    int current;
    public float speed;
    public float angleSpeed;
    private float totalRotation;

    public float fov;
    [Range(0, 360)] public float fovAngle;

    private void Start()
    {
        current = 0;
        totalRotation = 0;
    }

    private void Update()
    {
        if (transform.position != points[current].position)
        {
            transform.position = Vector3.MoveTowards(
                transform.position, 
                points[current].position, 
                speed * Time.deltaTime
                );

        }
        else
        {
            if (totalRotation > 0)
            {
                float rotation = angleSpeed * Time.deltaTime;
                transform.Rotate(new Vector3(0, rotation, 0));
                totalRotation -= rotation;
            }
            else 
            {
                current = (current + 1) % points.Length;
                totalRotation = 360 / points.Length;
            }
            
        }
            
    }
}
