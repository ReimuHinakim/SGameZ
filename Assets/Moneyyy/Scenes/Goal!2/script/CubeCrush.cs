using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCrush : MonoBehaviour
{

    Vector3 pos;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;

        player = GameObject.Find("Player");
    }


    // Update is called once per frame
    void Update()
    {
        float playerDistance;
        playerDistance = Vector3.Distance(player.transform.position,
        gameObject.transform.position);

        if (playerDistance < 2.0f)
        {
            pos.x -= 0.1f;
        }

        gameObject.transform.position = pos;





    }
}
