using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public float hareketHizi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hareketEt();
    }
    void hareketEt()
    {
        transform.Translate (Vector3.left * hareketHizi * Time.deltaTime);
    }
}
