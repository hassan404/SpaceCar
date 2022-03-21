using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarPlatformer : MonoBehaviour
{
    public float m_MaxDistance = 1f;
    public bool m_HitDetect;

    public Rigidbody rb;
    public Collider m_Collider;
    public ArcadeKart kart;
    RaycastHit m_Hit;

    public ArcadeKart.StatPowerup boostStats = new ArcadeKart.StatPowerup
    {
        modifiers = new ArcadeKart.Stats
        {
            //AddedGravity = -2f,
            Acceleration = 1f
        },
        MaxTime = 0.01f
    };

    private void OnValidate()
    {
        //Choose the distance the Box can reach to
        m_Collider = GetComponentInChildren<Collider>();
        rb = GetComponentInChildren<Rigidbody>();
        kart = GetComponent<ArcadeKart>();

    }

    void FixedUpdate()
    {
        //Test to see if there is a hit using a BoxCast
        //Calculate using the center of the GameObject's Collider(could also just use the GameObject's position),
        //half the GameObject's size, the direction, the GameObject's rotation, and the maximum distance as variables.
        //Also fetch the hit data
        m_HitDetect = Physics.BoxCast(m_Collider.bounds.center + m_Collider.bounds.extents.y * Vector3.up,
            transform.localScale, -transform.up, out m_Hit, transform.rotation, m_MaxDistance);
        if (m_HitDetect)
        {
            Platform pt = m_Hit.collider.gameObject.GetComponent<Platform>();
            if (pt)
            {
                kart.AddPowerup(boostStats);
                Debug.Log("Hit : " + m_Hit.collider.name + ", Added force: " + pt.force.ToString());
            }

        }
    }


    //Draw the BoxCast as a gizmo to show where it currently is testing. Click the Gizmos button to see this
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        //Check if there has been a hit yet
        if (m_HitDetect)
        {
            //Draw a Ray forward from GameObject toward the hit
            Gizmos.DrawRay(transform.position, -transform.up * m_Hit.distance);
            //Draw a cube that extends to where the hit exists
            Gizmos.DrawWireCube(transform.position + -transform.up * m_Hit.distance, transform.localScale);
        }
        //If there hasn't been a hit yet, draw the ray at the maximum distance
        else
        {
            //Draw a Ray forward from GameObject toward the maximum distance
            Gizmos.DrawRay(transform.position, -transform.up * m_MaxDistance);
            //Draw a cube at the maximum distance
            Gizmos.DrawWireCube(transform.position + -transform.up * m_MaxDistance, transform.localScale);
        }
    }
}
