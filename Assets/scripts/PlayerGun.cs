using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite[] reloadInstance;
    float timer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (playerShooting.reloading)
        {
            timer += Time.unscaledDeltaTime;
            if (timer < 0.25f)
            {
                spriteRenderer.sprite = reloadInstance[0];
            }
            else if (timer < 0.5f)
            {
                spriteRenderer.sprite = reloadInstance[1];
            }
            else if (timer < 0.75f)
            {
                spriteRenderer.sprite = reloadInstance[2];
            }
            else if (timer < 1f)
            {
                spriteRenderer.sprite = reloadInstance[3];
            }
            else if (timer < 1.25f)
            {
                spriteRenderer.sprite = reloadInstance[0];
            }
            else if (timer < 1.5f)
            {
                spriteRenderer.sprite = reloadInstance[1];
            }

            else
            {
                timer = 0;
            }
        }
        else
        {
            timer = 0;
            spriteRenderer.sprite = reloadInstance[4];
        }
    }
}
