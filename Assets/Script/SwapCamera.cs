using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCamera : MonoBehaviour
{
    public GameObject Player;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;

    public Vector3 positionRemember;

    public void start()
    {
        Player.transform.position = Camera1.transform.position;
    }
    public void Swap()
    {
        if(Player.transform.position != Camera1.transform.position && Player.transform.position != Camera2.transform.position)
        {
            Player.transform.position = Camera1.transform.position;
        }
        else if(Player.transform.position == Camera1.transform.position)
        {
            Player.transform.position = Camera2.transform.position;
        }
        else if(Player.transform.position == Camera2.transform.position)
        {
            Player.transform.position = Camera3.transform.position;
        }
        else if(Player.transform.position == Camera3.transform.position)
        {
            Player.transform.position = Camera1.transform.position;
        }
    }
}
