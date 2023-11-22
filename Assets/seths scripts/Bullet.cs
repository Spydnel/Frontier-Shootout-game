using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public void Init(Vector2 velocity)
    {
        Rigidbody2D rb2 = GetComponent<Rigidbody2D>();
        if (rb2 == null)
        {
            Debug.LogError("Rigidbody missing");
            return;
        }

        //rb2.velocity = velocity;

        var direction = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void Update()
    {
        transform.position += transform.right * Time.deltaTime * 3;
    }
}
