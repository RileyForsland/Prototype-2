using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalinput;
    public foat speed = 10.0f;
    public float xrange = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
    

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }



        horizontalinput = Input.GetAxis("horizontal");
        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);

    }
}
