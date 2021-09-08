using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shrinkandgrow : MonoBehaviour
{
    public Collider2D circleCol;
    void Start()
    {

    }
    //when the keys are pressed, the circle will either shrink or grow, pressing space brings it to the normal size
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            circleCol.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            circleCol.transform.localScale = new Vector3(2f, 2f, 2f);
            gameObject.transform.localScale = new Vector3(2f, 2f, 2f);
        }


        if (Input.GetKey(KeyCode.Space))
        {
            circleCol.transform.localScale = new Vector3(1, 1, 1);
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}