# Unity-echo3D-demo-EndlessScroller
Scale echo3D across different platforms, including a WebGL build and interactive browser play using Simmer.io.

## Version
[Unity 2020.2.2f1](https://unity3d.com/get-unity/download/archive) <br>
Download the WebGL package for Unity

## Play
Play it on Simmer.io for free [here](https://simmer.io/@echobebe/endless-scroller-shark-edition).

## Register
Don't have an echo3D API key? Make sure to register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).

## Setup
* Clone this [repo](https://github.com/echo3Dco/Unity-echo3D-Demo-EndlessScroller/)
* [Import the Unity SDK](https://docs.echo3d.co/unity/installation)
* [Add the 'Background' asset](https://docs.echo3D.co/quickstart/add-a-3d-model) to the echo3D cloud from the Unity 'Models' folder
* Uncheck the [Security](https://docs.echo3d.co/web-console/deliver-pages/security-page) box in your console
* In Unity's Hierarchy in the 'Flappy Animal' scene modify the Canvas > BG
  Add the echo3D API key and entry ID for the Background image
  Make sure the Sprite Renderer box is unchecked
![APIKeyandEntryId](https://user-images.githubusercontent.com/99516371/169384936-a779f128-be0c-4d69-b411-fff1e8824e33.png)
![Inspector](https://user-images.githubusercontent.com/99516371/170794953-4a9e4527-1704-4bcb-846f-553c653c5260.png)

* Adjust the metadata for the 'Background' asset in the echo3D console. If this doesn't fit, modify as needed.
  xAngle: 90
  zAngle: 180
  scale: .04
  y: .8

## Run
* In Build Settings, add all the scenes and [build to WebGL](https://docs.unity3d.com/Manual/webgl-building.html)
* Create a free [simmer.io](https://simmer.io/) account and upload your WebGL Unity build to it and play in browser!

## Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join). 

## Sources
* [Seaweed art: upklyak / freepik](https://www.freepik.com/free-vector/seaweed-corals-sea-plants-reef-animals_26892839.htm#query=underwater%20icons&position=17&from_view=search)
* [Shark and fish art: macrovector / freepik](https://www.freepik.com/free-vector/underwater-set-with-isolated-flat-cartoon-style-images-deep-sea-fishes-shellfish-turtles-jellyfishes-vector-illustration_26765619.htm#query=underwater%20icons&position=27&from_view=search)
* [Background image: upklyak / freepik](https://www.freepik.com/free-vector/ocean-sea-underwater-background-empty-bottom_7058927.htm#query=underwater&position=6&from_view=search)

## Screenshots
![SIMMERIO build](https://user-images.githubusercontent.com/99516371/170794986-209d27ce-3082-4d59-ace5-f760f2e485e3.png)
![OpeningSceneScreenshot](https://user-images.githubusercontent.com/99516371/170794976-2823d5ce-bcd8-4487-bc89-70c1f4887b5d.png)
![EndlessScrollerGIF](https://user-images.githubusercontent.com/99516371/170795004-058e35fe-b82a-4158-bb18-e42c679a3000.gif)
![FlappyAnimalScene](https://user-images.githubusercontent.com/99516371/170795007-ee32ceef-88dd-46fe-a4d0-7e4979d9e7ed.png)
![HowToPlayScreenshot](https://user-images.githubusercontent.com/99516371/170795015-1922f5e8-e9f6-4eae-ae8a-5991b8c3638b.png)






