using DTT.Runtime;
using Naninovel;
using UnityEngine;

namespace Code
{
    public class MiniGameStateSave : MonoBehaviour
    {
        [System.Serializable]
        private class GameState 
        {
            public MemoryGameResults MiniGameResult;
        }

        [SerializeField] private MemoryGameManager _memoryGameManager;
        private MemoryGameResults _miniGameResult;
        private IStateManager _stateManager;

        private void Awake ()
        {
            _stateManager = Engine.GetService<IStateManager>();
        }

        private void OnEnable ()
        {
            _memoryGameManager.Finish += OnMemoryGameFinish;
            _stateManager.AddOnGameSerializeTask(SerializeState);
            _stateManager.AddOnGameDeserializeTask(DeserializeState);
        }

        private void OnMemoryGameFinish(MemoryGameResults results)
        {
            _miniGameResult = results;
        }

        private void OnDisable ()
        {
            _memoryGameManager.Finish -= OnMemoryGameFinish;
            _stateManager.RemoveOnGameSerializeTask(SerializeState);
            _stateManager.RemoveOnGameDeserializeTask(DeserializeState);
        }

        private void SerializeState (GameStateMap stateMap)
        {
            var state = new GameState() {
                MiniGameResult = _miniGameResult,
                
            };
            stateMap.SetState(state);
        }

        private UniTask DeserializeState (GameStateMap stateMap)
        {
            var state = stateMap.GetState<GameState>();
            if (state is null) return UniTask.CompletedTask;

            _miniGameResult = state.MiniGameResult;
            
            return UniTask.CompletedTask;
        }
    }
}