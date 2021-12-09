using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public GameObject Cube0;
    public GameObject Cube1;

    public float Distance_Between;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance_Between = Vector3.Distance(Cube0.transform.position,Cube1.transform.position);
    }
}
