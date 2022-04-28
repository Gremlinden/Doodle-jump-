using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public Transform doodlePos; 

    void Update()
    {
        if (doodlePos.position.y > transform.position.y) 
        {
            transform.position = new Vector3(transform.position.x, doodlePos.position.y, transform.position.z);
        }

        if (doodlePos.position.x <= -3f)
        {
            doodlePos.position = new Vector3(2.9f, doodlePos.position.y, doodlePos.position.z);
        }

        if (doodlePos.position.x >= 3f)
        {
            doodlePos.position = new Vector3(-3f, transform.position.y, doodlePos.position.z);
        }

    }
}
