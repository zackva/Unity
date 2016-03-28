﻿/*
    Nathan Cruz

    This is to hold the locations of all the buttons in tab in the category selector in the inentory screen in Unity in one location.

    Is Extended by:
    ConsumablesButton.cs
    EquipmentButton.cs
    KeyItemButton.cs
    AllButton.cs
    SigilButton.cs
*/
using UnityEngine;
using System.Collections;

public class ButtonLocations : MonoBehaviour {

    //Will change pending on ingame naming conventions chosen
    public string AllButtonLocation = "Inventory Screen/All Button";
    public string EquipmentButtonLocation = "Inventory Screen/Equipment Button";
    public string SigilButtonLocation = "Inventory Screen/Sigil Button";
    public string ConsumablesButtonLocation = "Inventory Screen/Consumables Button";
    public string KeyItemsButtonLocation = "Inventory Screen/Key Items Button";
}
