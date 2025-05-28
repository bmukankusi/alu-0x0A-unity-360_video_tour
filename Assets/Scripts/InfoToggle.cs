using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InfoToggle : MonoBehaviour
{
    public GameObject infoPanel;

    public void ToggleInfo()
    {
        //Set panel active and inactive
     
        Debug.Log("Button clicked. Toggling panel.");
        infoPanel.SetActive(!infoPanel.activeSelf);
    }

}
