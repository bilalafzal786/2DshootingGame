using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUpDown : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetButtonUp("Vertical")){
            rb.velocity=transform.up*speed;
        }   
    }
}
