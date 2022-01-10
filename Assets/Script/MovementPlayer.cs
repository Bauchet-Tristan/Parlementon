using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{

    public LayerMask mask;
    public GameObject token; 


    void Update()
    {

        //Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * 50);
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out var hit1, 50, mask))
        {
            token.transform.position = hit1.point;
            //new Vector3(hit1.point.x, didier.transform.position.y, hit1.point.z);
        }
    }

    public void Deplacement()
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out var hit, 50, mask))
        {
            transform.position = new Vector3(hit.point.x, transform.position.y, hit.point.z);
        }
    }

}
