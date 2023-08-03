using UnityEngine;
using UnityEngine.UI;

namespace Code.Quest
{
    public class QuestMarker : MonoBehaviour
    {
        [SerializeField]
        private string _myLocation;

        private string _locationName;

        private Image _markerImage;

        private void Start()
        {
            _markerImage = GetComponentInChildren<Image>();
            MarkerActive(false);
        }
        
        public void CheckMarker(string location)
        {
            if (location == _myLocation) MarkerActive(true);
            else MarkerActive(false);

        }

        private void MarkerActive(bool isActive)
        {
            _markerImage.gameObject.SetActive(isActive);
        }
    }
}