<h1><strong>MyScouter</strong></h1>
<h3>Description:</h3>
<p dir="ltr">In this game, we've tried to create a simple and fun simulation of a manager's career.</p>
<p dir="ltr">First of all, you'll have to recruit a new football player. Then you'll be able to guide your client through different activities. make sure you satisfy your client's needs.. if you're good enough you'll be able to achieve the goal and finish a successful career with your client. Be sloppy and you might find yourself fired...</p>
<p dir="ltr">Don't forget to let your client play matches once in a while so you can gain money - if he wins.</p>
<h3>How to play:</h3>
<p>First - you have to recruit a player.<br />Second - After you recruit a player you'll see the player has 5 different needs that you'll want to satisfy.. while positive needs you'll want to increase and negative needs you'll want to decrease.<br />Third - You can see at any given point what the goal score is, the player needs to have an immediate effect on the goal score. get a high enough score and you finish your career successfully, reach a very low goal score and you'll get fired.<br />Fourth - You can send your player on different activities which by turn will satisfy different needs depending on the activity chosen.<br />Additionally - every once in a while you'll be able to send your player on a match - win the match and you gain money, lose the match and you lose money.<br />Every red arrow indicates an object that can be interacted with.</p>
<h3>More Information &amp; Scripts:</h3>
<p>In the game, we've combined the use of <a href="https://twinery.org/">Twine</a> and <a href="https://github.com/daterre/Cradle">Cradle</a> to create an interactive storytelling game. The concept is pretty straightforward, a dialog will open every time the player interacts with different game objects, and according to the player's decision different actions will happen - such as playing different videos.</p>
<p>The following scripts are in charge of the twine part in the game:</p>
<p><a href="MyScouter/Assets/Scripts/NPC.cs">NPC</a>,&nbsp;<a href="MyScouter/Assets/Scouter_Career.cs">ScouterCareer</a></p>
<p>The following scripts are in charge of the text UI and videos:</p>
<p><a href="MyScouter/Assets/Scripts/ShowMassage.cs">ShowMessage</a>, &nbsp;<a href="MyScouter/Assets/Scripts/StreamVideo.cs">StreamVideo</a></p>
<p>The following scripts are in charge of the player's movement and the player's needs:</p>
<p><a href="MyScouter/Assets/Scripts/controller/CameraControler.cs">CameraControler</a>,&nbsp;<a href="MyScouter/Assets/Scripts/controller/PlayerMovement.cs">PlayerMovement</a>,&nbsp;<a href="MyScouter/Assets/Scripts/controller/TextController.cs">TextController</a></p>
<p>The following scripts are in charge of the interaction and basically are the main logic for the different actions happening in the game. We've created a base interface <a href="MyScouter/Assets/Scripts/Interaction/Interaction.cs">Interaction</a>&nbsp;that has the logic needed for basic interaction between objects.<br />The other interactions are&nbsp;<a href="MyScouter/Assets/Scripts/Interaction/PhoneInteraction.cs">PhoneInteraction</a>,&nbsp;<a href="MyScouter/Assets/Scripts/Interaction/PlayerInteraction.cs">PlayerInteraction</a>,&nbsp;and&nbsp;<a href="MyScouter/Assets/Scripts/Interaction/ComputerInteraction.cs">ComputerInteraction</a>.</p>
<p>&nbsp;<a href="https://mosheelhadad.itch.io/myscouter">Play in itch.io</a></p>
