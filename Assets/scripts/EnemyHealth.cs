using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    int maxHealth = 1;

    public GameObject score;

    int health;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    public void Hurt(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        ScoreCounter points = score.GetComponent<ScoreCounter>();
        points.Points(100);
        Destroy(gameObject);
    }
}
