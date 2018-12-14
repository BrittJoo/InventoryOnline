using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class capsules : Items {

    public override GameObject IHaveItem(GameObject currentItem)
    {
        print("capsule override");
        currentItem = this.gameObject;
        print(" capsule override" + currentItem);
        return currentItem;
    }
}
