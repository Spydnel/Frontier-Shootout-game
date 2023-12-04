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

    float timer = 0;

    // Start is called before the first frame update
     void Start()
    {

    }

    // Update is called once per frame
    public void pew()
    {
        timer -= Time.deltaTime;

        Vector2 pos = transform.position;
        if (spawnLocation != null)
        {
            pos = spawnLocation.position;
        }

        while (s == 2)
        {



            for (int i = 0; i < 5; i++)
            {






                EnemyBullet p = Instantiate(EnemybulletPrefab, pos, Quaternion.identity);
                p.Init(fireDirection);



                Debug.Log("pew");
                timer = coolDown;
            }

        }



        timer = coolDown;

    }

}


