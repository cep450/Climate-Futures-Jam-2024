using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
	/*
		
	*/

	// Tiles a property can have. Can have multiple.
	// Other things might use this struct to filter for certain types of tiles.
	public struct TileProperties {
		public bool inland; 
		public bool water;
		public bool shoreline;
		public bool river;
		public bool lush;
		public bool geothermal;
	}

	public Vector2Int gridPosition;

	Unit unit = null;

	public float smog = 0f; 
	public float sunlight= 1f;


    
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
