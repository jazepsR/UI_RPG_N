using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health = 5;

    public void ReportHealth()
    {
        Debug.Log(name +" health: "+ health);
    }
}
