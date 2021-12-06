using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flamme : InteractableObject
{
    public override void InteractWithAxe()
    {
        print("La hache ne m'eteins pas...");
    }

    public override void InteractWithLance()
    {
        Destroy(gameObject);
    }
}