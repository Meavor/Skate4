using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainState : GameState
{
    protected override void OnFire(object sender, InfoEventArgs<int> e)
    {
        if(e.info == 0)
        {
            owner.player.Ollie();
        }
        else if (e.info == 1)
        {

        }
    }
}
