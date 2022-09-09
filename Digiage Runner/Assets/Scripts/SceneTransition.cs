using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    [SerializeField] Animator closeAnimator;
    [SerializeField] GameObject blackScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "door")
            Finished();
    }

    private void Finished()
    {
        blackScreen.SetActive(true);
        //closeAnimator.SetTrigger("close");
        StartCoroutine(CloseScene());
    }
    IEnumerator CloseScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
}