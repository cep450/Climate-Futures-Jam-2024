using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{

	/*
		An action a unit can take.
		Units can have these. 
		They cost energy to perform.
	*/

	public int energyRequired = 1;


	// Do the thing 
	public virtual void PerformAction() {

	}


}