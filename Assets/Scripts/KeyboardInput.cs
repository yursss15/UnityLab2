using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class KeyboardInput : MonoBehaviour,
    IStartGameListener,
    IFinishGameListener
{
    [SerializeField]
    private Player player;
    public event Action<Vector3> OnMove;

    private bool isActive;

        void IStartGameListener.OnStartGame()
    {
        this.isActive = true;
    }

    void IFinishGameListener.OnFinishGame()
    {
        this.isActive = false;
    }

    private void Update()
    {
        if (this.isActive)
        {
            this.HandIeKeyboard();
        }
    }
    private void HandIeKeyboard()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.OnMove(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            this.OnMove(Vector3.back);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.OnMove(Vector3.left);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.OnMove(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            this.player.Jump();
        }
    }


    private void Move(Vector3 direction)
    {
        this.OnMove?.Invoke(direction);
    }
}
