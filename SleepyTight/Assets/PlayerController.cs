using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if ((h == 1 || h ==-1) && (v == 1 || v == -1))
        {
            transform.position += new Vector3(h * speed/2 * Time.deltaTime, v * speed/2 * Time.deltaTime);
        }

        else
        {
            transform.position += new Vector3(h * speed * Time.deltaTime, v * speed * Time.deltaTime);
        }

        
        Debug.Log(rb.velocity.magnitude);
        //Mathf.Clamp(rb.velocity.magnitude,0f, speed);
    }
}
