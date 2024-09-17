using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObstacle : MonoBehaviour
{
    float xAngle = 0;
    float yAngle = 1;

    float zAngle = 0;

   

    // Update is called once per frame
    void Update()
    {
        // Rotate the object over time
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}

