#if UNITY_EDITOR_WIN
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(DashScript))]
public class DashScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Call normal GUI (displaying "a" and any other variables you might have)
        base.OnInspectorGUI();

        // Reference the variables in the script
        DashScript script = (DashScript)target;

        EditorGUILayout.BeginHorizontal();
        if (script.tipo == DashScript.Hola.adios)
        {
            // Ensure the label and the value are on the same line

            // A label that says "b" (change b to B if you want it uppercase like default) and restricts its length.
            EditorGUILayout.LabelField("Acc", GUILayout.MaxWidth(100));
            // You can change 50 to any other value

            // Show and save the value of b
            script.acc = (GameObject)EditorGUILayout.ObjectField(script.acc, typeof(GameObject), true);
            // If you would like to restrict the length of the int field, replace the above line with this one:
            // script.b = EditorGUILayout.IntField(script.b, GUILayout.MaxWidth(50)); // (or any other value other than 50)

        }
        else if (script.tipo == DashScript.Hola.aaa)
        {
            // Ensure the label and the value are on the same lin

            // A label that says "b" (change b to B if you want it uppercase like default) and restricts its length.
            EditorGUILayout.LabelField("DEFAULT", GUILayout.MaxWidth(50));
            // You can change 50 to any other value

            // Show and save the value of b
            // If you would like to restrict the length of the int field, replace the above line with this one:
            // script.b = EditorGUILayout.IntField(script.b, GUILayout.MaxWidth(50)); // (or any other value other than 50)

        }
        EditorGUILayout.EndHorizontal();
        serializedObject.ApplyModifiedProperties();
    }
}
#endif
