using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Repeater _hor = new Repeater("Horizontal");
    Repeater _ver = new Repeater("Vertical");
    string[] _buttons = new string[] { "Fire1", "Fire2" };

    public static event EventHandler<InfoEventArgs<Vector2>> moveEvent;
    public static event EventHandler<InfoEventArgs<int>> fireEvent;

    // Update is called once per frame
    void Update()
    {
        int x = _hor.Update();
        int y = _ver.Update();

        if (x != 0 || y != 0)
        {
            if (moveEvent != null)
                moveEvent(this, new InfoEventArgs<Vector2>(new Vector2(x, y)));
        }

        if (Input.GetButtonUp(_buttons[0]) && !Input.GetButtonUp(_buttons[1]))
        {
            if (fireEvent != null)
                fireEvent(this, new InfoEventArgs<int>(0));
        }

        if (Input.GetButtonUp(_buttons[1]) && !Input.GetButtonUp(_buttons[0]))
        {
            if (fireEvent != null)
                fireEvent(this, new InfoEventArgs<int>(1));
        }
    }
}

class Repeater
{
    const float threshold = 0.5f;
    const float rate = 0.25f;
    float _next;
    bool _hold;
    string _axis;

    public Repeater(string axisName)
    {
        _axis = axisName;
    }

    public int Update()
    {
        int retValue = 0;
        int value = Mathf.RoundToInt(Input.GetAxisRaw(_axis));

        if (value != 0)
        {
            if (Time.time > _next)
            {
                retValue = value;
                _next = Time.time + (_hold ? rate : threshold);
                _hold = true;
            }
        }
        else
        {
            _hold = false;
            _next = 0;
        }

        return retValue;
    }
}