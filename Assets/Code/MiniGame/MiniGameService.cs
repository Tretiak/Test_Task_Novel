using DTT.MinigameBase.DTT.Minigame_Base.Runtime.Level_Select;
using DTT.Tweening.DTT.DTTween.Runtime;
using Naninovel;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.MiniGame
{
    [InitializeAtRuntime]
    public class MiniGameService: IMiniGameService
    {
        private const int SKIP_LINES = 2;
        private SwitchToNovelMode _switchToNovelMode;
        private SwitchToMiniGameMode _switchToMiniGameMode;
        private IScriptPlayer _scriptPlayer;
        private int _lineBeforeMiniGameIndex;
        private Script _scriptToContinue;

        public UniTask InitializeServiceAsync()
        {
            _scriptPlayer = Engine.GetService<IScriptPlayer>();
            _switchToNovelMode = new SwitchToNovelMode();
            _switchToMiniGameMode = new SwitchToMiniGameMode();
            
            return UniTask.CompletedTask;
        }

        public void EnterMiniGameMode()
        {
            _switchToMiniGameMode.ExecuteAsync();
        }

        public void SaveCurrentScriptForContinue()
        {
            _lineBeforeMiniGameIndex = _scriptPlayer.PlayedIndex;
            _scriptToContinue = _scriptPlayer.PlayedScript;
        }

        public void EnterNovelMode()
        {
            _switchToNovelMode.ScriptName = _scriptToContinue.Name;
            _switchToNovelMode.StartIndex = _lineBeforeMiniGameIndex + SKIP_LINES;
            _switchToNovelMode.ExecuteAsync();
        }
        
        public void ResetService()
        {
            
        }

        public void DestroyService()
        {
            
        }

        public void LoadMiniGameScene()
        {
            SceneManager.LoadSceneAsync(NameConstants.MINI_GAME_SCENE, LoadSceneMode.Additive);
        }

        public void UnloadScenes()
        {
            Object.Destroy(DTTween.GetWorker());
            SceneActivation(NameConstants.MINI_GAME_SCENE, false);
            SceneActivation(NameConstants.MINI_GAME_LEVEL_SELECT, false);
            SceneManager.UnloadSceneAsync(NameConstants.MINI_GAME_SCENE);
            SceneManager.UnloadSceneAsync(NameConstants.MINI_GAME_LEVEL_SELECT);
        }

        private void SceneActivation(string sceneName, bool isActive)
        {
            Scene scene = SceneManager.GetSceneByName(sceneName);
            GameObject[] rootsGO = scene.GetRootGameObjects();

            foreach (var obj in rootsGO)
            {
                obj.SetActive(isActive);
            }
        }
    }
}