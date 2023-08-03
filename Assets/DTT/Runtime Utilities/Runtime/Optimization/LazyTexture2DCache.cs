using UnityEngine;

namespace DTT.Runtime_Utilities.Runtime.Optimization
{
    /// <summary>
    /// Implements the lazy dictionary to setup storage of texture 2D objects
    /// to be created once they are used the first time.
    /// </summary>
    public class LazyTexture2DCache : LazyDictionary<string, Texture2D> { }
}
