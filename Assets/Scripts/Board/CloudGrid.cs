using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGrid : MonoBehaviour
{

	/*
		Clouds move and extend off the board so the player can see what cloudcover is coming.
		Clouds use noise for generation and use the turn number + (level number * 100) for their 0,0.
		Size is size of the board + margin
		The transform of this object will be used to position the clouds e.g. if we want them to be offset from the grid for shadows to fall on the grid properly
	*/

	[SerializeField] int margin = 3;

	[SerializeField] Grid<GameObject> clouds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


	//Initial generation when a map is loaded 
	public void Generate() {

	}

}
