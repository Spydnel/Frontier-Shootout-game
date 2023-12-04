using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMeter : MonoBehaviour
{
    float scaledCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Count(float count, float countMult)
    {
        Debug.Log(count);

        scaledCount = count * 6 / countMult;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(scaledCount / 2 - 13.1f, transform.position.y, 0);
        transform.localScale = new Vector3(scaledCount, 1, 1);
    }
}
