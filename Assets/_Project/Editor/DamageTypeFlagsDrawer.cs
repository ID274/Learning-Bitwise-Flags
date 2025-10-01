using UnityEditor;
using UnityEngine;

/// <summary>
/// This class was generated using ChatGPT while debugging.
/// It serves to serialize the DamageType enum as a checklist rather than a regular dropdown, allowing multiple flags to be checked at once in the inspector.
/// </summary>

[CustomPropertyDrawer(typeof(DamageType))]
public class DamageTypeFlagsDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        // Draw the label
        label = EditorGUI.BeginProperty(position, label, property);

        // Draw the enum as a mask field (flags)
        property.intValue = EditorGUI.MaskField(position, label, property.intValue, property.enumNames);

        EditorGUI.EndProperty();
    }
}