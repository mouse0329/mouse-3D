using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public float aa;
    float r = 0;
    public int k = 0;
    public int p;
    public Rigidbody rb;
    public int a;
    public int s =7;
    int j=1;
   // public GameObject j = GameObject.Find("aaa");

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }


    void Update()
    {
        aa = transform.position.y;
        Debug.Log(a);
        if(aa == a) { } else { aa = a; }
        float mx = Input.GetAxis("Mouse X");
        Debug.Log(j);


        if (Mathf.Abs(mx) > 0.01f)
        {
            transform.RotateAround(transform.position, Vector3.up, mx);
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * s * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += (transform.forward * (-1 * s) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            r = 0;
            r -= 2f;
            k -= 2;
            Rr();
        }
        if (Input.GetKey(KeyCode.D))
        {
            r = 0;
            r += 2f;
            k += 2;
            Rr();
        }
        if (Input.GetKey(KeyCode.Z))
        {
            s = 10;
        }
        else
        {
            s = 7;
        }
          if (Input.GetKey(KeyCode.Space) && j==1)
         {
             rb.AddForce(0,300f,0);
            j = 0;
         }
    }
    private void Rr()
    {
        float mx = Input.GetAxis("Mouse X")+r;
        transform.RotateAround(transform.position, Vector3.up, mx);
        Debug.Log(k);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("a"))
        {
            transform.position = new Vector3(5f,5f,5f);
        }
        if (collision.gameObject.CompareTag("d"))
        {
            transform.position = new Vector3(-1123.75f, 3f, 255.72f);
        }
        if (collision.gameObject.CompareTag("j"))
        {
            j = 1;
        }
    }

    private void OnCollisionExit(Collision collision) 
    {
        if (collision.gameObject.CompareTag("j"))
        {
            j = 0;
        }
    }
}
