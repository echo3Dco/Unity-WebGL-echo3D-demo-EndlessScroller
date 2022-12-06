# Unity-echo3D-demo-EndlessScroller
Scale echo3D across different platforms, including WebGL and an interactive Desktop browser using Simmer.io.

## Setup
* Built with Unity 2020.3.25.  _(Note: The echo3D Unity SDK is supported in 2020.3.25 and higher.)_
* Register for FREE at [echo3D](https://console.echo3D.co/#/auth/register).
* [Add the Unity SDK](https://medium.com/r/?url=https%3A%2F%2Fdocs.echo3d.co%2Funity%2Finstallation). Troubleshoot [here](https://docs.echo3d.com/unity/troubleshooting#im-getting-a-newtonsoft.json.dll-error-in-unity).
* Clone this repo. 

## Play
Play it on Simmer.io for free [here](https://simmer.io/@echobebe/endless-scroller-shark-edition).

## Setup
* * [Add these models](https://docs.echo3D.co/quickstart/add-a-3d-model) to the echo3D console from the Unity Assets/Models folder:  <br>
      - Background <br>
* Open the _FlappyAnimal_ scene and view Canvas > BG <br>
* [Set the API key](https://docs.echo3d.co/quickstart/access-the-console) and Entry IDs for those same models in the Inspector. <br>
![APIKeyandEntryId](https://user-images.githubusercontent.com/99516371/195749269-f7a43477-b67a-49e8-a212-6abdb9c948fd.png)<br>
![NEWAPIKeyandEntryID](https://user-images.githubusercontent.com/99516371/205407613-b746840f-8e8a-4ec8-b056-a680395dfab4.png)<br>
* [Type your Secret Key](https://docs.echo3d.co/web-console/deliver-pages/security-page#secret-key) as the value for the parameter secKey in the file Packages/co.echo3D.unity/Runtime/Echo3DHologram.cs. _(Note: Secret Key only matters if you have the Security Key enabled). You can turn it off in the Security options in your echo3D console._
![NEWSecKey2](https://user-images.githubusercontent.com/99516371/195749308-b2349a3b-7e43-4d3c-8f09-fbfa9d3cb0be.png)<br>
* (Recommended) To move, resize or edit the assets live in your Scene view, check the boxes for “Editor Preview” and “Ignore Model Transforms”. To enable this, click Echo3D > Load Editor Holograms in your Unity toolbar. <br>
![EditorPreviewAndIgnoreModelTransforms](https://user-images.githubusercontent.com/99516371/195749348-dc0b06ad-efa6-4dbd-962f-0119b5c33ea0.png)<br>
![LoadHolograms](https://user-images.githubusercontent.com/99516371/195749354-b2295183-f877-444a-af22-ed87ffb17705.png) <br>

## Run
* In Build Settings, add all the scenes and [build to WebGL](https://docs.unity3d.com/Manual/webgl-building.html).
* Create a free [simmer.io](https://simmer.io/) account and upload your WebGL Unity build to it and play in browser!

## Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join). 

## Troubleshooting
Visit our troubleshooting guide [here](https://docs.echo3d.co/unity/troubleshooting#im-getting-a-newtonsoft.json.dll-error-in-unity). 

## Sources
* [Seaweed art: upklyak / freepik](https://www.freepik.com/free-vector/seaweed-corals-sea-plants-reef-animals_26892839.htm#query=underwater%20icons&position=17&from_view=search)
* [Shark and fish art: macrovector / freepik](https://www.freepik.com/free-vector/underwater-set-with-isolated-flat-cartoon-style-images-deep-sea-fishes-shellfish-turtles-jellyfishes-vector-illustration_26765619.htm#query=underwater%20icons&position=27&from_view=search)
* [Background image: upklyak / freepik](https://www.freepik.com/free-vector/ocean-sea-underwater-background-empty-bottom_7058927.htm#query=underwater&position=6&from_view=search)

## Screenshots
![EndlessScrollerGIF](https://user-images.githubusercontent.com/99516371/170795004-058e35fe-b82a-4158-bb18-e42c679a3000.gif)
![SIMMERIO build](https://user-images.githubusercontent.com/99516371/170794986-209d27ce-3082-4d59-ace5-f760f2e485e3.png)
![OpeningSceneScreenshot](https://user-images.githubusercontent.com/99516371/170794976-2823d5ce-bcd8-4487-bc89-70c1f4887b5d.png)
![FlappyAnimalScene](https://user-images.githubusercontent.com/99516371/170795007-ee32ceef-88dd-46fe-a4d0-7e4979d9e7ed.png)
![HowToPlayScreenshot](https://user-images.githubusercontent.com/99516371/170795015-1922f5e8-e9f6-4eae-ae8a-5991b8c3638b.png)
