using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    void Start()
    {
        GameContainer<string> stringContainer = new GameContainer<string>();
        
        stringContainer.SetItem("Healing Potion");
        
        string storedItem = stringContainer.GetItem();
        Debug.Log($"Stored item: {storedItem}");
        
        string description = GameUtils.DescribeItem(storedItem);
        Debug.Log(description);
    }
}

