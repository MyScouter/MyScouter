﻿/*
------------------------------------------------
Generated by Cradle 2.0.1.0
https://github.com/daterre/Cradle

Original file: Scouter_Career.html
Story format: Harlowe
------------------------------------------------
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cradle;
using IStoryThread = System.Collections.Generic.IEnumerable<Cradle.StoryOutput>;
using Cradle.StoryFormats.Harlowe;

public partial class @Scouter_Career: Cradle.StoryFormats.Harlowe.HarloweStory
{
	#region Variables
	// ---------------

	public class VarDefs: RuntimeVars
	{
		public VarDefs()
		{
			VarDef("ScouterName", () => this.@ScouterName, val => this.@ScouterName = val);
			VarDef("Helper", () => this.@Helper, val => this.@Helper = val);
			VarDef("playerName", () => this.@playerName, val => this.@playerName = val);
			VarDef("isTired", () => this.@isTired, val => this.@isTired = val);
			VarDef("isWorkout", () => this.@isWorkout, val => this.@isWorkout = val);
			VarDef("isPractice", () => this.@isPractice, val => this.@isPractice = val);
			VarDef("isEating", () => this.@isEating, val => this.@isEating = val);
			VarDef("isOut", () => this.@isOut, val => this.@isOut = val);
			VarDef("moneyAmount", () => this.@moneyAmount, val => this.@moneyAmount = val);
			VarDef("canPlay", () => this.@canPlay, val => this.@canPlay = val);
			VarDef("loanRound", () => this.@loanRound, val => this.@loanRound = val);
			VarDef("daysToReturn", () => this.@daysToReturn, val => this.@daysToReturn = val);
			VarDef("waitTime", () => this.@waitTime, val => this.@waitTime = val);
			VarDef("isLoan", () => this.@isLoan, val => this.@isLoan = val);
			VarDef("fromScene", () => this.@fromScene, val => this.@fromScene = val);
			VarDef("isUpgrade", () => this.@isUpgrade, val => this.@isUpgrade = val);
			VarDef("boostRounds", () => this.@boostRounds, val => this.@boostRounds = val);
			VarDef("motivation", () => this.@motivation, val => this.@motivation = val);
			VarDef("physicalShape", () => this.@physicalShape, val => this.@physicalShape = val);
			VarDef("happiness", () => this.@happiness, val => this.@happiness = val);
			VarDef("hunger", () => this.@hunger, val => this.@hunger = val);
			VarDef("tiredness", () => this.@tiredness, val => this.@tiredness = val);
			VarDef("goal", () => this.@goal, val => this.@goal = val);
			VarDef("flagNum", () => this.@flagNum, val => this.@flagNum = val);
			VarDef("rcOne", () => this.@rcOne, val => this.@rcOne = val);
			VarDef("rcTwo", () => this.@rcTwo, val => this.@rcTwo = val);
			VarDef("rcThree", () => this.@rcThree, val => this.@rcThree = val);
			VarDef("avrChance", () => this.@avrChance, val => this.@avrChance = val);
			VarDef("isWin", () => this.@isWin, val => this.@isWin = val);
			VarDef("amountToReturn", () => this.@amountToReturn, val => this.@amountToReturn = val);
		}

		public StoryVar @ScouterName;
		public StoryVar @Helper;
		public StoryVar @playerName;
		public StoryVar @isTired;
		public StoryVar @isWorkout;
		public StoryVar @isPractice;
		public StoryVar @isEating;
		public StoryVar @isOut;
		public StoryVar @moneyAmount;
		public StoryVar @canPlay;
		public StoryVar @loanRound;
		public StoryVar @daysToReturn;
		public StoryVar @waitTime;
		public StoryVar @isLoan;
		public StoryVar @fromScene;
		public StoryVar @isUpgrade;
		public StoryVar @boostRounds;
		public StoryVar @motivation;
		public StoryVar @physicalShape;
		public StoryVar @happiness;
		public StoryVar @hunger;
		public StoryVar @tiredness;
		public StoryVar @goal;
		public StoryVar @flagNum;
		public StoryVar @rcOne;
		public StoryVar @rcTwo;
		public StoryVar @rcThree;
		public StoryVar @avrChance;
		public StoryVar @isWin;
		public StoryVar @amountToReturn;
	}

	public new VarDefs Vars
	{
		get { return (VarDefs) base.Vars; }
	}

	// ---------------
	#endregion

	#region Initialization
	// ---------------

	public readonly Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros macros1;

	@Scouter_Career()
	{
		this.StartPassage = "Introduction";

		base.Vars = new VarDefs() { Story = this, StrictMode = true };

		macros1 = new Cradle.StoryFormats.Harlowe.HarloweRuntimeMacros() { Story = this };

		base.Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
		passage6_Init();
		passage7_Init();
		passage8_Init();
		passage9_Init();
		passage10_Init();
		passage11_Init();
		passage12_Init();
		passage13_Init();
		passage14_Init();
		passage15_Init();
		passage16_Init();
		passage17_Init();
		passage18_Init();
		passage19_Init();
		passage20_Init();
		passage21_Init();
		passage22_Init();
		passage23_Init();
		passage24_Init();
		passage25_Init();
		passage26_Init();
		passage27_Init();
		passage28_Init();
		passage29_Init();
		passage30_Init();
	}

	// ---------------
	#endregion

	// .............
	// #1: First Call

	void passage1_Init()
	{
		this.Passages[@"First Call"] = new StoryPassage(@"First Call", new string[]{  }, passage1_Main);
	}

	IStoryThread passage1_Main()
	{
		Vars.ScouterName  = "John";
		yield return lineBreak();
		Vars.Helper  = "Secretary:";
		yield return lineBreak();
		yield return text(Vars.Helper);
		yield return text(" Hi ");
		yield return text(Vars.ScouterName);
		yield return text(", How are you Today? do you want to recruit a new player?");
		yield return lineBreak();
		yield return link("I'm good! Not yet, I want to look around my new house a bit.. ", "Other Calls", null);
		yield return lineBreak();
		yield return link("I'm good! Yes, I can't wait to recruit my first client!! ", "Choose Player", null);
		yield break;
	}


	// .............
	// #2: Choose Player

	void passage2_Init()
	{
		this.Passages[@"Choose Player"] = new StoryPassage(@"Choose Player", new string[]{  }, passage2_Main);
	}

	IStoryThread passage2_Main()
	{
		yield return text("Who would you like to recruit Ms. John?");
		yield return lineBreak();
		yield return link("Fernandinez Horasio, In great shape but not so motivated.. ", "Hello Fernandinez", null);
		yield return lineBreak();
		yield return link("Van Bluchten, Very motivated but not in the best shape.. ", "Hello Van", null);
		yield return lineBreak();
		yield return link("Dembalio Grizman, Pretty average in both motivation and shape ", "Hello Dembalio", null);
		yield return lineBreak();
		yield return lineBreak();
		Vars.playerName  = "";
		yield return lineBreak();
		yield return lineBreak();
		
Vars.isTired  = false; 
Vars.isWorkout  = false; 
Vars.isPractice  = false; 
Vars.isEating  = false; 
Vars.isOut  = false; 
Vars.moneyAmount  = 500; 
Vars.canPlay  = false; 
Vars.loanRound  = 0; 
Vars.daysToReturn  = 0; 
Vars.waitTime  = -1; 
Vars.isLoan  = false; 
Vars.fromScene  = ""; 
Vars.isUpgrade  = false; 
Vars.boostRounds  = 0
;
		yield break;
	}


	// .............
	// #3: Other Calls

	void passage3_Init()
	{
		this.Passages[@"Other Calls"] = new StoryPassage(@"Other Calls", new string[]{  }, passage3_Main);
	}

	IStoryThread passage3_Main()
	{
		yield return text(Vars.Helper);
		yield return text(" Hi Again! Did you look around enough? Would you want to call now?");
		yield return lineBreak();
		yield return link("No, not yet.. ", "Other Calls", null);
		yield return text(" ");
		yield return lineBreak();
		yield return link("Yes, I would love to recruit a new client now ", "Choose Player", null);
		yield return text(" ");
		yield break;
	}


	// .............
	// #4: Hello Fernandinez

	void passage4_Init()
	{
		this.Passages[@"Hello Fernandinez"] = new StoryPassage(@"Hello Fernandinez", new string[]{  }, passage4_Main);
	}

	IStoryThread passage4_Main()
	{
		Vars.playerName  = "Fernandinez";
		yield return lineBreak();
		Vars.motivation  = 30;
		yield return lineBreak();
		Vars.physicalShape  = 70;
		yield return lineBreak();
		Vars.happiness  = 50;
		yield return lineBreak();
		Vars.hunger  = 40;
		yield return lineBreak();
		Vars.tiredness  = 40;
		yield return lineBreak();
		yield return lineBreak();
		Vars.goal  = (Vars.motivation + Vars.physicalShape + Vars.happiness + (100 - Vars.hunger) + (100 - Vars.tiredness))/5;
		yield break;
	}


	// .............
	// #5: Hello Van

	void passage5_Init()
	{
		this.Passages[@"Hello Van"] = new StoryPassage(@"Hello Van", new string[]{  }, passage5_Main);
	}

	IStoryThread passage5_Main()
	{
		Vars.playerName  = "Van";
		yield return lineBreak();
		Vars.motivation  = 70;
		yield return lineBreak();
		Vars.physicalShape  = 30;
		yield return lineBreak();
		Vars.happiness  = 50;
		yield return lineBreak();
		Vars.hunger  = 40;
		yield return lineBreak();
		Vars.tiredness  = 40;
		yield return lineBreak();
		yield return lineBreak();
		Vars.goal  = (Vars.motivation + Vars.physicalShape + Vars.happiness + (100 - Vars.hunger) + (100 - Vars.tiredness))/5;
		yield break;
	}


	// .............
	// #6: Hello Dembalio

	void passage6_Init()
	{
		this.Passages[@"Hello Dembalio"] = new StoryPassage(@"Hello Dembalio", new string[]{  }, passage6_Main);
	}

	IStoryThread passage6_Main()
	{
		Vars.playerName  = "Dembalio";
		yield return lineBreak();
		Vars.motivation  = 50;
		yield return lineBreak();
		Vars.physicalShape  = 50;
		yield return lineBreak();
		Vars.happiness  = 50;
		yield return lineBreak();
		Vars.hunger  = 40;
		yield return lineBreak();
		Vars.tiredness  = 40;
		yield return lineBreak();
		yield return lineBreak();
		Vars.goal  = (Vars.motivation + Vars.physicalShape + Vars.happiness + (100 - Vars.hunger) + (100 - Vars.tiredness))/5;
		yield break;
	}


	// .............
	// #7: Player Resting

	void passage7_Init()
	{
		this.Passages[@"Player Resting"] = new StoryPassage(@"Player Resting", new string[]{ "activity", }, passage7_Main);
	}

	IStoryThread passage7_Main()
	{
		yield return text(" ");
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.tiredness >= 20) {
			Vars.tiredness  = Vars.tiredness - 20;
		}
		else {
			Vars.tiredness  = 0;
		}
		yield return lineBreak();
		if(Vars.physicalShape >= 5) {
			Vars.physicalShape  = Vars.physicalShape - 5;
		}
		else {
			Vars.physicalShape  = 0;
		}
		yield return lineBreak();
		if(Vars.hunger <= 90) {
			Vars.hunger  = Vars.hunger + 10;
		}
		else {
			Vars.hunger  = 100;
		}
		yield return lineBreak();
		Vars.flagNum  = 1;
		yield return lineBreak();
		Vars.fromScene  = "Player Resting";
		yield return lineBreak();
		yield return abort(goToPassage: "Calculate Goal");
		yield break;
	}


	// .............
	// #8: Player Workout

	void passage8_Init()
	{
		this.Passages[@"Player Workout"] = new StoryPassage(@"Player Workout", new string[]{ "activity", }, passage8_Main);
	}

	IStoryThread passage8_Main()
	{
		yield return lineBreak();
		if(Vars.boostRounds == 0) {
			Vars.isUpgrade  = false;
		}
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.tiredness <= 90) {
			Vars.tiredness  = Vars.tiredness + 10;
		}
		else {
			Vars.tiredness  = 100;
		}
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.isUpgrade == true) {
			if(Vars.physicalShape <= 70) {
				Vars.physicalShape  = Vars.physicalShape + 30;
			}
			else {
				Vars.physicalShape  = 100;
			}
		}
		else {
			if(Vars.physicalShape <= 80) {
				Vars.physicalShape  = Vars.physicalShape + 20;
			}
			else {
				Vars.physicalShape  = 100;
			}
		}
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.hunger <= 90) {
			Vars.hunger  = Vars.hunger + 10;
		}
		else {
			Vars.hunger  = 100;
		}
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.motivation <= 95) {
			Vars.motivation  = Vars.motivation + 5;
		}
		else {
			Vars.motivation  = 100;
		}
		yield return lineBreak();
		yield return text("	");
		yield return lineBreak();
		if(Vars.motivation > 70) {
			yield return text("I love working it out, I feel like I'm becoming a much better player!!");
			if(Vars.happiness <= 95) {
				Vars.happiness  = Vars.happiness + 5;
			}
			else {
				Vars.happiness  = 100;
			}
		}
		else {
			yield return text("I wish I could go out right now..");
			if(Vars.happiness >= 5) {
				Vars.happiness  = Vars.happiness - 5;
			}
			else {
				Vars.happiness  = 0;
			}
		}
		yield return lineBreak();
		yield return lineBreak();
		Vars.flagNum  = 2;
		yield return lineBreak();
		Vars.fromScene  = "Player Workout";
		yield return lineBreak();
		Vars.boostRounds  = Vars.boostRounds - 1;
		yield return lineBreak();
		yield return abort(goToPassage: "Calculate Goal");
		yield break;
	}


	// .............
	// #9: Player Practice

	void passage9_Init()
	{
		this.Passages[@"Player Practice"] = new StoryPassage(@"Player Practice", new string[]{ "activity", }, passage9_Main);
	}

	IStoryThread passage9_Main()
	{
		yield return lineBreak();
		if(Vars.physicalShape <= 90) {
			Vars.physicalShape  = Vars.physicalShape + 10;
		}
		else {
			Vars.physicalShape  = 100;
		}
		yield return lineBreak();
		if(Vars.motivation <= 90) {
			Vars.motivation  = Vars.motivation + 10;
		}
		else {
			Vars.motivation  = 100;
		}
		yield return lineBreak();
		yield return text("	");
		yield return lineBreak();
		if(Vars.physicalShape > 70) {
			yield return text("I could practice for days.. ");
			yield return lineBreak();
			if(Vars.tiredness <= 95) {
				Vars.tiredness  = Vars.tiredness + 5;
			}
			else {
				Vars.tiredness  = 100;
			}
			yield return lineBreak();
			if(Vars.hunger <= 95) {
				Vars.hunger  = Vars.hunger + 5;
			}
			else {
				Vars.hunger  = 100;
			}
		}
		else {
			yield return text("This practice is really hard..");
			yield return lineBreak();
			if(Vars.tiredness <= 90) {
				Vars.tiredness  = Vars.tiredness + 10;
			}
			else {
				Vars.tiredness  = 100;
			}
			yield return lineBreak();
			if(Vars.hunger <= 90) {
				Vars.hunger  = Vars.hunger + 10;
			}
			else {
				Vars.hunger  = 100;
			}
		}
		yield return lineBreak();
		yield return lineBreak();
		Vars.flagNum  = 3;
		yield return lineBreak();
		Vars.fromScene  = "Player Practice";
		yield return lineBreak();
		yield return abort(goToPassage: "Calculate Goal");
		yield break;
	}


	// .............
	// #10: Player Eating

	void passage10_Init()
	{
		this.Passages[@"Player Eating"] = new StoryPassage(@"Player Eating", new string[]{ "activity", }, passage10_Main);
	}

	IStoryThread passage10_Main()
	{
		yield return lineBreak();
		if(Vars.physicalShape >= 5) {
			Vars.physicalShape  = Vars.physicalShape - 5;
		}
		else {
			Vars.physicalShape  = 0;
		}
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.motivation <= 95) {
			Vars.motivation  = Vars.motivation + 5;
		}
		else {
			Vars.motivation  = 100;
		}
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.hunger >= 20) {
			Vars.hunger  = Vars.hunger - 20;
		}
		else {
			Vars.hunger  = 0;
		}
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.happiness <= 90) {
			Vars.happiness  = Vars.happiness + 10;
		}
		else {
			Vars.happiness  = 100;
		}
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.tiredness <= 95) {
			Vars.tiredness  = Vars.tiredness + 5;
		}
		else {
			Vars.tiredness  = 100;
		}
		yield return lineBreak();
		yield return text("	");
		yield return lineBreak();
		Vars.flagNum  = 4;
		yield return lineBreak();
		Vars.fromScene  = "Player Eating";
		yield return lineBreak();
		yield return abort(goToPassage: "Calculate Goal");
		yield break;
	}


	// .............
	// #11: Player Outing

	void passage11_Init()
	{
		this.Passages[@"Player Outing"] = new StoryPassage(@"Player Outing", new string[]{ "activity", }, passage11_Main);
	}

	IStoryThread passage11_Main()
	{
		yield return lineBreak();
		if(Vars.physicalShape >= 10) {
			Vars.physicalShape  = Vars.physicalShape - 10;
		}
		else {
			Vars.physicalShape  = 0;
		}
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.tiredness <= 95) {
			Vars.tiredness  = Vars.tiredness + 5;
		}
		else {
			Vars.tiredness  = 100;
		}
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.hunger <= 95) {
			Vars.hunger  = Vars.hunger + 5;
		}
		else {
			Vars.hunger  = 100;
		}
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.happiness <= 80) {
			Vars.happiness  = Vars.happiness + 20;
		}
		else {
			Vars.happiness  = 100;
		}
		yield return lineBreak();
		yield return lineBreak();
		Vars.flagNum  = 5;
		yield return lineBreak();
		Vars.fromScene  = "Player Outing";
		yield return lineBreak();
		yield return abort(goToPassage: "Calculate Goal");
		yield break;
	}


	// .............
	// #12: Calculate Goal

	void passage12_Init()
	{
		this.Passages[@"Calculate Goal"] = new StoryPassage(@"Calculate Goal", new string[]{ "goalCalculation", }, passage12_Main);
	}

	IStoryThread passage12_Main()
	{
		Vars.goal  = (Vars.motivation + Vars.physicalShape + Vars.happiness + (100 - Vars.hunger) + (100 - Vars.tiredness))/5;
		yield return lineBreak();
		yield return lineBreak();
		Vars.waitTime  = Vars.waitTime + 1;
		yield return lineBreak();
		if(Vars.isLoan == true) {
			Vars.loanRound  = Vars.loanRound + 1;
		}
		yield return lineBreak();
		if(Vars.goal > 95) {
			yield return abort(goToPassage: "End Game");
		}
		else if(Vars.goal < 10) {
			yield return abort(goToPassage: "Fired");
		}
		else if(Vars.loanRound > Vars.daysToReturn) {
			yield return abort(goToPassage: "Fired");
		}
		else {
			yield return abort(goToPassage: "Reset flags");
		}
		yield break;
	}


	// .............
	// #13: After Activity

	void passage13_Init()
	{
		this.Passages[@"After Activity"] = new StoryPassage(@"After Activity", new string[]{ "mainActivity", }, passage13_Main);
	}

	IStoryThread passage13_Main()
	{
		yield return text(Vars.playerName);
		yield return text(": ");
		yield return text(Vars.ScouterName);
		yield return text(" what would you like me to do now?");
		yield return lineBreak();
		Vars.fromScene  = "";
		yield return lineBreak();
		if(Vars.isTired == false) {
			yield return link("Get some rest..", "Player Resting", null);
		}
		yield return lineBreak();
		if(Vars.isWorkout == false) {
			yield return link("Go workout..", "Player Workout", null);
		}
		yield return lineBreak();
		if(Vars.isPractice == false) {
			yield return link("Go practice..", "Player Practice", null);
		}
		yield return lineBreak();
		if(Vars.isEating == false) {
			yield return link("Go eat something..", "Player Eating", null);
		}
		yield return lineBreak();
		if(Vars.isOut == false) {
			yield return link("Go party!!", "Player Outing", null);
		}
		yield return lineBreak();
		if(Vars.canPlay == true) {
			yield return link("Game Time!", "Player Game", null);
		}
		yield return lineBreak();
		if(Vars.moneyAmount <= 0) {
			yield return link("I need a loan..", "Loan Money", null);
		}
		yield return lineBreak();
		if(Vars.isLoan == true) {
			yield return link("I need to see if I can pay back..", "Return Loan", null);
		}
		yield break;
	}


	// .............
	// #14: Reset flags

	void passage14_Init()
	{
		this.Passages[@"Reset flags"] = new StoryPassage(@"Reset flags", new string[]{  }, passage14_Main);
	}

	IStoryThread passage14_Main()
	{
		Vars.isTired  = false; Vars.isWorkout  = false; Vars.isPractice  = false; Vars.isEating  = false; Vars.isOut  = false;
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.flagNum == 1) {
			Vars.isTired  = true;
		}
		else if(Vars.flagNum == 2) {
			Vars.isWorkout  = true;
		}
		else if(Vars.flagNum == 3) {
			Vars.isPractice  = true;
		}
		else if(Vars.flagNum == 4) {
			Vars.isEating  = true;
		}
		else if(Vars.flagNum == 5) {
			Vars.isOut  = true;
		}
		yield return lineBreak();
		yield return lineBreak();
		yield return abort(goToPassage: "Calculate Play");
		yield break;
	}


	// .............
	// #15: Player Game

	void passage15_Init()
	{
		this.Passages[@"Player Game"] = new StoryPassage(@"Player Game", new string[]{ "game", }, passage15_Main);
	}

	IStoryThread passage15_Main()
	{
		Vars.waitTime  = 0;
		yield return lineBreak();
		Vars.moneyAmount  = Vars.moneyAmount - 100;
		yield return lineBreak();
		yield return lineBreak();
		Vars.rcOne  = macros1.random(1, 100);
		yield return lineBreak();
		Vars.rcTwo  = macros1.random(1, 100);
		yield return lineBreak();
		Vars.rcThree  = macros1.random(1, 100);
		yield return lineBreak();
		Vars.avrChance  = (Vars.rcOne + Vars.rcTwo + Vars.rcThree)/3;
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.goal > Vars.avrChance) {
			Vars.isWin  = true;
		}
		else {
			Vars.isWin  = false;
		}
		yield return lineBreak();
		yield return lineBreak();
		Vars.fromScene  = "Player Game";
		yield break;
	}


	// .............
	// #16: Calculate Play

	void passage16_Init()
	{
		this.Passages[@"Calculate Play"] = new StoryPassage(@"Calculate Play", new string[]{  }, passage16_Main);
	}

	IStoryThread passage16_Main()
	{
		if((Vars.motivation >= 70) && (Vars.waitTime > 3) && (Vars.moneyAmount >= 100)) {
			Vars.canPlay  = true;
		}
		else {
			Vars.canPlay  = false;
		}
		yield break;
	}


	// .............
	// #17: Game Won

	void passage17_Init()
	{
		this.Passages[@"Game Won"] = new StoryPassage(@"Game Won", new string[]{ "game", }, passage17_Main);
	}

	IStoryThread passage17_Main()
	{
		yield return text("Congrutalions!! you've won the match!!");
		yield return lineBreak();
		yield return lineBreak();
		Vars.moneyAmount  = Vars.moneyAmount + 400;
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.motivation <= 90) {
			Vars.motivation  = Vars.motivation + 10;
		}
		else {
			Vars.motivation  = 100;
		}
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.happiness <= 85) {
			Vars.happiness  = Vars.happiness + 15;
		}
		else {
			Vars.happiness  = 100;
		}
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.physicalShape <= 90) {
			Vars.physicalShape  = Vars.physicalShape + 10;
		}
		else {
			Vars.physicalShape  = 100;
		}
		yield return lineBreak();
		yield return lineBreak();
		yield return abort(goToPassage: "Calculate Goal");
		yield break;
	}


	// .............
	// #18: Loan Money

	void passage18_Init()
	{
		this.Passages[@"Loan Money"] = new StoryPassage(@"Loan Money", new string[]{  }, passage18_Main);
	}

	IStoryThread passage18_Main()
	{
		Vars.waitTime  = Vars.waitTime + 1;
		yield return lineBreak();
		Vars.loanRound  = 0;
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Banker: Do you want a loan?");
		yield return lineBreak();
		yield return text(Vars.ScouterName);
		yield return text(": Yes, please help me out..");
		yield return lineBreak();
		yield return text("Banker: Here are your options:");
		yield return lineBreak();
		yield return link("400 dollars, return 600 after 10 rounds ", "High Loan", null);
		yield return lineBreak();
		yield return link("200 dollars, return 300 after 6 rounds ", "Medium Loan", null);
		yield return lineBreak();
		yield return link("100 dollars, return 150 after 4 rounds ", "Low Loan", null);
		yield break;
	}


	// .............
	// #19: Game Lost

	void passage19_Init()
	{
		this.Passages[@"Game Lost"] = new StoryPassage(@"Game Lost", new string[]{  }, passage19_Main);
	}

	IStoryThread passage19_Main()
	{
		yield return text("You've lost the match.. too bad.. try harder next time..");
		yield return lineBreak();
		yield return lineBreak();
		Vars.moneyAmount  = Vars.moneyAmount - 200;
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.motivation >= 10) {
			Vars.motivation  = Vars.motivation - 10;
		}
		else {
			Vars.motivation  = 0;
		}
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.happiness >= 15) {
			Vars.happiness  = Vars.happiness - 15;
		}
		else {
			Vars.happiness  = 0;
		}
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.physicalShape <= 90) {
			Vars.physicalShape  = Vars.physicalShape + 10;
		}
		else {
			Vars.physicalShape  = 100;
		}
		yield return lineBreak();
		yield return lineBreak();
		yield return abort(goToPassage: "Calculate Goal");
		yield return text(" ");
		yield break;
	}


	// .............
	// #20: High Loan

	void passage20_Init()
	{
		this.Passages[@"High Loan"] = new StoryPassage(@"High Loan", new string[]{ "loan", }, passage20_Main);
	}

	IStoryThread passage20_Main()
	{
		Vars.moneyAmount  = Vars.moneyAmount + 400;
		yield return lineBreak();
		Vars.isLoan  = true;
		yield return lineBreak();
		Vars.daysToReturn  = 10;
		yield return lineBreak();
		yield return abort(goToPassage: "Calculate Goal");
		yield break;
	}


	// .............
	// #21: Low Loan

	void passage21_Init()
	{
		this.Passages[@"Low Loan"] = new StoryPassage(@"Low Loan", new string[]{ "loan", }, passage21_Main);
	}

	IStoryThread passage21_Main()
	{
		Vars.moneyAmount  = Vars.moneyAmount + 100;
		yield return lineBreak();
		Vars.daysToReturn  = 4;
		yield return lineBreak();
		yield return abort(goToPassage: "Calculate Goal");
		yield break;
	}


	// .............
	// #22: Medium Loan

	void passage22_Init()
	{
		this.Passages[@"Medium Loan"] = new StoryPassage(@"Medium Loan", new string[]{ "loan", }, passage22_Main);
	}

	IStoryThread passage22_Main()
	{
		Vars.moneyAmount  = Vars.moneyAmount + 200;
		yield return lineBreak();
		Vars.daysToReturn  = 6;
		yield return lineBreak();
		yield return abort(goToPassage: "Calculate Goal");
		yield break;
	}


	// .............
	// #23: Return Loan

	void passage23_Init()
	{
		this.Passages[@"Return Loan"] = new StoryPassage(@"Return Loan", new string[]{ "loan", }, passage23_Main);
	}

	IStoryThread passage23_Main()
	{
		yield return text("Banker: Hey, let me calculate the amount you need to pay back..");
		yield return lineBreak();
		yield return lineBreak();
		if(Vars.daysToReturn == 10) {
			Vars.amountToReturn  = 400 - (10*(Vars.daysToReturn - Vars.loanRound));
		}
		else if(Vars.daysToReturn == 6) {
			Vars.amountToReturn  = 200 - (10*(Vars.daysToReturn - Vars.loanRound));
		}
		else if(Vars.daysToReturn == 4) {
			Vars.amountToReturn  = 100 - (10*(Vars.daysToReturn - Vars.loanRound));
		}
		yield return lineBreak();
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Banker: The amount you need to pay is ");
		yield return text(Vars.amountToReturn);
		yield return text("..");
		yield return lineBreak();
		if(Vars.amountToReturn <= Vars.moneyAmount) {
			yield return text("Loan has been Payed.. ");
			Vars.moneyAmount  = Vars.moneyAmount - Vars.amountToReturn; Vars.isLoan  = false;
		}
		else {
			yield return text("You don't have enough money..");
		}
		yield return lineBreak();
		yield return lineBreak();
		yield return abort(goToPassage: "Calculate Goal");
		yield break;
	}


	// .............
	// #24: End Game

	void passage24_Init()
	{
		this.Passages[@"End Game"] = new StoryPassage(@"End Game", new string[]{ "endGame", }, passage24_Main);
	}

	IStoryThread passage24_Main()
	{
		yield return text("You've finished the game successfully! well done!");
		yield break;
	}


	// .............
	// #25: Fired

	void passage25_Init()
	{
		this.Passages[@"Fired"] = new StoryPassage(@"Fired", new string[]{ "endGame", }, passage25_Main);
	}

	IStoryThread passage25_Main()
	{
		yield return text("You just got fired.. Sorry to hear.. Try again next time..");
		yield break;
	}


	// .............
	// #26: Hello Player

	void passage26_Init()
	{
		this.Passages[@"Hello Player"] = new StoryPassage(@"Hello Player", new string[]{ "meetPlayer", }, passage26_Main);
	}

	IStoryThread passage26_Main()
	{
		yield return text("Hi ");
		yield return text(Vars.playerName);
		yield return text(", it's ");
		yield return text(Vars.ScouterName);
		yield return text(" How are you today?");
		yield return lineBreak();
		yield return text(Vars.playerName);
		yield return text(": I'm Great! can't wait to start our journey together!");
		yield return lineBreak();
		yield return text(Vars.ScouterName);
		yield return text(": Good, Me Too! So what's the plan what would you like to do first?");
		yield return lineBreak();
		yield return text(Vars.playerName);
		yield return text(": I was debating between these options, let me know what you think!");
		yield return lineBreak();
		yield return lineBreak();
		yield return link("Get some rest.. ", "Player Resting", null);
		yield return lineBreak();
		yield return link("Go workout.. ", "Player Workout", null);
		yield return lineBreak();
		yield return link("Go practice.. ", "Player Practice", null);
		yield return lineBreak();
		yield return link("Go eat something.. ", "Player Eating", null);
		yield return lineBreak();
		yield return link("Go party!! ", "Player Outing", null);
		yield break;
	}


	// .............
	// #27: Introduction

	void passage27_Init()
	{
		this.Passages[@"Introduction"] = new StoryPassage(@"Introduction", new string[]{  }, passage27_Main);
	}

	IStoryThread passage27_Main()
	{
		Vars.ScouterName  = "John";
		yield return lineBreak();
		Vars.Helper  = "Secretary:";
		yield return lineBreak();
		yield return lineBreak();
		yield return text(Vars.Helper);
		yield return text(" Hi ");
		yield return text(Vars.ScouterName);
		yield return text("! I wanted to wish you good luck on your first day as an official scouter! Lets have a quick reminder on what's your mission as a scouter. First of all you'll have to recruit a new player, after you recruit the player you'll be able to guide your client through different activities. make sure you satisfy your client's needs.. if you're good enough you'll be able to achieve the goal and finish a successfull career with your client, be sloppy and you might find yourself getting fired..");
		yield return lineBreak();
		yield return text("Don't forget to let your client play matches once in a while so you can gain money - if he wins..");
		yield return lineBreak();
		yield return text("Do you understand your goal?");
		yield return lineBreak();
		yield return link("yes, let's do this! ", "First Call", null);
		yield return lineBreak();
		yield return link("no, please explain to me a little more..", "Further Explanation", null);
		yield break;
	}


	// .............
	// #28: Further Explanation

	void passage28_Init()
	{
		this.Passages[@"Further Explanation"] = new StoryPassage(@"Further Explanation", new string[]{  }, passage28_Main);
	}

	IStoryThread passage28_Main()
	{
		yield return text(Vars.Helper);
		yield return text(" Let's go into a little more details..");
		yield return lineBreak();
		yield return text("First - you have to recruit a player.");
		yield return lineBreak();
		yield return text("Second - After you recruit a player you'll see the player has 5 different needs that you'll want to satisfy.. while positive needs you'll want to increase and negative needs you'll want to decrease..");
		yield return lineBreak();
		yield return text("Third - You can see at any given point what the goal score is, the player needs have an immediate effect on the goal score. get a high enough score and you finish your career successfully, reach a very low goal score and you'll get fired.");
		yield return lineBreak();
		yield return text("Fourth - You can send your player on different activities which by turn will satisfy different needs depeneding on the activity chosen.");
		yield return lineBreak();
		yield return text("Additionaly - every once in a while you'll be able to send your player on a match - win the match and you gain money, lose the match and you lose money.");
		yield return lineBreak();
		yield return link("Ok, I get it now.. ", "First Call", null);
		yield break;
	}


	// .............
	// #29: Interaction Trainer

	void passage29_Init()
	{
		this.Passages[@"Interaction Trainer"] = new StoryPassage(@"Interaction Trainer", new string[]{  }, passage29_Main);
	}

	IStoryThread passage29_Main()
	{
		if(Vars.waitTime < 3) {
			yield return text("Hi, this feature isn't available yet.. ");
			yield return text(Vars.playerName);
			yield return text(" needs more training..");
		}
		else {
			yield return text("Hi would you like to improve your players training program?");
			yield return link("Yes, please.. ", "Yes Intercation", null);
			yield return lineBreak();
			yield return link("No, thanks.. ", "After Activity", null);
		}
		yield return lineBreak();
		yield return lineBreak();
		yield break;
	}


	// .............
	// #30: Yes Intercation

	void passage30_Init()
	{
		this.Passages[@"Yes Intercation"] = new StoryPassage(@"Yes Intercation", new string[]{  }, passage30_Main);
	}

	IStoryThread passage30_Main()
	{
		Vars.moneyAmount  = Vars.moneyAmount - 100;
		yield return lineBreak();
		Vars.isUpgrade  = true;
		yield return lineBreak();
		Vars.boostRounds  = 3;
		yield return lineBreak();
		yield return lineBreak();
		yield return text("Training program purchased - the program will hold for 3 workouts..");
		yield return lineBreak();
		yield return abort(goToPassage: "After Activity");
		yield break;
	}


}