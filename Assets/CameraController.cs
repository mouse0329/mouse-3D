using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject player;
    public mouse mouse;
    private void Start()
    {
      //  pastPos = player.transform.position;
    }
    void Update()
    {

    //   currentPos = player.transform.position;

     //   diff = currentPos - pastPos;

   //     transform.position = Vector3.Lerp(transform.position, transform.position + diff, 1.0f);

    //    pastPos = currentPos;

        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");

        if (Mathf.Abs(mx) > 0.01f)
        {
            transform.RotateAround(transform.position, Vector3.up, mx);
        }
        if (Mathf.Abs(my) > 0.01f)
        {
            transform.RotateAround(player.transform.position, -my);
        }
    }
}
