/*using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

[InitializeOnLoad]
public static class ForceMenuOnPlay_Editor
{
    const string KEY = "FORCE_MENU_ON_PLAY";

    static ForceMenuOnPlay_Editor()
    {
        EditorApplication.playModeStateChanged += OnPlayModeChanged;
    }

    static bool ForceMenu
    {
        get => EditorPrefs.GetBool(KEY, true);
        set => EditorPrefs.SetBool(KEY, value);
    }

    static void OnPlayModeChanged(PlayModeStateChange state)
    {
        if (!ForceMenu) return;

        if (state == PlayModeStateChange.ExitingEditMode)
        {
            if (SceneManager.GetActiveScene().buildIndex != 0)
            {
                EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
                EditorSceneManager.OpenScene(
                    SceneUtility.GetScenePathByBuildIndex(0)
                );
            }
        }
    }

    // 📌 MENU BẬT / TẮT
    [MenuItem("Tools/Start From Menu")]
    static void Toggle()
    {
        ForceMenu = !ForceMenu;
    }

    [MenuItem("Tools/Start From Menu", true)]
    static bool ToggleValidate()
    {
        Menu.SetChecked("Tools/Start From Menu", ForceMenu);
        return true;
    }
}                */
