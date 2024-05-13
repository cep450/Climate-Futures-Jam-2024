using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITurnTaker
{

	// Something that can take a turn, begin a turn, end a turn, ect. 
	// These will be called by the TurnManager which manages the turn order and order of execution.

    public void BeginTurn();
	public void EndTurn();
}
