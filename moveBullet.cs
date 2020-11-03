using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBullet : MonoBehaviour
{
    public Animator anim;
    public float speed;
    public Rigidbody2D bullet;
    // Start is called before the first frame update
    void Start()
    {
        bullet.velocity=transform.right*speed;
        anim.SetFloat("position",(bullet.position.x));
    }

    void OnCollisionEnter2D(Collision2D col){
        
        Destroy(gameObject);
       
}
}
