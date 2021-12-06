using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public Tool tool;
    public GameObject didier;

        
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(tool==null)
            {
                print("yapadtool");
            }
            else
            {
                tool.UseTool();
            }
        }
    }

    public void ChangeTool(Tool newTool)
    {
        if(tool != null)
        {
            tool.gameObject.SetActive(false);
        }
        tool = newTool;
        newTool.gameObject.SetActive(true);
    }

    public void RevealTool(GameObject newdidier)
    {
        didier.SetActive(false);
        didier = newdidier;
        didier.SetActive(true);
    }

    public void InteractWithObject(InteractableObject go)
    {
        if(tool==null)
        {
            print("yapadtool");
        }
        else
        {
            tool.UseToolWithGameObject(go);
        }
    }
}
