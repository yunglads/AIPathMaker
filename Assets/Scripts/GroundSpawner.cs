using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public Transform ground;
    [Tooltip("Amount of ground tiles in the x axis (i.e 10 = 10 ground tiles long)")]
    public int xDistance = 25;
    [Tooltip("Amount of ground tiles in the z axis (i.e 10 = 10 ground tiles long)")]
    public int zDistance = 25;

    void Start()
    {
        for (int i = 0; i < xDistance; i++)
        {
            for (int j = 0; j < zDistance; j++)
            {
                Instantiate(ground, new Vector3(i, 0, j), Quaternion.identity, transform);
            }
        }
    }
}
