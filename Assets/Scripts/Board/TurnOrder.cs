using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOrder : MonoBehaviour
{

	/*
		Ordered list of units, in order that they will take their turns
	*/

	public List<Unit> units { get; private set; }

	int index = -1;

    // Start is called before the first frame update
    void Start()
    {
        index = -1;
    }

	public void Add() {

	}

	public void Remove() {

	}

	// Returns the next unit that should take its turn, and increments the counter. Returns null when the list is complete and resets the counter to 0
	//public Unit Next() {
		
	//}


}