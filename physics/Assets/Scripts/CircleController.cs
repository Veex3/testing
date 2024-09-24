using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    //holds rigidbody
    private Rigidbody2D rb;

    public float ballSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //assigns rigidbody
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // :3
        Debug.Log("ouchie :(");
        //Destroy(gameObject);

    }
}
