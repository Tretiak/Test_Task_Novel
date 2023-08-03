using Naninovel;
using Naninovel.Commands;
using UnityEngine;

namespace Code.MiniGame
{
    [Command.CommandAliasAttribute("minigame")]
    public class SwitchToMiniGameMode: Command
    {
        private const string ACTOR_ID = "MainBackground";

        public override async UniTask ExecuteAsync (AsyncToken asyncToken = default)
        {
            // Disable Naninovel input.
            NaninovelInputActivity(false);

            // Stop script player.
            StopNaniScript();

            // Hide text printer.
            HideTextPrinter(asyncToken);

            // Hide background actor
            NaniBackgroundActivity(false);

            // Hide Naninovel Camera
            NaninovelCameraActivity(false);
            
            var miniGameService = Engine.GetService<MiniGameService>();
            miniGameService.SaveCurrentScriptForContinue();
            miniGameService.LoadMiniGameScene();

        }

        private static void NaniBackgroundActivity(bool isActive)
        {
            var background = Engine.GetService<IBackgroundManager>();
            background.GetActor(ACTOR_ID).Visible = isActive;
        }

        private static void StopNaniScript()
        {
            var scriptPlayer = Engine.GetService<IScriptPlayer>();
            scriptPlayer.Stop();
        }

        private static void HideTextPrinter(AsyncToken asyncToken)
        {
            var hidePrinter = new HidePrinter();
            hidePrinter.ExecuteAsync(asyncToken).Forget();
        }

        private static void NaninovelInputActivity(bool isActive)
        {
            var inputManager = Engine.GetService<IInputManager>();
            inputManager.ProcessInput = isActive;
        }
        
        private static void NaninovelCameraActivity(bool isActive)
        {
            var naniCamera = Engine.GetService<ICameraManager>().Camera;
            naniCamera.enabled = isActive;
        }
    }
}