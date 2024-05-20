using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOfDay : ScriptableObject
{
	/*

	*/

	// gameplay effects 

	[SerializeField] public float sunlightPercent; //for solar


	// visual effects

	//TODO colors or whatever needed for visual effects 
	[SerializeField] Vector3 sunAngle = Vector3.zero;


}
