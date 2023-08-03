using Naninovel;


namespace Code.MiniGame
{
    [CommandAlias("novel")]
    public class SwitchToNovelMode : Command
    {
        private const string ACTOR_ID = "MainBackground";
        public StringParameter ScriptName;
        public StringParameter Label;
        public int StartIndex;

        public override async UniTask ExecuteAsync (AsyncToken asyncToken = default)
        {
            NaninovelCameraActivity(true);
            
            NaninovelInputActivityStatus(true);

            NaninovelBackgroundActivity(true);

            LoadNaniScript();
            
            UnloadMiniGameScene();
        }

        private static void UnloadMiniGameScene()
        {
            var miniGameService = Engine.GetService<MiniGameService>();
            miniGameService.UnloadScenes();
        }

        private static void NaninovelBackgroundActivity(bool isActive)
        {
            var background = Engine.GetService<IBackgroundManager>();
            background.GetActor(ACTOR_ID).Visible = isActive;
        }

        private void LoadNaniScript()
        {
            if (Assigned(ScriptName))
            {
                var scriptPlayer = Engine.GetService<IScriptPlayer>();
                scriptPlayer.PreloadAndPlayAsync(ScriptName, StartIndex, 0);
            }
        }

        private static void NaninovelCameraActivity(bool isActive)
        {
            var naniCamera = Engine.GetService<ICameraManager>().Camera;
            naniCamera.enabled = isActive;
        }


        private static void NaninovelInputActivityStatus(bool isActive)
        {
            var inputManager = Engine.GetService<IInputManager>();
            inputManager.ProcessInput = isActive;
        }
    }
}