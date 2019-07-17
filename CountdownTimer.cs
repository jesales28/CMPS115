using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0;
    float startingTime = 10;

    [serializeField] Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1* Time.deltaTime;
        countdownText.text = currentTime.toString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
