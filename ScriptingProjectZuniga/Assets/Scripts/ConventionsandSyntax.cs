using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsandSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line is there to tell me the X psoition of my object

        /*Hi there!
         *  */
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}
