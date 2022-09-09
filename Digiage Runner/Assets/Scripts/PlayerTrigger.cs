using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTrigger : MonoBehaviour
{
    [SerializeField] Image fillEnergy;
    [SerializeField] float fillAmount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "collectableClothes")
        {
            CollectClothes(other.gameObject);
            HideCollactable(other.gameObject);
        }
        else if(other.tag == "collectableFruits")
        {
            CollectFruits(fillAmount);
            HideCollactable(other.gameObject);
        }
    }

    void CollectClothes(GameObject UIToBeEnabled)
    {
        UIToBeEnabled.GetComponent<Collectable>().EnableClothesUI();
    }
    void CollectFruits(float amount)
    {
        fillEnergy.fillAmount += amount;
    }


    void HideCollactable(GameObject other)
    {
        other.tag = "Untagged";
        other.gameObject.SetActive(false);
    }

}