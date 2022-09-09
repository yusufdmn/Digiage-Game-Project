using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyController : MonoBehaviour
{
    public Image fill;
    public float decreaseAmount;
    float timeLimit;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DecreaseEnergy", 0, 2); 
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void DecreaseEnergy()
    {
        fill.fillAmount -= decreaseAmount;
    }
}
