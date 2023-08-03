using System.Collections;
using System.Collections.Generic;
using Code.Quest;
using Naninovel;
using UnityEngine;

public class QuestMarkerHandler : MonoBehaviour
{
    [SerializeField] private QuestMarker[] _questMarkers;
    
    private const string QUEST_LOCATION_KEY = "questMarker";

    public void CheckQuestMarker()
    {
        var customVariableManager = Engine.GetService<ICustomVariableManager>();
        string location = customVariableManager.GetVariableValue(QUEST_LOCATION_KEY);
        
        foreach (QuestMarker marker in _questMarkers)
        {
            marker.CheckMarker(location);
        }
        
    }
}

