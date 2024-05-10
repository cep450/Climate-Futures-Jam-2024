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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


	// Do the thing 
	public virtual void PerformAction() {

	}


}