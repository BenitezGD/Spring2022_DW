using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20;
    float h = 0;
    float v = 0;
    Rigidbody2D rb;
    SpriteRenderer spr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * speed * Time.deltaTime, ForceMode2D.Impulse);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * speed * Time.deltaTime, ForceMode2D.Impulse);
        }

        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }

        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * speed * Time.deltaTime, ForceMode2D.Impulse);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * speed * Time.deltaTime, ForceMode2D.Impulse);
        }

        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        Mathf.Clamp(rb.velocity.magnitude,0f, speed);
        */

        h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        v = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.position += new Vector3(h, v );

        if(h < 0 )
        {
            spr.flipX = true;
        }

        else if (h > 0)
        {
            spr.flipX = false;
        }
        

    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Moveable")
        {
            if(Input.GetKey(KeyCode.E))
            {
                other.transform.parent = transform;
                
            }

            else
            {
                other.transform.parent = null;
            }
        }
    }

}
