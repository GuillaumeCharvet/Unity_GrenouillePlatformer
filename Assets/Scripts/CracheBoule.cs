using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CracheBoule : MonoBehaviour
{
    [SerializeField]
    GameObject crachat;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(crachat, transform.position, Quaternion.identity);
        }
    }
}
