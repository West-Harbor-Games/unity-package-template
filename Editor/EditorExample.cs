using UnityEditor;

namespace WHG.Template.Editor
{
    /// <summary>
    /// This is an example script for starting an editor inspector.
    /// </summary>
    /// <seealso cref="RuntimeExample"/>
    [CustomEditor(typeof(RuntimeExample))]
    public class EditorExample : UnityEditor.Editor
    {
        /// <summary>
        /// An example of a member variable, used to display in the inspector.
        /// </summary>
        SerializedProperty exampleField;

        /// <summary>
        /// OnEnable is called on the frame when a script is displayed in the
        /// inspector just before OnInspectorGUI is called the first time.
        /// </summary>
        public void OnEnable()
        {
            exampleField = serializedObject.FindProperty("exampleField");
        }

        /// <summary>
        /// OnInspectorGUI is called every frame, if this script is displayed
        /// in the inspector.
        /// </summary>
        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(exampleField, true);
            serializedObject.ApplyModifiedProperties();
        }
    }
}