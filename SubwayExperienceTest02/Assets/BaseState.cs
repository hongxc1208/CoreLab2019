using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseState : MonoBehaviour
{
    public float timer = 5.0f;
    public GameObject baseplayer;



    private void Start()
    {
        baseplayer.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;



        if (timer <= 0.0f)
        {

            timeEnded();
        }

    }

    void timeEnded()
    {

        Debug.Log("time's up");
        baseplayer.SetActive(true);

    }
}
