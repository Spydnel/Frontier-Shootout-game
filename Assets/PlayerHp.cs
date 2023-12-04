using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    int playerhp = 5; 


    public void PlayerAttacked()
    {
        playerhp -= 1; 

        if(playerhp == 0)
        {
            Destroy(gameObject);
        }
    }
}
