using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVirtualController : MonoBehaviour
{
    public PlayerMovement _player;
    public VirtualJoystick _VirtualJoy;

    //Button
    static public bool m_FireUp;
    public VirtualButtonState _FireUpButton;
    static public bool m_FireLeft;
    public VirtualButtonState _FireLeftButton;
    static public bool m_FireRight;
    public VirtualButtonState _FireRightButton;
    static public bool m_FireDown;
    public VirtualButtonState _FireDownButton;
    static public bool m_UseItem;
    public VirtualButtonState _UseItem;
    // Start is called before the first frame update
    void Start()
    {
        _player = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //Fire Up Button
        if (_FireUpButton._currentState == VirtualButtonState.State.Down && m_FireUp == false)
        {
            m_FireUp = true;
        }
        if (_FireUpButton._currentState == VirtualButtonState.State.Up)
        {
            m_FireUp = false;
        }
        //Fire Left Button
        if (_FireLeftButton._currentState == VirtualButtonState.State.Down && m_FireLeft == false)
        {
            m_FireLeft = true;
        }
        if (_FireLeftButton._currentState == VirtualButtonState.State.Up)
        {
            m_FireLeft = false;
        }
        //Fire Right Button
        if (_FireRightButton._currentState == VirtualButtonState.State.Down && m_FireRight == false)
        {
            m_FireRight = true;
        }
        if (_FireRightButton._currentState == VirtualButtonState.State.Up)
        {
            m_FireRight = false;
        }
        //Fire Down Button
        if (_FireDownButton._currentState == VirtualButtonState.State.Down && m_FireDown == false)
        {
            m_FireDown = true;
        }
        if (_FireDownButton._currentState == VirtualButtonState.State.Up)
        {
            m_FireDown = false;
        }
        //Use Item Button
        if (_UseItem._currentState == VirtualButtonState.State.Down && m_UseItem == false)
        {
            m_UseItem = true;
        }
        if (_UseItem._currentState == VirtualButtonState.State.Up)
        {
            m_UseItem = false;
        }

        //_player.SetMovementPlayer(_VirtualJoy.InputVector.x, _VirtualJoy.InputVector.z);
    }
}
