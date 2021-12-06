using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lance : Tool
{   
    

    public override void UseTool()
    {

    }


    public override void UseToolWithGameObject(InteractableObject go)
    {
        go.InteractWithLance(); 
    }

}
