﻿namespace DTT.MinigameBase.DTT.Minigame_Base.Runtime
{
    /// <summary>
    /// Should be implemented on objects that can be restarted.
    /// </summary>
    public interface IRestartable
    {
        /// <summary>
        /// Should restart the object so it can be started from a starting point.
        /// </summary>
        void Restart();
    }
}