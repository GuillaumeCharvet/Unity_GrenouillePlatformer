using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Grenouille : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rgbd;
    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private float jump_power = 1f;
    [SerializeField]
    private float speed_rotation = 10f;    

    void Update()
    {
        var input_rotation = Input.GetAxis("Horizontal");
        if (Input.GetAxis("Vertical") > 0)
        {
            Debug.Log(transform.rotation * Vector3.forward * speed);
            rgbd.AddForce(transform.rotation * Vector3.forward * speed);
            //transform.localPosition += transform.rotation * Vector3.forward * speed;
        }
        if (input_rotation != 0)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, input_rotation * speed_rotation, 0));
        }
        if (Input.GetKeyDown("space"))
        {
            rgbd.AddForce(transform.rotation * (new Vector3(0, 1, 1)) * jump_power);
            //transform.localPosition += transform.rotation * (new Vector3(0, 1, 1)) * speed;
        }
    }
}
