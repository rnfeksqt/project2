using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(this.name + "이" + other.gameObject.name + "에 콜리전됨");
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(this.name + "이" + other.gameObject.name + "에 부딪힘");
    }
}
