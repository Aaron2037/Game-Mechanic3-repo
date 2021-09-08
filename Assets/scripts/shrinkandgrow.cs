using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shrinkandgrow : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider2D circleCol;
    void Start()
    {

    }

    // Update is called once per frame
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