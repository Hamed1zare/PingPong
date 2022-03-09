using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pc : MonoBehaviour
{
    public float speed = 30;
    public GameObject Ball;
    float direction = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
		
        float Racket_y = transform.position.y;
        float Racket_h = GetComponent<BoxCollider2D>().transform.localScale.y;
        float Ball_y = Ball.transform.position.y;
        float Ball_x = Ball.transform.position.x;

        if(Ball_x > 0)
        {
            if(Racket_y > Ball_y + Racket_h)
            {
                direction = -1;
            }
            else if(Racket_y < Ball_y - Racket_h)
            {
                direction = 1;
            }
            else
            {
                direction = 0;
            }
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, direction) * speed;
           
        }  
         
    }
}