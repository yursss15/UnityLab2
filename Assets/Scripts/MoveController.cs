using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class MoveController : MonoBehaviour,
    IStartGameListener,
    IFinishGameListener
{
    [SerializeField]
    private KeyboardInput Input;

    [SerializeField]
    private Player Player;


    void IStartGameListener.OnStartGame()
    {
        this.Input.OnMove += this.OnMove;
    }


    void IFinishGameListener.OnFinishGame()
    {
        this.Input.OnMove -= this.OnMove;
    }

    private void OnMove(Vector3 direction)
    {
        this.Player.Move(direction);
    }
}
