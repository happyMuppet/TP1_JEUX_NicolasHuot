using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MoveForward : MonoBehaviour
{

    public float speed = 15.0f;
    public float maxBound = 15.0f;
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {

         
        if (transform.position.x < -maxBound)
        {
            transform.Rotate(new Vector3(0, 180, 0));

        } 
        else if (transform.position.x > maxBound)
        {     
            transform.Rotate(new Vector3(0, 180, 0));
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        /* (transform.position.x < -maxBound)
        {
            transform.Rotate(new Vector3(0, 180, 0));
        }

        if (transform.position.x < maxBound)
        {
            transform.Rotate(new Vector3(0, 180, 0));
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);*/
    }
}
