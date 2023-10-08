using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRaycastController : MonoBehaviour
{
    private Vector3 direction = Vector3.back;
    private bool isStack = false;
    private RaycastHit hit;

    void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, direction, out hit, 1f))
        {
            if (!isStack)
            {
                isStack = !isStack;
                Events.BlockIncreased?.Invoke(gameObject);
                SetDirection();
            }

            if (hit.transform.name == "Obstacle")
            {
                Events.BlockDecreased?.Invoke(gameObject);
            }
        }
    }


    private void SetDirection()
    {
        direction = Vector3.forward;
    }
}
