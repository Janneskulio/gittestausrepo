using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float t;
    bool goLeft, goRight;

    // Start is called before the first frame update
    void Start()
    {
        t = 0;
        goLeft = true;
        goRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (goLeft == true) {
            transform.position = Vector3.Lerp(new Vector3(10,-2), new Vector3(-10,-2), t/5);
            transform.rotation = Quaternion.Euler(0,0,270f);
            if (transform.position.x <= -10) {
                goLeft = false;
                goRight = true;
                t = 0;
            }
        }
        else if (goRight == true) {
            transform.position = Vector3.Lerp(new Vector3(-10,-2), new Vector3(10,-2), t/5);
            transform.rotation = Quaternion.Euler(0,0,90f);
            if (transform.position.x >= 10) {
                goRight = false;
                goLeft = true;
                t = 0;
            }
        }
        t += Time.deltaTime;
    }
}
