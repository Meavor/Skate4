using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitState : GameState
{
    public override void Enter()
    {
        base.Enter();
        StartCoroutine(Init());
    }

    IEnumerator Init()
    {
        GameObject obj = GameObject.Instantiate(owner.playerPrefab,
            new Vector3(0f, 3f, 0f), Quaternion.identity);
        owner.player = obj.GetComponent<Player>();
        owner.score = 0;
        owner.distance = 0;

        yield return null;
        owner.ChangeState<MainState>();
    }
}
