# OpenCV and Unity3D connection.
## A simple mashup to connect Opencv with Unity3D using port.

I've used Open CV Camshift to detect and track object using Python.. send the position of the object to Unity 3D using UDP Socket, read the stream from Unity 3D and change the position of a game object.... Pretty simple.

Here is the demo video - https://www.youtube.com/watch?v=aE4_VtUDORw

In order to make this demo work

1. You need to install Unity3D (http://unity3d.com)
2. Install and configure Python and OpenCV (http://docs.opencv.org/trunk/doc/py_tutorials/py_setup/py_table_of_contents_setup/py_table_of_contents_setup.html#py-table-of-content-setup)
3. Change the 3rd line of OpenCV/gameDemo.py to appropriate installation location of OpenCv
4. Run the OpenCV/gameDemo.py
5. Drag your mouse over an object. You will find the program start tracking it while you change position. The value will be printed in the command line.
6. Open the Unity3d Scene Unity3D/Assets/Scenes/socketTest.unity in Unity3D
7. Run the game and you will find the Unity's game object is following the real life tracked object
