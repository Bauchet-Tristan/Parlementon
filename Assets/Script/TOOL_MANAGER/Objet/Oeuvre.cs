using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oeuvre : InteractableObject
{

    public override void InteractWithAxe()
    {
        print("Bah toujours plus ! Découpe tous le parlement tant que t-y est ");
    }

    public override void InteractWithLance()
    {
        print("Super le mec mouille les tapisseries");
    }

    public override void InteractWithHand()
    {
        Destroy(gameObject);
    }
}
