using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Rigidbody bullet ;
    private float force = 1500 ;
    public float lifeTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        DoIt();
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime = lifeTime - Time.deltaTime; 

        if( lifeTime <= 0)
        {
            Destroy(gameObject);
        }

    }

    public void DoIt()
    {
        bullet.AddForce(transform.forward * force); 
    }
}
