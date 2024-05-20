using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTile : MonoBehaviour
{
	/*
		Visual representation of a tile object in the world.
	*/

	//positions for different parts/layers
	[SerializeField] GameObject land, unit, cloud; //smog;

	//public float heightOffset = 0;
	//public Vector3 rotation = Vector3.zero;
	//public bool clouds = false;

	public Tile tile;


    
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void UpdateUnit() {

	}

	public void UpdateSmog(float newSmog) {

	}

	

}
