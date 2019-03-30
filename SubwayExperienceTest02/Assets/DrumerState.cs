using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumerState : MonoBehaviour
{
    public float timer = 5.0f;
    public GameObject drumer;



    private void Start()
    {
        drumer.SetActive(false);

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
        drumer.SetActive(true);

    }
}
