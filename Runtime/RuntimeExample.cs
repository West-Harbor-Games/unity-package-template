using UnityEngine;

namespace WHG.Template
{
    /// <summary>
    /// This is an example script for starting a package.
    /// </summary>
    /// <seealso cref="Editor.EditorExample"/>
    public class RuntimeExample : MonoBehaviour
    {
        /// <summary>
        /// An example of a member variable, visible on the inspector.
        /// </summary>
        [SerializeField]
        [Tooltip("This is an example of a tooltip")]
        int exampleField = 0;

        /// <summary>
        /// Start is called on the frame when a script is enabled just before
        /// any of the Update methods is called the first time.
        /// </summary>
        void Start()
        {
        }

        /// <summary>
        /// Update is called every frame, if the MonoBehaviour is enabled.
        /// </summary>
        void Update()
        {
        }
    }
}