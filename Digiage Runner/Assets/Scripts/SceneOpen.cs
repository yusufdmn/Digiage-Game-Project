using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneOpen : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DisableBlackScreen());
    }
    IEnumerator DisableBlackScreen()
    {
        yield return new WaitForSeconds(1.55f);
        gameObject.SetActive(false);

    }
}