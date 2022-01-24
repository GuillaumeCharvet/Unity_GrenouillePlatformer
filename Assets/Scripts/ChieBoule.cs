using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChieBoule : MonoBehaviour
{
    [SerializeField]
    GameObject chiure;
    [SerializeField]
    Transform parent_chiure;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(chiure, transform.position, Quaternion.identity, parent_chiure);
        }
    }
}
