using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTrigger : MonoBehaviour
{
    [SerializeField] Image fillEnergy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "collectable")
        {
            Collect(other.gameObject, 0.2f);
        }
        else if (other.tag == "superCollectable")
            Collect(other.gameObject, 1f);
    }

    void Collect(GameObject UIToBeEnabled, float fillAmount)
    {
        UIToBeEnabled.GetComponent<Collectable>().EnableClothesUI();
        fillEnergy.fillAmount += fillAmount;
    }


}