using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject fadeScreenObject;
    private CanvasGroup fadeScreen;

    private GameObject currentSphere;

    private void Start()
    {
        fadeScreen = fadeScreenObject.GetComponent<CanvasGroup>();
        currentSphere = GetActiveSphere(); // Find the currently active sphere at start
    }

    public void SwitchTo(GameObject targetSphere)
    {
        StartCoroutine(FadeTransition(targetSphere));
    }

    IEnumerator FadeTransition(GameObject targetSphere)
    {
        fadeScreenObject.SetActive(true);

        // Fade to black
        for (float t = 0; t < 1; t += Time.deltaTime)
        {
            fadeScreen.alpha = t;
            yield return null;
        }

        // Switch spheres
        currentSphere.SetActive(false);
        targetSphere.SetActive(true);
        currentSphere = targetSphere;

        // Fade from black
        for (float t = 1; t > 0; t -= Time.deltaTime)
        {
            fadeScreen.alpha = t;
            yield return null;
        }

        fadeScreenObject.SetActive(false);
    }

    private GameObject GetActiveSphere()
    {
        // Assumes all spheres are tagged "Sphere" (add this tag manually)
        GameObject[] spheres = GameObject.FindGameObjectsWithTag("Sphere");
        foreach (var sphere in spheres)
        {
            if (sphere.activeInHierarchy)
                return sphere;
        }
        Debug.LogWarning("No active sphere found!");
        return null;
    }
}
