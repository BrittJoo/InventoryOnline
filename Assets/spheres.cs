using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spheres : Items {

    public override GameObject IHaveItem(GameObject currentItem)
    {
        print(" sphere override");
        currentItem = this.gameObject;
        print(" cube override" + currentItem);
        return currentItem;
    }
}
