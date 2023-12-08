using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SlowMeter : MonoBehaviour
{
    float scaledCount;
    public SpriteRenderer color;
    float offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position.x;
    }

    public void Count(float count, float countMult)
    {
        Debug.Log(count);

        scaledCount = count * 6 / countMult;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(offset + scaledCount/2, transform.position.y, 0);
        transform.localScale = new Vector3(scaledCount, 0.5f, 1f);

        if (scaledCount < 2)
        {
            color.color = new Color32(102, 32, 73, 200);
        }
        else if (scaledCount >= 6f)
        {
            color.color = new Color32(250, 9, 9, 200);
        }
        else
        {
            color.color = new Color32(230, 81, 7, 200);
        }
    }
}
