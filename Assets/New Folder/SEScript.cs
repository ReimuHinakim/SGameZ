using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SEScript : MonoBehaviour
{
    public Text PointText;
    public static int Point;

    AudioSource audioSource;
    public AudioClip SE1;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        PointText.text = Point.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(SE1);
            Point += 1;
        }
    }

}
