using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIManager : MonoBehaviour
{
    private Animator anim;

    [SerializeField]
    private GameObject[] objects;
    [SerializeField]
    private Transform rightHandPoint, leftHandPoint;

    private int objectsNumber;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("targetPlace"))
        {
            int rand = Random.Range(0, 2);  
            switch (rand)
            {
                case 0:
                    anim.SetTrigger("throwRight");
                    GameObject newObject = Instantiate(objects[objectsNumber], rightHandPoint.transform.position, transform.rotation);
                    newObject.GetComponent<Rigidbody>().AddForce(new Vector3(50, 200, 100));

                    break;
                case 1:
                    anim.SetTrigger("throwLeft");
                    newObject = Instantiate(objects[objectsNumber], leftHandPoint.transform.position, transform.rotation);
                    newObject.GetComponent<Rigidbody>().AddForce(new Vector3(-50,200,100));
                    break;

            }

        }
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * 0.01f);
    }


}
