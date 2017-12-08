### これはマジで便利だったEditor拡張2017
---

![icon](https://github.com/K-U-.png)

---

比較的大規模なゲームの開発をしています
- 某リアルタイムバトルのある3DRPGとか |
- 某有名IPのパズルゲームとか |

---

### シーンをAssetBundleにしてしまう

---

### シーンがすごいふえるよ！
+++?image=Resources/Scenes.png&size=auto 90%

---

### エンジニアはできるだけマウスを触りたくない

---

### つくったもの

+++

![Video](https://player.vimeo.com/video/246468229)

+++?image=Resources/Opener.png&size=auto 90%

---



### やったこと

- ショートカットで開く |
- 入力フィールドに自動でフォーカス |
- エンターキーでシーンを開く |

---

### ショートカットで開く

+++

```
[MenuItem("Tools/Util/Custom Scene Opener %#t")]
public static void OpenDialog(){
    var window = EditorWindow.GetWindow<CustomSceneOpener> ("CustomSceneOpener");
    window.Focus ();
    window.InitializeScenes ();
}
```

@[1](MenuItem の後にショートカットキーを設定)

+++

| 文字 | キー |
| ---- | ---- |
| % | Cmd / Ctrl |
| # | Shift |
| & | option / alt |

---

### 自動でフォーカス

+++?code=Assets/Editor/CustomSceneOpener.cs&lang=cs

@[29](GUIに名前をつける)
@[30](GUIを生成する)
@[31](名前を指定してフォーカスする)

---

### エンターで開く

+++?code=Assets/Editor/CustomSceneOpener.cs&lang=cs

@[47-51](キー入力を見てひらく)

+++

```
private void OpenScene(string scene){
    if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo ()){
        EditorSceneManager.OpenScene (scene, UnityEditor.SceneManagement.OpenSceneMode.Single);
        this.Close ();
    }
}
```

@[2](変更を保存するか確認するダイアログを表示する)

+++?image=Resources/Save.png&size=auto 90%

+++

```
private void OpenScene(string scene){
    if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo ()){
        EditorSceneManager.OpenScene (scene, UnityEditor.SceneManagement.OpenSceneMode.Single);
        this.Close ();
    }
}
```
@[3](キャンセル以外でtrueなので実際にシーンを開く)

---

GUI.SetNextControllNameは便利

GUI.FocusControllは便利

---

GitPitchはいいぞ

---

### おわり

---
