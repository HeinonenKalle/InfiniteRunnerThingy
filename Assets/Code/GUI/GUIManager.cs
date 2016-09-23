using UnityEngine;
using UnityEngine.UI;
using System.Collections;


namespace Runner {

    public class GUIManager : MonoBehaviour {
        [SerializeField] private Text _message;

        public void Awake()
        {
            if(_message == null)
            {
                Debug.LogError("GUIManager: _message is null");
                Debug.Break();
            }

            HideMessage();
        }

        public void ShowMessage(string message)
        {
            //_message.text = message;
            _message.gameObject.SetActive(true);
        }

        public void HideMessage()
        {
            _message.gameObject.SetActive(false);
        }
    }
}
