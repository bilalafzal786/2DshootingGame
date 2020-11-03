using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBullet : MonoBehaviour
{
    public Transform bulletPoint;
    public GameObject prefab;
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            createBullets();
        }
    }
    void createBullets(){
        Instantiate(prefab, new Vector2(bulletPoint.position.x,bulletPoint.position.y ),Quaternion.identity );

    }
}
