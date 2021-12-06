using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRotation : MonoBehaviour
{

    // Start is called before the first frame update

    public void ResetRota()
    {
        transform.rotation = new Quaternion(0,0,0,0);
    }

}
