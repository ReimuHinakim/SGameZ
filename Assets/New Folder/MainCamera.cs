using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    Vector3 pos;

    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

        pos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        pos.z = player.transform.position.z - 2;

        gameObject.transform.position = pos;
    }
}
