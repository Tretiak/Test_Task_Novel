using UnityEngine;

namespace DTT.MinigameBase.DTT.Minigame_Base.Runtime.Level_Select
{
    /// <summary>
    /// Base operations for using the <see cref="LevelSelectHandler{TConfig,TResult,TMinigame}"/>.
    /// </summary>
    public abstract class LevelSelectHandlerBase : MonoBehaviour
    {
        /// <summary>
        /// Retrieves the current level.
        /// </summary>
        public abstract int CurrentLevel { get; }
        
        /// <summary>
        /// Hides the level selection user interface.
        /// </summary>
        public abstract void HideLevelSelect();
        
        /// <summary>
        /// Shows the level selection user interface.
        /// </summary>
        public abstract void ShowLevelSelect();
    }
}