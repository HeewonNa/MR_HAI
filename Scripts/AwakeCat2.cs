using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AwakeCat2 : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("test1");

    }
    IEnumerator test1()
    {
        anim.SetBool("isSleep", false);
        yield return new WaitForSeconds(1.3f);
        anim.SetBool("isAwake", false);




    }
}
