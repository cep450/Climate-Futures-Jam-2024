using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : Unit
{

	/*
		Unit a player can control.
	*/

	

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


	// Calculate energy this unit produces this turn based on the current conditions
	// Different types of units will implement this differently e.g. solar factoring in time of day and cloud cover and smog 
	public virtual void CalculateEnergyProduced() {

	}


}