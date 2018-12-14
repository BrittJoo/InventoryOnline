using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubes : Items {

    public override GameObject IHaveItem(GameObject currentItem)
    {
        print("cube override");
        currentItem = this.gameObject;
        print(" cube override" + currentItem);
        return currentItem;
    }
}
