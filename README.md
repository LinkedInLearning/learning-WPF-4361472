# WPF 入門
LinkedInラーニングの「WPF 入門」コース用のリポジトリです。このコースは [LinkedInラーニング][lil-course-url]で視聴できます。

![WPF 入門][lil-thumbnail-url] 
WPFはWindows用のデスクトップアプリーケーション開発用のUIフレームワークです。多様化した画面解像度や高いカスタマイズ性という新しい需要にこたえるためにリリースされました。このコースではWPFの基本から重要な要素であるXAMLについてまでをわかりやすく解説します。画面に配置する部品やコントロールのカスタマイズからXAMLとプログラミングコードを連携させるデータバインディング、イベントの仕組みについて学びます。このコースを学習することでWPFがどのようなUIフレームワークかを知ることができるでしょう。

## リポジトリの使い方
このリポジトリには必要に応じてブランチが設けられています。ブランチのポップアップメニューを使用して、使用するブランチに切り替えたあとにコースを視聴してください。またURLに`「/tree/ブランチ名」`を追加することで、アクセスしたいブランチに移動することも可能です。

## ブランチ
ブランチはレッスンごとに作成されている場合があります。その場合はブランチ名に`「章番号_レッスン番号」`が付けられています。例えば`「02_03」`という名前のブランチは、2章の上から3番目のレッスン用のブランチとなります。

レッスン前と後のコードを格納しているブランチもあります。該当ブランチには「開始時」（beginning）を表す`「b」`と、「終了時」（ending）を表す`「e」` がブランチ名についています。`「b」`のブランチにはレッスン開始時点のコードが、`「e」`のブランチにはレッスン終了時点のコードが格納されています。また「main」のブランチにはコードの最終形が格納されています。

ファイルに変更を加えた後に、エクササイズファイルのブランチを次のブランチに切り替えたさい、次のようなメッセージが表示されることがあります。

    error: Your local changes to the following files would be overwritten by checkout:        [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

この問題を解決するには：
	
    次のコマンドで変更を加えます：git add .
	次のコマンドで変更をコミットします：git commit -m "some message"

## インストール
1. エクセサイズファイルを使用するには`Visual Studio 2017以降`がインストールされている必要があります
	- [Visual Studio](https://visualstudio.microsoft.com/ja/downloads/)
2. リポジトリをWindows PCにクローンしてください。
3. フォルダーの中にある`ソリューションファイル（拡張子が.sln）`をVisual Studioで開くことで実行することができます。

### インストラクター

**西村 誠**

_プログラマー、Microsoft MVP_

この講師の他のコースを視聴する：[LinkedInラーニング](https://www.linkedin.com/learning/instructors/13315091)

[lil-course-url]: https://www.linkedin.com/learning/learning-wpf
[lil-thumbnail-url]: https://cdn.lynda.com/course/2875095/2875095-1615224395432-16x9.jpg
