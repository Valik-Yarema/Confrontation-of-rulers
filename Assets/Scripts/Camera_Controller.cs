using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    float xRot=0;
    float yRot=0;

    float xCurRot;
    float yCurRot;
    float xCurV;
    float yCurV;
    float CamMax = 50;  //висота
    float CamMin = 1;

    float TransX;
    float TransZ;

    float SpeedRot = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraRotation();
        CameraZoom();
        CameraTranslate();
    }

    private void CameraTranslate()
    {
        TransZ = Input.GetAxis("Vertical") * 10f * Time.deltaTime;
        TransX = Input.GetAxis("Horizontal") * 10f * Time.deltaTime;
        gameObject.transform.Translate(TransX, 0, TransZ);
    }

    private void CameraZoom()
    {
        if((Input.GetAxis("Mouse ScrollWheel") < 0) && (Camera.main.transform.position.y<CamMax))
        {
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, (Camera.main.transform.position.y + 0.2f), Camera.main.transform.position.z);
        }
        if ((Input.GetAxis("Mouse ScrollWheel") >0) && (Camera.main.transform.position.y > CamMin))
        {
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, (Camera.main.transform.position.y - 0.2f), Camera.main.transform.position.z);
        }
    }

    private void CameraRotation()
    {
        if (Input.GetMouseButton(2))
        {
            xRot -= Input.GetAxis("Mouse Y") * SpeedRot;
            yRot += Input.GetAxis("Mouse X") * SpeedRot;

            xRot = Mathf.Clamp(xRot, -10, 85);

            xCurRot = Mathf.SmoothDamp(xCurRot, xRot, ref xCurV, 0.1f);
            yCurRot = Mathf.SmoothDamp(yCurRot, xRot, ref yCurV, 0.1f);
            Camera.main.transform.rotation = Quaternion.Euler(xCurRot, yCurRot, 0);

        }
    }
   


}
