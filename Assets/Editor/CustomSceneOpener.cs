using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using UnityEngine;
using UnityEditor;

public class CustomSceneOpener : EditorWindow {

    [MenuItem("Tools/Util/Custom Scene Opener %#t")]
    public static void OpenDialog(){
        var window = EditorWindow.GetWindow<CustomSceneOpener> ("CustomSceneOpener");
        window.Focus ();
        window.InitializeScenes ();
    }

    private string sceneName;
    private string[] allScenes;
    public void InitializeScenes(){
        allScenes = AssetDatabase.GetAllAssetPaths ().
            Where ((arg) => arg.EndsWith (".unity")).ToArray ();
        sceneName = "";
    }

    public void OnGUI (){
        GUILayout.BeginVertical ();{
            GUI.SetNextControlName ("Input");
            sceneName = GUILayout.TextField (sceneName);
            GUI.FocusControl ("Input");
            var temp = allScenes;
            if (!string.IsNullOrEmpty (sceneName)){ 
                temp = allScenes.Where ((arg) => Path.GetFileName (arg).Replace (".unity", "").ToLower().Contains (sceneName.ToLower())).ToArray();
            }
            foreach (var scene in temp){
                GUILayout.BeginHorizontal ();{
                    GUILayout.Label (Path.GetFileName (scene));
                    GUILayout.FlexibleSpace ();
                    if (GUILayout.Button ("Open")){
                        OpenScene (scene);
                    }
                }GUILayout.EndHorizontal ();
            }
            if (Event.current.keyCode == KeyCode.Return && temp.Length > 0){
                var scene = temp.First ();
                OpenScene (scene);
            }

        }GUILayout.EndVertical ();
    }
    private void OpenScene(string scene){
        if (UnityEditor.SceneManagement.EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo ()){
            UnityEditor.SceneManagement.EditorSceneManager.OpenScene (scene, UnityEditor.SceneManagement.OpenSceneMode.Single);
            this.Close ();
        }
    }
}

