using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public Rigidbody RBCub ;
    public float force = 500 ;


    // Start is called before the first frame update
    void Start()
    {
        DoJump();
    }

    public void DoJump()
    {
        RBCub.AddForce(new Vector3(0,force,0)); 
    }

}
