using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletSprite : MonoBehaviour
{
    
    public SpriteRenderer spriteRenderer;
    public Sprite[] bulletInd; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerShooting.bulletCount > -1 && playerShooting.bulletCount < 6)
        {
            spriteRenderer.sprite = bulletInd[playerShooting.bulletCount];
        }
        
    }
}
