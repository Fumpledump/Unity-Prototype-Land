using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public static class HierarchyItemColor
{
    static HierarchyItemColor()
    {
        EditorApplication.hierarchyWindowItemOnGUI += HierarchyWindowItemOnGUI;
    }

    static void HierarchyWindowItemOnGUI(int instanceID, Rect selectRect)
    {
        var gameObject = EditorUtility.InstanceIDToObject(instanceID) as GameObject;
        if (gameObject != null && gameObject.name.StartsWith("/", System.StringComparison.Ordinal))
        {
            EditorGUI.DrawRect(selectRect, Color.gray);
            EditorGUI.DropShadowLabel(selectRect, gameObject.name.Replace("/", "").ToUpperInvariant());
        }
    }
}
