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
        if (other.tag == "collectable")
        {
            Collect(other.gameObject, fillAmount);
            HideCollactable(other.gameObject);
        }
     //   else if (other.tag == "superCollectable")
      //      Collect(other.gameObject, fillAmount);
    }

    void Collect(GameObject UIToBeEnabled, float amount)
    {
        UIToBeEnabled.GetComponent<Collectable>().EnableClothesUI();
        fillEnergy.fillAmount += amount;
    }
    void HideCollactable(GameObject other)
    {
        other.tag = "Untagged";
        other.gameObject.SetActive(false);
    }

}