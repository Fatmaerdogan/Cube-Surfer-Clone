using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Events.GameFinish?.Invoke();
        }
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Events.GameFinish?.Invoke();
        }
    }
}
