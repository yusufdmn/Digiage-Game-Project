using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIManager : MonoBehaviour
{
    private Animator anim;

    [SerializeField]
    private GameObject[] objects, targets;
    [SerializeField]
    private Transform rightHandPoint, leftHandPoint;


    private int number;
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
                    GameObject newObject = Instantiate(objects[number], rightHandPoint.transform.position, transform.rotation);
                    newObject.GetComponent<Rigidbody>().AddForce(new Vector3(50, 200, 100));

                    break;
                case 1:
                    anim.SetTrigger("throwLeft");
                    newObject = Instantiate(objects[number], leftHandPoint.transform.position, transform.rotation);
                    newObject.GetComponent<Rigidbody>().AddForce(new Vector3(-50,200,100));
                    break;
            }
            ++number;
        }

    }
    private void Update()
    {
        if (number < targets.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(targets[number].transform.position.x, 0.55f, targets[number].transform.position.z), 0.05f);
            transform.rotation = Quaternion.Euler(0, targets[number-1].gameObject.transform.rotation.eulerAngles.y, 0);
        }
    }

}
