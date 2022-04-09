using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerZ : MonoBehaviour
{
    Rigidbody rb;

    bool isJump;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        isJump = false;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos;

        pos = rb.position;

        pos.x = Camera.main.ScreenToWorldPoint(Input.mousePosition +
        Camera.main.transform.forward * 3).x;

        rb.MovePosition(pos);

        Vector3 vel;

        vel = rb.velocity;

        if (isJump == true)
        {
            vel.y = 7;

            isJump = false;

        }
        vel.z = 3;
        rb.velocity = vel;
    }

    public void Jump()
    {
     
        isJump = true;
    }
}






























