using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBlue : MonoBehaviour
{
    public float forceJump;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Doodle.instance.DoodleRigid.velocity = Vector2.up * forceJump;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            float RandX = Random.Range(-1.7f, 1.7f);
            float RandY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);

            transform.position = new Vector3(RandX, RandY, 0);
        }
    }

    private bool To_Right = true;
    private float Offset = 1.2f;

    void FixedUpdate()
    {
        // Move the platform
        Vector3 Top_Left = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));

        if (To_Right) // Move to right
        {
            if (transform.position.x < -Top_Left.x - Offset)
                transform.position += new Vector3(0.05f, 0, 0);
            else
                To_Right = false;
        }
        else // Move to left
        {
            if (transform.position.x > Top_Left.x + Offset)
                transform.position -= new Vector3(0.05f, 0, 0);
            else
                To_Right = true;
        }
    }
}
