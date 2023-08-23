using UnityEngine;
using UnityEditor;

public class CreateGameObject : Editor
{
    [MenuItem("Tools/Create GameObject")]
    public static void CreateGameobject()
    {
        GameObject newObject = new GameObject("New GameObject");
        if (Selection.activeTransform != null)
        {
            newObject.transform.SetParent(Selection.activeTransform, false);
        }
        Selection.activeObject = newObject;
    }
}
