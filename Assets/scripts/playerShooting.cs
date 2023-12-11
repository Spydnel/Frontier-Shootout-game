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
    public float reloadTimer = 2f;
    float reloadTimerReset;
    public static bool reloading = false;

    // Start is called before the first frame update
    void Start()
    {
        reloadTimerReset = reloadTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && bulletCount < 6)
        {
            reloading = true;
        }

        if (reloading && reloadTimer > 0)
        {
            reloadTimer -= Time.unscaledDeltaTime;
        }
        else if (reloading && reloadTimer < 0)
        {
            reloading = false;
            bulletCount = 6;
            reloadTimer = reloadTimerReset;
        }


        timer -= Time.unscaledDeltaTime;

        if ((fireButton == KeyCode.None || Input.GetKeyDown(fireButton)) && timer <= 0 && bulletCount > 0 && reloading == false)
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
