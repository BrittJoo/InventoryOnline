using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    //OUDE IETEMS SCRIPT
    public GameObject currentItem;
    private bool canHit;

    private Items items;
    private Inventory inventorySC;
    RaycastHit hit;
    public bool hitItemSC;

    public GameObject[] invSlots;
    public GameObject[] currentInventory;

    public GameObject inventoryIMG;
    bool disabledIMG = true;
    bool placeItemin;

    private void Start()
    {
        items = FindObjectOfType<Items>();
    }


    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.I))
        {
            disabledIMG = !disabledIMG;
        }

        if (Input.GetMouseButtonDown(0))
        {
            canHit = true;
            WhichItem();
            print(currentItem);
        }
        if (disabledIMG)
        {
            inventoryIMG.SetActive(false);
        }
        if (!disabledIMG)
        {
            inventoryIMG.SetActive(true);
        }
    }

    public void LookForSpace()
    {
        for (var i = 0; i < currentInventory.Length; i++)
        {
            if (currentInventory[i] == null)
            {
                currentInventory[i] = currentItem;
                invSlots[i].GetComponent<RawImage>().enabled = true;
                invSlots[i].GetComponent<RawImage>().texture = currentItem.GetComponent<RawImage>().texture;
                break;
            }
        }
    }

    public void WhichItem()
    {
        if (canHit)
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 50.0f))
            {
                Debug.DrawRay(transform.position, transform.forward, Color.red, 50.0f);
                if (hit.collider.GetComponent<Items>())
                {
                    items.IHaveItem(currentItem);
                    currentItem = hit.transform.gameObject; 
                    LookForSpace();
                    hitItemSC = true;
                    canHit = false;
                    //Destroy(hit.transform.gameObject); null reference
                }
            }
        }
    }

    IEnumerator WaitASec(int waitTime)
    {
        yield return new WaitForSeconds(waitTime);
    }
}






