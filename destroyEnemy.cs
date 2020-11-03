using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEnemy : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other) {
        
        anim.SetTrigger("ColliderDetector");
        // Destroy(gameObject);
       // if(other.CompareTag("bullet1")){
            
        //}
    }
}
