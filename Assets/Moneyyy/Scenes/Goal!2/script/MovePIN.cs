using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePIN : MonoBehaviour
{
    int counter = 0;
    float move = 0.1f;

    

    // Update is called once per frame
    void Update()
    {
        Vector3 p = new Vector3(move, 0, 0);
        transform.Translate(p);
        counter++;

        if(counter == 100)
        {
            counter = 0;
            move *= -1;
        }
    }
}
