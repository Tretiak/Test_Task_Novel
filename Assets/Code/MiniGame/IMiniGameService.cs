using Naninovel;

namespace Code.MiniGame
{
    public interface IMiniGameService : IEngineService
    {
        public UniTask InitializeServiceAsync();
        
        public void ResetService();
        
        public void DestroyService();

        public void EnterMiniGameMode();

        public void EnterNovelMode();


    }
}