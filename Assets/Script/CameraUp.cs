
using UnityEngine;

public class CameraUp : MonoBehaviour
{
    private float _cameraSpeed = 1;
    public int invertCam = -1;
    private float cameraAngle = 0;

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
                cameraAngle += (Input.GetAxis("Mouse Y") *_cameraSpeed * invertCam);
                cameraAngle = Mathf.Clamp(cameraAngle,-40,40);

                transform.localRotation = Quaternion.Euler(cameraAngle, 0, 0);
            }
        }

    }
}
