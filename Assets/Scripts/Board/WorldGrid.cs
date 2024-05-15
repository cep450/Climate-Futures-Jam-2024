using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGrid : MonoBehaviour
{

	/*
		Display visual representations of the internal representation-- the 'view' of the MVC 
	*/

	public float tileSize;
	public int diameter;

	public Grid<Tile> tiles;

    // Start is called before the first frame update
    void Start()
    {
        UpdateTilePositions();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	[ContextMenu("Update Tile Positions")]
    void UpdateTilePositions()
    {
        //TODO
		//for(int i = 0; i < tiles.)
		//loop through and update the position by multiplying the i,j by the world units space the tile will take up
		// and update the height as given by the tile 

		//TODO we'll want something similar for clouds. should this function go in the Grid class?
		//UpdateCloudPositions
		//and put this in Start() as well
    }

}
