# som--tg-station
WIP/Test output of the Somnium transdecompiler on tgstation.

** DO NOT EDIT ANYTHING IN THIS REPO. IT IS AUTOGENERATED. IF YOU WANT TO HELP, PLEASE READ THE 'Contributing' SECTION BELOW **

## Hello, World!
This is the entirety of tgstation, translated from DM to C#. You're probably wondering why I'd dedicate such a significant chunk of my time to such an idiotic goal. I'll try to explain my rationale here.

First things first. BYOND is not ideal. It's great in a lot of ways. It empowers amatures to learn object oriented programming make multiplayer games. It's IDE contains a level editor and an image editor. But it was designed for MUDs. It supports Telnet. It has very poor cross-platform support. It uses an obscure, error-prone scripting language with many peculiarities. It's networking is poor and offers no prediction. It's almost impossible to get threading to work.

There have been many, many attempts to remake Space Station 13 in other game engines. None of these attempts has been incredibly successful. This isn't because the developers are incompetent. It's because it's nearly impossible. SS13 is a very complex game with a huge codebase. It would be difficult for any group of developers to create a stand alone version.

It's especially difficult for professional devlopers to pick up, considering the size of the community and the already open nature of the code. There's very little potential for profit considering the game's niche appeal, and one of the things that makes SS13 great is it's customizability. Modding is not easy to get right, especially on the scale that a SS13 remake would require.

Sadly, the prospects aren't much better for hobbyists. The several groups working on clones independently hinders efforts more than it helps. It's discouraging for both developers and players when three clones exist and they all have very little to show. Neither will migrate from a community with active development to a remake with a fraction of the features.

Almost all attempts are over-ambitous and include plans to remake all the assets or even make the game 3D. Creating 3D assets, complete with textures and animations, is considerably more difficult than small 2D sprites. It also limits the ability of a newbie or a coder with poor art skills to create assets.

After watching many clones come and go (several of them my own), I decided that the best way to approach the problem would be the most backwards sounding. We needed to extract SS13 from BYOND, translate it into a modern language, and build a new engine around it. This is an ideal solution for the following reasons:
1. Code does not need to be remade.
2. Art assets do not need to be remade.
3. C# is a modern OO language that is used for real software, has actual library support, is less error-prone, can be threaded, is more efficient... I could go on...
4. Both the engine and client can be custom-built the way we want.
5. Development of BYOND versions can continue in parallel until everything works on our end.
6. We can find errors in the code more easily, and push changes back to the BYOND versions. (I have already done this once. I'm sitting on a small list of issues that I still need to PR...)
7. We will have much more potential for cool shit once we can edit the engine the game runs on.

Today I partially completed the first stage of that process. The translated codebase compiles. It's incredibly unlikely that anything will work very well, but that can be fixed over time. I hope I've managed to convince you that this is maybe not an entirely terrible idea. If you're interested in helping, please see below. If you think I'm an idiot, hit me up at bigboysauceboss@aol.com with your concerns, and I will try to answer them.

** TLDR: I decided we need to ditch BYOND so I transcompiled SS13 to C#. See the numbered list for reasons why this isn't as dumb as it sounds. **

## FAQ

I'll try to address your concerns here.

### How does this differ from OpenBYOND?
The two projects are similar, but OpenBYOND still relies on BYOND's scripting language, whereas this project aims to abandon the damn thing. For what it's worth, OpenBYOND seems to be.

## Contributing
- ** DO NOT EDIT ANYTHING IN THIS REPO. IT IS AUTOGENERATED.**
- If you want to become part of my crack team of non-skids, hit me up at bigboysauceboss@aol.com
- Getting libraries implemented is the most important task at hand. See the engine repo.
- After that we need to build the engine and the client. The plan is to make a webclient that actually works.
- We need a new map format. Again, don't jump the gun on this. A lot of consideration needs to go into it.
- Anyone know how DMIs work? Should we replace them with our own format or just roll with them?
- If you have a problem with the generated code, please submit an issue here!
- I will not, under any circumstances, release the transcompiler.
- I will transcompile other codebases on request. Eventually.

## Progress

- Oct 8: Project started!
- Nov 1: Started generating coherant code.
- Nov 15: 100% of functions decompiled.
- Jan 5: **It compiles.**
- Current: Assembling the Meme Team.

## Credits
melichior - Project Lead - Wrote the transcompiler
YotaXP - Useful Information - Not actually affiliated with this project

## License
[Licenses of tgstation.](https://github.com/somnium13/-tg-station#license) I'm not really sure how these apply to this project.
