﻿/*
    Nathan Cruz

    Keeps a list on enemies in the zone.

    Interface:
    void LoadEnemies(List<GameObject> savedEnemies) - loading a new a session, destroys enemies in the list from the zone, according to the list of enemies inputted (from a save file per say to preserve the previous game state).
    List<GameObject> SaveEnemies() - saves the current session's enemies (save file)

    Load Order:
    EnemyManager.cs loads before the script that handles the loading from a save file.

    Rememeber to:
    Reference all Enemy game object here.
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour {

    public List<GameObject> enemies = new List<GameObject>();
    
	//For Loading the game
	public void LoadEnemies(List<int> savedEnemies)
	{
		for(int i = 0; i < enemies.Count; i++)
		{
			if(savedEnemies[i] == 0)
			{
				Destroy(enemies[i].gameObject);
			}
		}
	}

	//For Saving the game
	public List<int> SaveEnemies()
	{
		List<int> x = new List<int>();
		for(int i = 0; i < enemies.Count; i++)
		{
			if(enemies[i] != null)
			{
				x.Add (1);
			}
			else
			{
				x.Add (0);
			}
		}
		return x;
	}
}
