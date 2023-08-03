using System;

namespace DTT.MinigameAdvertisements.DTT.Minigame_Advertisements.Runtime
{
    /// <summary>
    /// Should be implemented on objects that can emit completed state.
    /// </summary>
    public interface ICompletable
    {
        /// <summary>
        /// Should be invoked when the object has completed its process.
        /// </summary>
        event Action Completed;
    }
}