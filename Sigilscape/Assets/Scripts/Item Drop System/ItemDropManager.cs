﻿/*
    Nathan Cruz

    Keeps a list of the item drops in the zone.
    Note: whether an item has been dropped or not on the ground is dependent on whether the itemdrop has a parent or not.

    Interface:
    void LoadItemDrops(List<GameObject> savedItemDrops) - loading a new a session, destroys itemdrops in the list from the zone, according to the list inputted (from a save file per say to preserve the previous game state).
    List<GameObject> SaveItemDrops() - saves the current session's itemdrops (save file)

    Rememeber to:
    Reference all itemDrop game object here.

    Load Order:
    EnemyManager.cs loads before the script that handles the loading from a save file.
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDropManager : MonoBehaviour {

    public List<GameObject> itemDrops = new List<GameObject>();

	//For Loading the game
	public void LoadItemDrops(List<int> savedItemDrops)
	{
		for (int i = 0; i < savedItemDrops.Count; i++)
		{
			if (savedItemDrops[i] != 0)
			{
				itemDrops[i].SetActive(true);
				//Destroy(itemDrops[i].gameObject);
			}
			else
			{
				Destroy(itemDrops[i].gameObject);
			}
		}
	}

	//For Saving the game
	public List<int> SaveItemDrops()
	{
		List<int> x = new List<int> ();

		for (int i = 0; i < itemDrops.Count; i++)
		{
			if (itemDrops [i] != null)
				x.Add (1);
			else
				x.Add (0);

			//			else if(savedItemDrops[i].transform.parent == null)
			//			{
			//				itemDrops[i].SetActive(true);
			//			}
		}

		return x;
	}
}
