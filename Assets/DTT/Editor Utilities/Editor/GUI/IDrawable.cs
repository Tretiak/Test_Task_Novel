#if UNITY_EDITOR

namespace DTT.Editor_Utilities.Editor.GUI
{
    /// <summary>
    /// An interface for classes drawable in the Editor GUI.
    /// </summary>
    public interface IDrawable
    {
        /// <summary>
        /// Draws the Editor GUI.
        /// </summary>
        void OnGUI();
    }
}

#endif