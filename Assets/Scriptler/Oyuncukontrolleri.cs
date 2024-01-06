using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyuncukontrolleri : MonoBehaviour
{
    public float ucusGucu;
    private Rigidbody2D rigiBody;
    public bool oyunBasladi;
    public bool oyunBitti;
    // Start is called before the first frame update
    void Start()
    {
        rigiBody = GetComponent<Rigidbody2D>();
        oyunBasladi = true;
        oyunBitti= false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (oyunBasladi)
            {
                rigiBody.gravityScale = 1;
                oyunBasladi = true;
                Uc();
            }
        }
    }
    void Uc()
    {
        rigiBody.velocity = Vector2.zero;
        rigiBody.AddForce(new Vector2(0, ucusGucu));
    }
   
    void OnTriggerEnter2D(Collider2D diger)
    {
        if (diger.tag == "OlumAlani")
        {
            oyunBitti = true;
            oyunBasladi= false;
        }
    }


 void OnCollisionEnter2D(Collision2D diger)
    {
        if (diger.transform.tag == "OlumAlani")
        {
            oyunBitti = true;
            oyunBasladi = false;
        }
    }
    }