using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOrder<UnitType> : MonoBehaviour where UnitType : Unit
{

	/*
		Ordered list of units, in order that they will take their turns
	*/

	public List<UnitType> units { get; private set; }

	int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
    }

	public void Add(UnitType unit) {
		units.Add(unit);
	}

	public void Remove(UnitType unit) {
		units.Remove(unit);
	}

	public UnitType GetCurrent() {
		return units[index];
	}

	// Increment the index to the next in the list. Returns true if there is more in the list, false if this is the end of the list and we've looped back to the start.
	public bool Next() {
		index++; 
		if(index >= units.Count) {
			index = 0; 
			return false;
		}
		return true;
	}

}