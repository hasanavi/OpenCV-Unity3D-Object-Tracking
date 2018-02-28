# OpenCV and Unity3D integration.
## A simple way to connect Opencv with Unity3D using socket.

# 30th January 2017 update
1. Make it compatible for Unity 5.5 and above
2. Change port from commonly used 5005 to a safer 5065
3. Add comments on how to get position Y value in gameDemo.py file

I've used Open CV Camshift algorithm to detect and track object in Python. Then I send the position of the object into Unity 3D using UDP Socket, read the stream from Unity 3D and change the position of a game object.... Pretty simple.

Here is the demo video - https://www.youtube.com/watch?v=aE4_VtUDORw

In order to make this demo work

1. You need to install Unity3D (http://unity3d.com)
2. Install and configure Python and OpenCV (https://opencv-python-tutroals.readthedocs.org/en/latest/py_tutorials/py_setup/py_setup_in_windows/py_setup_in_windows.html#install-opencv-python-in-windows)
3. Change the 3rd line of OpenCV/gameDemo.py to appropriate installation directory of OpenCv
4. Run the OpenCV/gameDemo.py
5. Drag your mouse over an object. You will find the program start tracking it while you change position. The position will be printed in the command line.
6. Open the Unity3d Scene Unity3D/Assets/Scenes/socketTest.unity in Unity3D
7. Run the game and you will find the Unity's game object is following the real life tracked object


I'm just a tweet away (https://twitter.com/hasanavi) if you find any problem. For other contact details. http://hasanavi.me/

# License
This is strictly **WTFPL** (http://en.wikipedia.org/wiki/WTFPL) license ;)

# If this project help you anyway - I would appreciate if you could buy me a coffe :)

[<img src="https://az743702.vo.msecnd.net/cdn/kofi3.png?v=0">](https://ko-fi.com/A83533OD)
