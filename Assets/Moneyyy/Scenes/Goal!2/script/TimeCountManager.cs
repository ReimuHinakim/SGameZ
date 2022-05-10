using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCountManager: MonoBehaviour
{
    public float timeCount;
    public Text countDownText;

    // Start is called before the first frame update
    void Start()
    {
        timeCount = 6;
    }

    // Update is called once per frame
    void Update()
    {
        timeCount -= Time.deltaTime;
        countDownText.text = "CountDown" + timeCount.ToString("f0");

        if (timeCount <= 0)
        {
            SceneManager.LoadScene("Stage2");
        }
    }
}
