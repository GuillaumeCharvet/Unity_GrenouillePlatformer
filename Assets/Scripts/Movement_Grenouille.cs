using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Grenouille : MonoBehaviour
{
    [SerializeField]
    private float speed = 1f;
    [SerializeField]
    private float speed_rotation = 10f;    

    void Update()
    {
        var input_rotation = Input.GetAxis("Horizontal");
        if (Input.GetAxis("Vertical") > 0)
        {
            transform.localPosition += new Vector3(0, 0, 1) transform.localRotation.eulerAngles * speed * Time.deltaTime;//Quaternion.EulerAngles (new Vector3(0, 0, 1) * speed * Time.deltaTime);
        }
        if (input_rotation != 0)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, input_rotation * speed_rotation, 0));
        }
    }
}
