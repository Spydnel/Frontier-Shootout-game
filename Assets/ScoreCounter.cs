using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{

    public GameObject scorecounter;
    public string scorePrefix;
    int scoreI;


    // Start is called before the first frame update
    void Start()
    {
        TextMesh text = scorecounter.GetComponent<TextMesh>();
    }

    public void Points(int points)
    {
        scoreI += points;
    }

    // Update is called once per frame
    void Update()
    {
        scoreI.ToString();

        TextMesh text = scorecounter.GetComponent<TextMesh>();
        text.text = scorePrefix + scoreI;
    }
}
