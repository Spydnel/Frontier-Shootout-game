using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow : MonoBehaviour
{
    public float slow = 0.5f;
    bool active = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            active = !active;

            if (active)
            {
                Time.timeScale = slow;
            }
            else
            {
                Time.timeScale = 1.0f;
            }
        }
        

    }
}
