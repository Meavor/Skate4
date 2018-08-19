using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameState : State
{
    protected GameController owner;
    public LineCreator lineCreator { get { return owner.lineCreator; } }
    public Transform player { get { return owner.player.gameObject.transform; } }

    protected virtual void Awake()
    {
        owner = GetComponent<GameController>();
    }

    protected override void AddListeners()
    {
        PlayerController.moveEvent += OnMove;
        PlayerController.fireEvent += OnFire;
    }

    protected override void RemoveListeners()
    {
        PlayerController.moveEvent -= OnMove;
        PlayerController.fireEvent -= OnFire;
    }

    protected virtual void OnMove(object sender, InfoEventArgs<Vector2> e)
    {

    }

    protected virtual void OnFire (object sender, InfoEventArgs<int> e)
    {

    }
}
