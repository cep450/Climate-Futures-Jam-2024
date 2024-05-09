using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

	public bool awaitsPlayerInput = false;


	public Tile.TileProperties canBePlacedOn;	// Valid tiles when placing this unit.
	public Tile.TileProperties canStandOn; 		// Tiles this unit can end a turn on, tiles considered valid to end a move on.
	public Tile.TileProperties canPassThrough;  // Tiles considered valid when moving.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    // What this unit will do every turn.
	public void AutomousTurn() {

	}

	// Present the player with options about this unit.
	public void AwaitPlayerInput() {

	}
}
