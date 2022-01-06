using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public Tool tool;
    public GameObject player;
    public float Distance_Between;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(tool==null)
            {
                //print("yapadtool");
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
        tool.gameObject.SetActive(true);
    }

    public void InteractWithObject(InteractableObject go)
    {
        if(tool==null)
        {
            //print("yapadtool");
        }
        else
        {
            Distance_Between = Vector3.Distance(go.transform.position, player.transform.position);

            if(Distance_Between <= 15)
            {
                tool.UseToolWithGameObject(go);
            }
            else
            {
                print("Tes un peu loin de l'objet la non ?! ATTOOLLL LES OPTICIEN !!!!");
            }
        }
    }
}
