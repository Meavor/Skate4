using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartState : GameState
{
    public int choice = 0;

    public override void Enter()
    {
        base.Enter();
        play();
    }

    void play()
    {
        
    }

    void StartGame()
    {
        StartCoroutine(HideStart());
    }

    void Options()
    {

    }

    protected override void OnMove(object sender, InfoEventArgs<Vector2> e)
    {
        
    }

    protected override void OnFire(object sender, InfoEventArgs<int> e)
    {
        if (e.info == 0 && choice == 0)
        {
            StartGame();
        }
        else if (e.info == 0 && choice == 1)
        {
            Options();
        }
    }

    IEnumerator HideStart()
    {
        yield return owner.startMenu.HideScreen();
        yield return new WaitForSeconds(0.2f);

        owner.ChangeState<InitState>();
    }
}
