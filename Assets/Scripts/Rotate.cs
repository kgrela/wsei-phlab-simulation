using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    Vector3 m_EulerAngleVelocity;

    public float speed = 100f;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_EulerAngleVelocity = new Vector3(0, speed, 0);
    }

    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
    }
}