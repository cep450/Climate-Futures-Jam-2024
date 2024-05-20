using System.Collections;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class Tile : MonoBehaviour
{
	/*
		
	*/

	// Tiles a property can have. Can have multiple.
	// Other things might use this struct to filter for certain types of tiles.
	[System.Serializable]
	public struct TileProperties {
		public bool impassable;

		//public bool inland; 
		//public bool shoreline;
		//public bool river;
		//public bool lush;
		//public bool geothermal;

		public bool ContainsAny(TileProperties filter) {
			if(filter.impassable == this.impassable) return true;
			//ect 
			
			return false;
		}
	}

	public Board board; // store a reference to the board we're on

	public TileProperties properties;

	public Vector2Int gridPosition;

	//public float smog = 0f; 
	public float sunlight= 1f;

	public Unit unit;

	// Use the grid to get different components that correspond to this tile
	public bool GetCloudCover() {
		return board.clouds.GetTile(gridPosition).activeSelf;
	}
	
	


    
	// Start is called before the first frame update
    void Start()
    {
        unit = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
