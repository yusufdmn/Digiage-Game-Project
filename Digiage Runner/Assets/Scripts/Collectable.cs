using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public GameObject clothesUI;
    
    public void EnableClothesUI()
    {
        clothesUI.SetActive(true);
    }

}
