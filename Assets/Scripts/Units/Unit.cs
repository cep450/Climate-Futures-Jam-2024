using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour, ITurnTaker
{

    [SerializeField] List<Action> actions;

	[SerializeField] int hpMax = 1;
	[SerializeField] int hp;


	public Tile.TileProperties canBePlacedOn;	// Valid tiles when placing this unit.
	public Tile.TileProperties canStandOn; 		// Tiles this unit can end a turn on, tiles considered valid to end a move on.
	public Tile.TileProperties canPassThrough;  // Tiles considered valid when moving.

	public bool hasMovedThisTurn = false;
	[SerializeField] int actionsPerTurn = 1;
	public int actionsRemaining;

	VisualUnit visualUnit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

	public void AddedToBoard() {

		hp = hpMax;
		
	}

    // Update is called once per frame
    void Update()
    {
        
    }



	public void ApplyDamage(int dmg) {

		hp = hp - dmg; 

		//TODO display any visual effects if needed 

		if(hp <= 0) {
			Die();
		}
	}

	public void Die() {

		//TODO 
		//any effect or animation we're playing 
		// remove the unit 
		// create scrap on the board where the unit was 
	}

	public void BeginTurn() {
		hasMovedThisTurn = false;
		actionsRemaining = actionsPerTurn;
	}

	public void TakeTurn() {

	}

	public void EndTurn() {

	}

	public bool HasActionsRemaining() {
		return (!hasMovedThisTurn || actionsRemaining > 0);
	}

	
}
