﻿using UnityEngine;
using System.Collections;

public class AllButton : ButtonLocations {

    public void RiseToTop()
    {
        GameObject.Find(AllButtonLocation).transform.SetSiblingIndex(4);
        GameObject.Find(EquipmentButtonLocation).transform.SetSiblingIndex(3);
        GameObject.Find(SigilButtonLocation).transform.SetSiblingIndex(2);
        GameObject.Find(ConsumablesButtonLocation).transform.SetSiblingIndex(1);
        GameObject.Find(KeyItemsButtonLocation).transform.SetSiblingIndex(0);
    }
}
