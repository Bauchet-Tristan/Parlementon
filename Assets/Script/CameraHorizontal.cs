
using UnityEngine;

public class CameraHorizontal : MonoBehaviour
{
    private float _cameraSpeed = -1;

    private void Start()
    {  
    }

    private void Update()
    {
        if(Time.timeScale == 0 )
        {

        }
        else
        {
            if(Input.GetMouseButton(0))
            {
                transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * _cameraSpeed, 0));
            }
        }
    }
}
