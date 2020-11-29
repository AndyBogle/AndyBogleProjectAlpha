using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatGround : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatGWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatGWidth = GetComponent<BoxCollider>().size.x * 26;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i >= 5; i++)
        {
            if(i >= 5 && transform.position.x > startPos.x - repeatGWidth)
            {
                //transform.position = startPos;
                startPos.x = + 5;
            }
        }

        if (transform.position.x < startPos.x - repeatGWidth)
        {
            transform.position = startPos;
        }
        
    }
}
