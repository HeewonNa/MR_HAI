using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector3 target;
    public GameObject ball;
    int a = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = new Vector3(0.056f, -0.177f, 3.096f);
    }


    // Update is called once per frame
    void Update()
    {
     //  if( a ==0) throwball();
     //  if (Input.GetKey(KeyCode.W)) ball.SetActive(false);
    }

    public void throwball()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 0.02f);

        transform.Rotate(1, 1, 0);
        //if(transform.position ==target) a = 1;

    }
}
