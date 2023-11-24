using System.Collections;
using System.Collections.Generic;
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
        spriteRenderer.sprite = bulletInd[Shooter.bulletCount];
    }
}
