using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderColliderScript : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
