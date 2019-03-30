using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarriageTopState : MonoBehaviour
{
    public float timer = 5.0f;
    public float timer2 = 5.0f;
    public GameObject CarriageTop;



    private void Start()
    {
        CarriageTop.SetActive(true);

    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timer2 -= Time.deltaTime;


        if (timer <= 0.0f)
        {
            timeEnded();
        }

        if(timer2 <= 0.0f)
        {
            experienceEnded();
        }

    }

    void timeEnded()
    {

        Debug.Log("time's up");
        CarriageTop.SetActive(false);

    }

    void experienceEnded() {
        CarriageTop.SetActive(true);
    
    }
}
