[ENGLISH](README.md)

# LipFilter AR
립필터 AR은 가상 메이크업을 위해 만들어진 유니티 모바일 앱 입니다.

전면 카메라를 이용하여 여러가지 립스틱 컬러를 체험해 볼 수 있습니다.

## 요구사항
유니티 에디터와 안드로이드 7.0 버전 이상의 스마트폰

호환성: 이 프로젝트는 Unity 2021.3.6f1 기준으로 제작되었습니다.

## 시작하기
1. 이 저장소를 클론하고, 유니티에서 실행합니다.
2. 프로젝트 폴더의, `Assets` -> `FaceTracking-lipfilter` -> `CustomFace` scene을 열어주세요.
3. Scene 화면의 `Game` 창에서, aspect ratio 를 16:9 Portrait 으로 변경해주세요.

## 안드로이드 빌드하기
1. 유니티 에디터에서  `File` -> `Build Settings` 에서, 안드로이드 선택 후 `Switch Platform`을 눌러주세요. 안드로이드 빌드 전용 추가 패키지 설치가 요구 될 수 있습니다.
2. `Player Settings` -> `XR Plug-in Management` 클릭
3. 안드로이드를 선택 후, 아직 체크가 안되어 있다면 `ARCore` 를 체크해주세요.


* 디바이스에 직접 빌드
1. `File` -> `Build Settings` 에서, `Development Build` 체크
2. `Patch` 또는 `Patch And Run` 클릭

* APK로 빌드

    `Build` 또는 `Build And Run` 클릭