[a relative link](README.md)

# LipFilter AR
블라블라블라블라블라블라블라블라블라블라

## Requirements
You will need Unity, and an android phone running Android 7.0 or higher.

## Setup
1. Clone this repo, and open it with a Unity editor.
2. In the project folder, open `Assets` -> `FaceTracking-lipfilter` -> `CustomFace` scene.
3. In `Game` view, change the aspect ratio to 16:9 Portrait.
## Building for Android
1. In the Unity editor, go to `File` -> `Build Settings`. Select Android and `Switch Platform`. You may have to install packages for Android build support.
2. Go to `Player Settings` -> `XR Plug-in Management`.
3. Select Android and checkmark `ARCore` if not already checked.

Either:

* Build Directly on device
1. In `File` -> `Build Settings`, enable `Development Build`.
2. `Patch` or `Patch And Run`.

* Build APK
    
     Hit `Build`. (or `Build And Run` to generate an apk file and install it to the device)

블라블라