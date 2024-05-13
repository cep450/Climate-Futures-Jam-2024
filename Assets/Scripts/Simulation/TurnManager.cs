using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{

	/*
		Controls progression of the game.
		Emits events e.g. 'player turn ended'.
	*/

	public enum State {
		Menu,
		Dialogue,
		PlayerTurn, 
		EnemyTurn
	}



	public State state = State.Menu;

	int turnNumber = 0;

	[SerializeField] TimeOfDay[] timeOfDayCycle;

	public TimeOfDay GetTimeOfDay() {
		return timeOfDayCycle[(int)Mathf.Repeat(turnNumber, timeOfDayCycle.Length)];
	}

	public delegate void OnBeginPlayerTurn();
	public static event OnBeginPlayerTurn onBeginPlayerTurn;
	public delegate void OnEndPlayerTurn();
	public static event OnEndPlayerTurn onEndPlayerTurn;
	public delegate void OnBeginEnemyTurn();
	public static event OnBeginEnemyTurn onBeginEnemyTurn;
	public delegate void OnEndEnemyTurn();
	public static event OnEndPlayerTurn onEndEnemyTurn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	// begin the first turn 
	public void BeginLevel() {


		// begin at dawn- muted colors 
	}

	void BeginPlayerTurn() {

	}

	void CompletePlayerTurn() {

	}

	void BeginEnemyTurn() {

	}

	void EndEnemyTurn() {

	}
}
