using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShooting : MonoBehaviour
{
    public ParticleSystem muzzleFlash;

    [SerializeField]
    public static int bulletCount = 6;

    [SerializeField]
    KeyCode fireButton;

    [SerializeField]
    Vector2 fireDirection = Vector2.left;

    [SerializeField]
    float coolDown;

    [SerializeField]
    Bullet bulletPrefab;
    [SerializeField]
    Transform spawnLocation;


    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if ((fireButton == KeyCode.None || Input.GetKeyDown(fireButton)) && timer <= 0)
        {
            Vector2 pos = transform.position;
            if(spawnLocation != null)
            {
                pos = spawnLocation.position;
            }

            Bullet p = Instantiate(bulletPrefab, pos, Quaternion.identity);
            p.Init(fireDirection);
            CameraShake.shakeDuration = 0.1f;
            timer = coolDown;
            bulletCount -= 1;

            muzzleFlash.Play();
        }
    }
}
