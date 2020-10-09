using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Inventory : MonoBehaviour
{
    public Sprite logo;
    public int columns = 7;
    public GameObject inventoryGrid;
    public GameObject slot;
    public List<GameObject> inventory;
    private GameObject newItem;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
	    {
            newItem = Instantiate(slot, inventoryGrid.transform);
            inventory.Add(newItem);
            checkSlots();

        }   
    }

     void checkSlots ()
    {
        
    }
}
