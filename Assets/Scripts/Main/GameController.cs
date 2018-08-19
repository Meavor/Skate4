using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : StateMachine
{
    public LineCreator lineCreator;
    public StartMenu startMenu;

    public GameObject playerPrefab;
    public Player player;

    public ulong score;
    public ulong distance;

    // Use this for initialization
    void Start ()
    {
        ChangeState<StartState>();	
	}
}
