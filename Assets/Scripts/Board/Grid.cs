using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Grid<T> : MonoBehaviour
{

	// 2d array plus helper functions wrapper 

	[SerializeField] T [][] grid;

}