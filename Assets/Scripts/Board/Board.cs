using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

	/*
		The collection of tiles that make up the whole game board.
	*/

	[SerializeField] WorldGrid<Tile> tiles;
	[SerializeField] CloudGrid clouds;

	// Ordered lists of player and enemy units, in order that they will take their turns 
	public List<Ally> playerUnits { get; private set; }
	public List<Enemy> enemyUnits { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
