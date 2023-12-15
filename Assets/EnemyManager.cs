using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Enemy enemy;
    public Transform spawnLocation;

    public float timer;
    float timerReset;

    // Start is called before the first frame update
    void Start()
    {
        timerReset = timer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        Vector2 pos = transform.position;

        if (timer < 0)
        {
            Enemy managedEnemy = Instantiate(enemy, pos, Quaternion.identity);
            timer = timerReset;
        }
        


    }
}
