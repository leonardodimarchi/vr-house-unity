using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public void Move(Transform obj) 
    {
        transform.position = new Vector3(obj.position.x, transform.position.y, obj.position.z);
    }
}
