using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float            _Walk, _Sprint;

    private PlayerMovement  _Input;
    private float           _DirectionX, _DirectionY, _Speed;

    // Start is called before the first frame update
    void Awake()
    {
        _Input = new PlayerMovement();
        _Speed = _Walk;

        _Input.KeyBoard.InputH.performed += ctx => _DirectionX = ctx.ReadValue<float>() * 1;
        _Input.KeyBoard.InputH.canceled += ctx => _DirectionX = 0f;

        _Input.KeyBoard.InputV.performed += ctx => _DirectionY = ctx.ReadValue<float>() * 1;
        _Input.KeyBoard.InputV.canceled += ctx => _DirectionY = 0f;

        _Input.KeyBoard.Sprint.performed += ctx => _Speed = _Sprint;
        _Input.KeyBoard.Sprint.canceled += ctx => _Speed = _Walk;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_DirectionX * _Speed * Time.deltaTime, 0f, _DirectionY * _Speed * Time.deltaTime);
    }

    private void OnEnable()
    {
        _Input.KeyBoard.Enable();
    }

    private void OnDisable()
    {
        _Input.KeyBoard.Disable();
    }

}
