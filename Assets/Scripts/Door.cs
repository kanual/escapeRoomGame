using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour, Interactable{
    public string UnlockItem;

    private GameObject inventory_var;

    void Start()
    {
        inventory_var = GameObject.Find("inventory");
    }

    public void Interact(DisplayImage currentDisplay){
        if (inventory_var.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem){
                Debug.Log("unlock");
        }
    }
}
