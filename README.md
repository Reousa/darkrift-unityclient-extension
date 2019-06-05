# DarkRift2 UnityClient Extension Methods

A collection of one-liner extension methods to make your DR2 life easier.


## Usage

To start using the example, clone the repo & place it in your client project.

1. Create an empty game object.
2. Add a `UnityClient` to it as you would following the [docs](https://darkriftnetworking.com/DarkRift2/Docs/2.4.2/getting_started/2_the_unity_scene.html)
3. Add the `ExampleMonoBehaviour` script to the same gameobject.
4. `SendExampleMEssage` will be called on `Update`. You're done!

## Beginner 101

`IMessage` serves as a supplementary interface to the `IDarkRiftSerializable` to eliminate boilerplate code that you might have to otherwise write or keep track of. It forces every message to contain a `ushort Tag`, that is then fetched by the extension methods to do the work for you.

It is recommended to follow the example by having a list of tags, contained within an `Enum` that inherits `ushort`, to minimize the chances of human error.

## Notes

This is a stripped down version of some production code I use, to keep things simple.
It is fully possible to further expand them by improving your `IMessage` interface to further supplement DarkRift2's `IDarkRiftSerializable` and adjust the Exstension Methods accordingly.

If you're a beginner however, these one-liners should get you started just fine.

## About DarkRift2

[DarkRift2](https://darkriftnetworking.com/DarkRift2/) is an amazing C# networking library created by [Jamie](https://github.com/JamJar00).
