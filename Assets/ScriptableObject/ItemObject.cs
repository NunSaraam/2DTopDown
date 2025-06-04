using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    [SerializeField] ItemSO Data;

    public int GetPoint()
    {
        return Data.point;
    }
}
