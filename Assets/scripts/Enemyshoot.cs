using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.PlayerSettings;

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

    float timer = 10;

    // Start is called before the first frame update
     public void Start()
    {
        for (int i =0; i <5; i++)
        {
            Thread.Sleep(5000);
            for (int s=0; s < 3; i++)
            {
                Thread.Sleep(1000);

                Vector2 pos = transform.position;
                if (spawnLocation != null)
                {
                    pos = spawnLocation.position;
                }
                EnemyBullet p = Instantiate(EnemybulletPrefab, pos, Quaternion.identity);
                p.Init(fireDirection);



                Debug.Log("pew");
                
            }
        }
    }

    // Update is called once per frame
    public void Update()
    {
        timer -= Time.deltaTime;

      
            

        



        timer = coolDown;

    }

}


