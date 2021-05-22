using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform            cameraTrans;
    [Range(0, 100)]
    public float                mouseSensitivity;
    public float                minRotation, maxRotation;

    private PlayerCam           _CameraControls;
    private float               xRotation = 0f;
    private Vector2              mousePos;

    // Start is called before the first frame update
    void Awake()
    {
        _CameraControls = new PlayerCam();
        _CameraControls.Mouse.mousePos.performed += ctx => mousePos = ctx.ReadValue<Vector2>() * mouseSensitivity * Time.deltaTime;
        _CameraControls.Mouse.mousePos.canceled += ctx => mousePos = Vector2.zero;
        mousePos = new Vector2();
    }

    // Update is called once per frame
    void Update()
    {

        xRotation -= mousePos.y;
        xRotation = Mathf.Clamp(xRotation, minRotation, maxRotation);

        cameraTrans.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mousePos.x);
    }

    private void OnEnable()
    {
        _CameraControls.Mouse.Enable();
    }

    private void OnDisable()
    {
        _CameraControls.Mouse.Disable();
    }
}
