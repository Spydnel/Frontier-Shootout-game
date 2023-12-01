using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow : MonoBehaviour
{
    public float slow = 0.5f;
    bool active = false;
    public float slowTime = 6;
    float slowTimeMult;

    // Start is called before the first frame update
    void Start()
    {
        slowTimeMult = slowTime;
    }

    // Update is called once per frame
    void Update()
    {

        
        
        if (Input.GetKeyDown(KeyCode.Q) && slowTime > slowTimeMult / 3 && active == false)
        {
            active = true;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && active == true)
        {
            active = false;
        }



        if (active)
        {
            Time.timeScale = slow;
        }
        else
        {
            Time.timeScale = 1.0f;
        }

        if (active && slowTime > 0f)
        {
            slowTime -= Time.unscaledDeltaTime * 2f;
        }
        else if (active = false && slowTime < slowTimeMult)
        {
            slowTime += Time.unscaledDeltaTime;
        }
        else if (slowTime <  0f && active == true)
        {
            active = false;
        }


    }
}
