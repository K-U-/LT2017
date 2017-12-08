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

### シーンががすごいふえるよ！
+++?image=Resources/Scenes.png&size=auto 90%

---

### エンジニアはできるだけマウスを触りたくない

---

### つくったもの

+++

![Video](https://vimeo.com/246468229)

---

### やったこと

- ショートカットで開く |
- 入力フィールドに自動でフォーカス |
- エンターキーでシーンを開く |

---

### ショートカットで開く

+++?code=Assets/Editor/CustomSceneOpener.cs&lang=cs

@[10](MenuItem の後にショートカットキーを設定)

---

### 自動でフォーカス

+++?code=Assets/Editor/CustomSceneOpener.cs&lang=cs

@[27](GUIに名前をつける)
@[28](GUIを生成する)
@[29](名前を指定してフォーカスする)

---

### エンターで開く

+++?code=Assets/Editor/CustomSceneOpener.cs&lang=cs

@[43-46](キー入力を見てひらく)

---

### GUI.SetNextControllNameは便利 |
### GUI.FocusControllは便利 |

---

### GithubPitchはいいぞ

---

### おわり

---
