using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{

        public virtual GameObject IHaveItem(GameObject currentItem)
    {
        print("base class enter");
        return currentItem;
    }
}
