using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Unit : MonoBehaviour, ITurnTaker
{
	public Board board;
	public VisualUnit visualUnit;


	[System.Serializable]
	public struct UnitTags {
		bool player; 
		bool enemy;
	}
	public UnitTags tags;


    [SerializeField] List<Attack> attacks;

	[SerializeField] int hpMax = 1;
	[SerializeField] int hp;


	public Tile.TileProperties canStandOn; 		// Tiles this unit can end a turn on, tiles considered valid to end a move on.

	// not using these for simplicity
	//public Tile.TileProperties canPassThrough;  // Tiles considered valid when moving.
	//public Tile.TileProperties canBePlacedOn;	// Valid tiles when placing this unit. 


	public bool hasMovedThisTurn = false;
	public bool hasCollectedEnergyThisTurn = false;
	public bool hasAttackedThisTurn = false;
	[SerializeField] int actionsPerTurn = 1;
	public int actionsRemaining;

	

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

	// Returns a list of tiles this unit can move to, if valid. Implementation varies based on type.
	public virtual List<Tile> GetMovementRange() {


		//TODO 
		return null;
	}

	// Could we move to this tile?
	public virtual bool GetValidMoveTarget(Tile tile) {
		//TODO 
		// all units will want to filter out tiles that already have units

		return false; 
	}

	// Returns a list of valid tiles this unit can move to. Used for displaying movement options.
	public virtual List<Tile> GetValidMovement() {

		List<Tile> tilesInRange = GetMovementRange();
		//check validity
		for(int i = 0; i < tilesInRange.Count; i++) {
			bool valid = GetValidMoveTarget(tilesInRange[i]);
			if(!valid) {
				tilesInRange.RemoveAt(i);
				i--;
			}
		}
		return tilesInRange;
	}


	// Could we attack the unit on this tile?
	public virtual bool GetValidAttackTarget(Tile tile) {
		//TODO 

		return false;
	}

	
}
