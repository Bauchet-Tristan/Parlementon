using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : InteractableObject
{
    public override void InteractWithAxe()
    {
        Destroy(gameObject);
    }

    public override void InteractWithLance()
    {
        print("Je suis du bois mouillé");
    }
}
