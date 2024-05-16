using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGrid<T> : MonoBehaviour
{

	/*
		Grid of a generic type.
	*/

	public float tileSize;
	public int diameter;

	[SerializeField] T [][] grid;


    // Start is called before the first frame update
    void Start()
    {
        UpdatePositions();
    }


	[ContextMenu("Update Positions")]
    void UpdatePositions()
    {
        //TODO
		//for(int i = 0; i < tiles.)
		//loop through and update the position by multiplying the i,j by the world units space the tile will take up
		// and update the height as given by the tile 

		


    }

	// get adjacencies of a tile, returns null if off-grid (really default(T) which will usually be null)
	public T GetTile(Vector2Int pos, int offsetX, int offsetY) {
		return GetTile(pos.x, pos.y, offsetX, offsetY);
	}
	public T GetLeft(int x, int y) {
		return GetTile(x, y, -1, 0);
	}
	public T GetRight(int x, int y) {
		return GetTile(x, y, 1, 0);
	}
	public T GetForward(int x, int y) {
		return GetTile(x, y, 0, -1);
	}
	public T GetBehind(int x, int y) {
		return GetTile(x, y, 0, 1);
	}
	public T GetTile(int posX, int posY, int offsetX, int offsetY) {

		int x = posX + offsetX;
		int y = posY + offsetY;

		if(x < 0 || y < 0 || x >= grid[0].Length || y >= grid.Length) {
			return default(T);
		} else {
			return grid[x][y];
		}
	}

}
