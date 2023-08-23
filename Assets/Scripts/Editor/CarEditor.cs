using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(Car))]
public class CarEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        Car myTarget = (Car)target;
        myTarget.carPrefab = (GameObject)EditorGUILayout.ObjectField(myTarget.carPrefab, typeof(GameObject), true);
        myTarget.speed = EditorGUILayout.FloatField("Minha velocidade", myTarget.speed);
        myTarget.gear = EditorGUILayout.IntField("Minha velocidade", myTarget.gear);

        EditorGUILayout.LabelField("Velocidade Total", myTarget.totalSpeed.ToString());



        if(GUILayout.Button("Create Car"))
        {
            myTarget.CreateCar();
        }
    }


}
