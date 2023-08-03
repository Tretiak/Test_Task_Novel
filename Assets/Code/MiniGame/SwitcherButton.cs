using System;
using DTT.MinigameBase.DTT.Minigame_Base.Runtime.Level_Select;
using Naninovel;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.MiniGame
{
    public class SwitcherButton : MonoBehaviour
    {
        public async void SwitchToNovelMode()
        {
            var miniGameService = Engine.GetService<IMiniGameService>();
            miniGameService.EnterNovelMode();
        }
    }
}