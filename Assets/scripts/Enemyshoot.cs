using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemybullet : MonoBehaviour
{





    [SerializeField]
    Vector2 fireDirection = Vector2.right;

    [SerializeField]
    float coolDown;

    [SerializeField]
    EnemyBullet EnemybulletPrefab;
   
    [SerializeField]
    Transform spawnLocation;


    int s = 1;

    float timer = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

      
            Vector2 pos = transform.position;
            if (spawnLocation != null)
            {
                pos = spawnLocation.position;
            }

        while (s == 1)
        {
            for (int i = 0; i < 3; i++)
            {

                EnemyBullet p = Instantiate(EnemybulletPrefab, pos, Quaternion.identity);
                p.Init(fireDirection);

                timer = coolDown;
            }

            timer = coolDown;
        }
        

    }

}
