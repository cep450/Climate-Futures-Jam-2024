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

	[SerializeField] Board board;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Find references to everything we need
	public void LoadNewLevel() {
		
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

	// Coroutine managing the enemy's turn. Includes waiting for movement, animations, ect.
	IEnumerator EnemyTurn() {

		//iterate through the ordered list 
		//TODO 
		yield return null;

	}

	// Beginning of player's turn. 
	// Reset the player's unit's actions.
	IEnumerator PlayerTurnStart() {

		//TODO 
		yield return null;
	}

}
