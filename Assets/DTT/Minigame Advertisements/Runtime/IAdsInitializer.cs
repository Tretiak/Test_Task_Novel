namespace DTT.MinigameAdvertisements.DTT.Minigame_Advertisements.Runtime
{
    /// <summary>
    /// Interface for ad initializers.
    /// </summary>
    public interface IAdsInitializer
    {
        /// <summary>
        /// Initializes the ads.
        /// </summary>
        public void Initialize();

        /// <summary>
        /// Called when the ads have been initialized.
        /// </summary>
        public void OnInitializationComplete();
    }
}