using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTile : MonoBehaviour
{
	/*
		Visual representation of a tile object.
	*/

	//positions for different parts/layers
	[SerializeField] GameObject land, unit, smog, cloud;

	public float heightOffset = 0;


    
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
