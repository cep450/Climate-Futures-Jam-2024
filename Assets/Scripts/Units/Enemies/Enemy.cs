using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Unit
{

	/*
		Enemy unit that acts on its own.
	*/

	

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	// Could we attack the unit on this tile?
	public override bool GetValidAttackTarget(Tile tile) {
		//TODO 

		return false;
	}


}