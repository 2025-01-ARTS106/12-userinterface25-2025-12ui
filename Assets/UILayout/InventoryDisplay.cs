using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public void ShowOnly(int itemType)
    {
        for (int i = 0; i < transform.childCount; i++)
	    {
           InventoryItemButton thisitem = transform.GetChild(i).GetComponent<InventoryItemButton>();
            thisitem.gameObject.SetActive(thisitem.index == itemType);
        }
    }
    public void showAll()
    {
        for (int i= 0; i< transform.childCount; i++)
        {
            InventoryItemButton thisitem= transform.GetChild(i).GetComponent<InventoryDisplay>();
            thisitem.gameobject.SetActive(true);
        }




    }
        





}

