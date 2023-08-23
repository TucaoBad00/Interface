using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public GameObject carPrefab;
    public float speed;
    public int gear;
    public float totalSpeed
    {
        get { return speed * gear; }
    }
    
    public void CreateCar()
    {
        var a = Instantiate(carPrefab);
        a.transform.position = Vector3.zero;
    }
}
