﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SM4Character
{

	public int ID;
	public string path;

	public string regionCurrent;
	public string regionLast;
	public string areaCurrent;
	public string areaLast;
	public string locationCurrent;
	public string locationLast;



    public Race race;
    public CharacterName nameChar;
    public GeneralCharacter general;
    public Gender gender; // 0 none, 1 male, 2 female, 3 futa, others look sdk
    public Vitals vitals;
    public TextInserts text;
    public Stats stats;
    public SexSkills sexSkills;
    public Skills skills;

    public Viginity virginity;
    public TrainingTypes training;
    public Owner owner;

    public Parentclass father;
    public Parentclass mother;

	// public Dress dressCurrent = new Dress();
	// public Dress dressLast = new Dress(); 
	// public List<Dress> dresses = new List<Dress>();
 //    public List<Item> equipped = new List<Item>();
 //    public List<Item> inventory = new List<Item>();
 //    public List<ItemUsed> usedItems = new List<ItemUsed>();

	//public int[] varInt = new int[100];
	//public string[] varString = new string[100];
	//public bool[] varBool = new bool[200];
	public List<int> listOfInt = new List<int>();
	public List<string> listOfString = new List<string>();
	public List<bool> listOfBool = new List<bool>();

	public int CurrentAge(int dateCurrent, int daysInAYear)
	{
		int age = (dateCurrent - general.birthday) / daysInAYear;
		general.age = age;
		return age;
	}
	public bool IsBirthday(int dateCurrent, int daysInAYear)
	{
		if( ((dateCurrent - general.birthday) % daysInAYear) == 0)
		{ return true; }
		else 
		{ return false; }
	}

	public void UpdateLocation(string newLocation)
	{
		locationLast = locationCurrent;
		locationCurrent = newLocation;
	}

    public virtual object GetItemByValue(string valueLookup)
    {
        switch (valueLookup.ToLower())
        {
            case "id":
                return this.ID;
            case "path":
                return this.path;
            case "regioncurrent":
                return this.regionCurrent;
            case "regionlast":
                return this.regionLast;
            case "areacurrent":
                return this.areaCurrent;
            case "arealast":
                return this.areaLast;
            case "locationcurrent":
                return this.locationCurrent;
            case "locationlast":
                return this.locationLast;
            case "race-fertility":
                return this.race.fertility;
            case "race-racename":
                return this.race.raceName;
            case "race-raceid":
                return this.race.raceID;
            case "race-eyes-number":
                return this.race.eyes.number;
            case "race-eyes-type":
                return this.race.eyes.type;
            case "race-eyes-pupilform":
                return this.race.eyes.pupilForm;
            case "race-eyes-nightvision":
                return this.race.eyes.nightVision;
            case "race-ears-shape":
                return this.race.ears.shape;
            case "race-ears-size":
                return this.race.ears.size;
            case "race-ears-lenght":
                return this.race.ears.lenght;
            case "race-ears-texture":
                return this.race.ears.texture;
            case "race-averagebodysize":
                return this.race.averageBodySize;
            case "race-legs-number":
                return this.race.legs.number;
            case "race-legs-lenght":
                return this.race.legs.lenght;
            case "race-legs-thickness":
                return this.race.legs.thickness;
            case "race-legs-texture":
                return this.race.legs.texture;
            case "race-arms-number":
                return this.race.arms.number;
            case "race-arms-lenght":
                return this.race.arms.lenght;
            case "race-arms-thickness":
                return this.race.arms.thickness;
            case "race-arms-texture":
                return this.race.arms.texture;
            case "race-wings-number":
                return this.race.wings.number;
            case "race-wings-lenght":
                return this.race.wings.lenght;
            case "race-wings-thickness":
                return this.race.wings.thickness;
            case "race-wings-texture":
                return this.race.wings.texture;
            case "race-racetype":
                return this.race.raceType;
            case "namechar-first":
                return this.nameChar.first;
            case "namechar-middle":
                return this.nameChar.middle;
            case "namechar-last":
                return this.nameChar.last;
            case "namechar-prefix":
                return this.nameChar.prefix;
            case "namechar-title":
                return this.nameChar.title;
            case "namechar-nickname":
                return this.nameChar.nickname;
            case "namechar-slavename":
                return this.nameChar.slavename;
            case "namechar-nameborn":
                return this.nameChar.nameBorn;
            case "general-sexactsok":
                return this.general.sexActsOK;
            case "general-birthday":
                return this.general.birthday;
            case "general-age":
                return this.general.age;
            case "general-description":
                return this.general.description;
            case "general-goldearned":
                return this.general.goldEarned;
            case "general-goldowned":
                return this.general.goldOwned;
            case "general-badgirl":
                return this.general.badGirl;
            case "general-behaving":
                return this.general.behaving;
            case "general-loyalty":
                return this.general.loyalty;
            case "general-attitude":
                return this.general.attitude;
            case "general-loveaccepted":
                return this.general.loveAccepted;
            case "general-isnaked":
                return this.general.isNaked;
            case "general-loli":
                return this.general.loli;
            case "general-noble":
                return this.general.noble;
            case "gender-current":
                return this.gender.current;
            case "gender-last":
                return this.gender.last;
            case "gender-born":
                return this.gender.born;
            case "vitals-height":
                return this.vitals.height;
            case "vitals-weight":
                return this.vitals.weight;
            case "vitals-bust-min":
                return this.vitals.bust.min;
            case "vitals-bust-max":
                return this.vitals.bust.max;
            case "vitals-bust-start":
                return this.vitals.bust.start;
            case "vitals-bust-last":
                return this.vitals.bust.last;
            case "vitals-bust-current":
                return this.vitals.bust.current;
            case "vitals-underbustsize":
                return this.vitals.underBustSize;
            case "vitals-aurola-min":
                return this.vitals.aurola.min;
            case "vitals-aurola-max":
                return this.vitals.aurola.max;
            case "vitals-aurola-start":
                return this.vitals.aurola.start;
            case "vitals-aurola-last":
                return this.vitals.aurola.last;
            case "vitals-aurola-current":
                return this.vitals.aurola.current;
            case "vitals-cupsize":
                return this.vitals.cupSize;
            case "vitals-cock-hascock":
                return this.vitals.cock.hasCock;
            case "vitals-cock-size-min":
                return this.vitals.cock.size.min;
            case "vitals-cock-size-max":
                return this.vitals.cock.size.max;
            case "vitals-cock-size-start":
                return this.vitals.cock.size.start;
            case "vitals-cock-size-last":
                return this.vitals.cock.size.last;
            case "vitals-cock-size-current":
                return this.vitals.cock.size.current;
            case "vitals-cock-grid-min":
                return this.vitals.cock.grid.min;
            case "vitals-cock-grid-max":
                return this.vitals.cock.grid.max;
            case "vitals-cock-grid-start":
                return this.vitals.cock.grid.start;
            case "vitals-cock-grid-last":
                return this.vitals.cock.grid.last;
            case "vitals-cock-grid-current":
                return this.vitals.cock.grid.current;
            case "vitals-cock-type":
                return this.vitals.cock.type;
            case "vitals-cock-typevar-min":
                return this.vitals.cock.typeVar.min;
            case "vitals-cock-typevar-max":
                return this.vitals.cock.typeVar.max;
            case "vitals-cock-typevar-start":
                return this.vitals.cock.typeVar.start;
            case "vitals-cock-typevar-last":
                return this.vitals.cock.typeVar.last;
            case "vitals-cock-typevar-current":
                return this.vitals.cock.typeVar.current;
            case "vitals-testicles-min":
                return this.vitals.testicles.min;
            case "vitals-testicles-max":
                return this.vitals.testicles.max;
            case "vitals-testicles-start":
                return this.vitals.testicles.start;
            case "vitals-testicles-last":
                return this.vitals.testicles.last;
            case "vitals-testicles-current":
                return this.vitals.testicles.current;
            case "vitals-cum-volume-min":
                return this.vitals.cum.volume.min;
            case "vitals-cum-volume-max":
                return this.vitals.cum.volume.max;
            case "vitals-cum-volume-start":
                return this.vitals.cum.volume.start;
            case "vitals-cum-volume-last":
                return this.vitals.cum.volume.last;
            case "vitals-cum-volume-current":
                return this.vitals.cum.volume.current;
            case "vitals-cum-fertility":
                return this.vitals.cum.fertility;
            case "vitals-clit-min":
                return this.vitals.clit.min;
            case "vitals-clit-max":
                return this.vitals.clit.max;
            case "vitals-clit-start":
                return this.vitals.clit.start;
            case "vitals-clit-last":
                return this.vitals.clit.last;
            case "vitals-clit-current":
                return this.vitals.clit.current;
            case "vitals-haspussy":
                return this.vitals.hasPussy;
            case "vitals-pussy-min":
                return this.vitals.pussy.min;
            case "vitals-pussy-max":
                return this.vitals.pussy.max;
            case "vitals-pussy-start":
                return this.vitals.pussy.start;
            case "vitals-pussy-last":
                return this.vitals.pussy.last;
            case "vitals-pussy-current":
                return this.vitals.pussy.current;
            case "vitals-pussygrid-min":
                return this.vitals.pussyGrid.min;
            case "vitals-pussygrid-max":
                return this.vitals.pussyGrid.max;
            case "vitals-pussygrid-start":
                return this.vitals.pussyGrid.start;
            case "vitals-pussygrid-last":
                return this.vitals.pussyGrid.last;
            case "vitals-pussygrid-current":
                return this.vitals.pussyGrid.current;
            case "vitals-waist-min":
                return this.vitals.waist.min;
            case "vitals-waist-max":
                return this.vitals.waist.max;
            case "vitals-waist-start":
                return this.vitals.waist.start;
            case "vitals-waist-last":
                return this.vitals.waist.last;
            case "vitals-waist-current":
                return this.vitals.waist.current;
            case "vitals-throat-min":
                return this.vitals.throat.min;
            case "vitals-throat-max":
                return this.vitals.throat.max;
            case "vitals-throat-start":
                return this.vitals.throat.start;
            case "vitals-throat-last":
                return this.vitals.throat.last;
            case "vitals-throat-current":
                return this.vitals.throat.current;
            case "vitals-bloodtype":
                return this.vitals.bloodType;
            case "text-itheshe":
                return this.text.itHeShe;
            case "text-ithimher":
                return this.text.itHimHer;
            case "text-itshisher":
                return this.text.itsHisHer;
            case "stats-agility-min":
                return this.stats.agility.min;
            case "stats-agility-max":
                return this.stats.agility.max;
            case "stats-agility-start":
                return this.stats.agility.start;
            case "stats-agility-last":
                return this.stats.agility.last;
            case "stats-agility-current":
                return this.stats.agility.current;
            case "stats-agility-modifier":
                return this.stats.agility.modifier;
            case "stats-blowjob-min":
                return this.stats.blowjob.min;
            case "stats-blowjob-max":
                return this.stats.blowjob.max;
            case "stats-blowjob-start":
                return this.stats.blowjob.start;
            case "stats-blowjob-last":
                return this.stats.blowjob.last;
            case "stats-blowjob-current":
                return this.stats.blowjob.current;
            case "stats-blowjob-modifier":
                return this.stats.blowjob.modifier;
            case "stats-charisma-min":
                return this.stats.charisma.min;
            case "stats-charisma-max":
                return this.stats.charisma.max;
            case "stats-charisma-start":
                return this.stats.charisma.start;
            case "stats-charisma-last":
                return this.stats.charisma.last;
            case "stats-charisma-current":
                return this.stats.charisma.current;
            case "stats-charisma-modifier":
                return this.stats.charisma.modifier;
            case "stats-corruption-min":
                return this.stats.corruption.min;
            case "stats-corruption-max":
                return this.stats.corruption.max;
            case "stats-corruption-start":
                return this.stats.corruption.start;
            case "stats-corruption-last":
                return this.stats.corruption.last;
            case "stats-corruption-current":
                return this.stats.corruption.current;
            case "stats-corruption-modifier":
                return this.stats.corruption.modifier;
            case "stats-constitution-min":
                return this.stats.constitution.min;
            case "stats-constitution-max":
                return this.stats.constitution.max;
            case "stats-constitution-start":
                return this.stats.constitution.start;
            case "stats-constitution-last":
                return this.stats.constitution.last;
            case "stats-constitution-current":
                return this.stats.constitution.current;
            case "stats-constitution-modifier":
                return this.stats.constitution.modifier;
            case "stats-cooking-min":
                return this.stats.cooking.min;
            case "stats-cooking-max":
                return this.stats.cooking.max;
            case "stats-cooking-start":
                return this.stats.cooking.start;
            case "stats-cooking-last":
                return this.stats.cooking.last;
            case "stats-cooking-current":
                return this.stats.cooking.current;
            case "stats-cooking-modifier":
                return this.stats.cooking.modifier;
            case "stats-cleaning-min":
                return this.stats.cleaning.min;
            case "stats-cleaning-max":
                return this.stats.cleaning.max;
            case "stats-cleaning-start":
                return this.stats.cleaning.start;
            case "stats-cleaning-last":
                return this.stats.cleaning.last;
            case "stats-cleaning-current":
                return this.stats.cleaning.current;
            case "stats-cleaning-modifier":
                return this.stats.cleaning.modifier;
            case "stats-conversation-min":
                return this.stats.conversation.min;
            case "stats-conversation-max":
                return this.stats.conversation.max;
            case "stats-conversation-start":
                return this.stats.conversation.start;
            case "stats-conversation-last":
                return this.stats.conversation.last;
            case "stats-conversation-current":
                return this.stats.conversation.current;
            case "stats-conversation-modifier":
                return this.stats.conversation.modifier;
            case "stats-dominance-min":
                return this.stats.dominance.min;
            case "stats-dominance-max":
                return this.stats.dominance.max;
            case "stats-dominance-start":
                return this.stats.dominance.start;
            case "stats-dominance-last":
                return this.stats.dominance.last;
            case "stats-dominance-current":
                return this.stats.dominance.current;
            case "stats-dominance-modifier":
                return this.stats.dominance.modifier;
            case "stats-dexterity-min":
                return this.stats.dexterity.min;
            case "stats-dexterity-max":
                return this.stats.dexterity.max;
            case "stats-dexterity-start":
                return this.stats.dexterity.start;
            case "stats-dexterity-last":
                return this.stats.dexterity.last;
            case "stats-dexterity-current":
                return this.stats.dexterity.current;
            case "stats-dexterity-modifier":
                return this.stats.dexterity.modifier;
            case "stats-fuck-min":
                return this.stats.fuck.min;
            case "stats-fuck-max":
                return this.stats.fuck.max;
            case "stats-fuck-start":
                return this.stats.fuck.start;
            case "stats-fuck-last":
                return this.stats.fuck.last;
            case "stats-fuck-current":
                return this.stats.fuck.current;
            case "stats-fuck-modifier":
                return this.stats.fuck.modifier;
            case "stats-intelligence-min":
                return this.stats.intelligence.min;
            case "stats-intelligence-max":
                return this.stats.intelligence.max;
            case "stats-intelligence-start":
                return this.stats.intelligence.start;
            case "stats-intelligence-last":
                return this.stats.intelligence.last;
            case "stats-intelligence-current":
                return this.stats.intelligence.current;
            case "stats-intelligence-modifier":
                return this.stats.intelligence.modifier;
            case "stats-joy-min":
                return this.stats.joy.min;
            case "stats-joy-max":
                return this.stats.joy.max;
            case "stats-joy-start":
                return this.stats.joy.start;
            case "stats-joy-last":
                return this.stats.joy.last;
            case "stats-joy-current":
                return this.stats.joy.current;
            case "stats-joy-modifier":
                return this.stats.joy.modifier;
            case "stats-libido-min":
                return this.stats.libido.min;
            case "stats-libido-max":
                return this.stats.libido.max;
            case "stats-libido-start":
                return this.stats.libido.start;
            case "stats-libido-last":
                return this.stats.libido.last;
            case "stats-libido-current":
                return this.stats.libido.current;
            case "stats-libido-modifier":
                return this.stats.libido.modifier;
            case "stats-love-min":
                return this.stats.love.min;
            case "stats-love-max":
                return this.stats.love.max;
            case "stats-love-start":
                return this.stats.love.start;
            case "stats-love-last":
                return this.stats.love.last;
            case "stats-love-current":
                return this.stats.love.current;
            case "stats-love-modifier":
                return this.stats.love.modifier;
            case "stats-mind-min":
                return this.stats.mind.min;
            case "stats-mind-max":
                return this.stats.mind.max;
            case "stats-mind-start":
                return this.stats.mind.start;
            case "stats-mind-last":
                return this.stats.mind.last;
            case "stats-mind-current":
                return this.stats.mind.current;
            case "stats-mind-modifier":
                return this.stats.mind.modifier;
            case "stats-morality-min":
                return this.stats.morality.min;
            case "stats-morality-max":
                return this.stats.morality.max;
            case "stats-morality-start":
                return this.stats.morality.start;
            case "stats-morality-last":
                return this.stats.morality.last;
            case "stats-morality-current":
                return this.stats.morality.current;
            case "stats-morality-modifier":
                return this.stats.morality.modifier;
            case "stats-nymphomania-min":
                return this.stats.nymphomania.min;
            case "stats-nymphomania-max":
                return this.stats.nymphomania.max;
            case "stats-nymphomania-start":
                return this.stats.nymphomania.start;
            case "stats-nymphomania-last":
                return this.stats.nymphomania.last;
            case "stats-nymphomania-current":
                return this.stats.nymphomania.current;
            case "stats-nymphomania-modifier":
                return this.stats.nymphomania.modifier;
            case "stats-obedience-min":
                return this.stats.obedience.min;
            case "stats-obedience-max":
                return this.stats.obedience.max;
            case "stats-obedience-start":
                return this.stats.obedience.start;
            case "stats-obedience-last":
                return this.stats.obedience.last;
            case "stats-obedience-current":
                return this.stats.obedience.current;
            case "stats-obedience-modifier":
                return this.stats.obedience.modifier;
            case "stats-refinement-min":
                return this.stats.refinement.min;
            case "stats-refinement-max":
                return this.stats.refinement.max;
            case "stats-refinement-start":
                return this.stats.refinement.start;
            case "stats-refinement-last":
                return this.stats.refinement.last;
            case "stats-refinement-current":
                return this.stats.refinement.current;
            case "stats-refinement-modifier":
                return this.stats.refinement.modifier;
            case "stats-reputation-min":
                return this.stats.reputation.min;
            case "stats-reputation-max":
                return this.stats.reputation.max;
            case "stats-reputation-start":
                return this.stats.reputation.start;
            case "stats-reputation-last":
                return this.stats.reputation.last;
            case "stats-reputation-current":
                return this.stats.reputation.current;
            case "stats-reputation-modifier":
                return this.stats.reputation.modifier;
            case "stats-sensibility-min":
                return this.stats.sensibility.min;
            case "stats-sensibility-max":
                return this.stats.sensibility.max;
            case "stats-sensibility-start":
                return this.stats.sensibility.start;
            case "stats-sensibility-last":
                return this.stats.sensibility.last;
            case "stats-sensibility-current":
                return this.stats.sensibility.current;
            case "stats-sensibility-modifier":
                return this.stats.sensibility.modifier;
            case "stats-strenght-min":
                return this.stats.strenght.min;
            case "stats-strenght-max":
                return this.stats.strenght.max;
            case "stats-strenght-start":
                return this.stats.strenght.start;
            case "stats-strenght-last":
                return this.stats.strenght.last;
            case "stats-strenght-current":
                return this.stats.strenght.current;
            case "stats-strenght-modifier":
                return this.stats.strenght.modifier;
            case "stats-submission-min":
                return this.stats.submission.min;
            case "stats-submission-max":
                return this.stats.submission.max;
            case "stats-submission-start":
                return this.stats.submission.start;
            case "stats-submission-last":
                return this.stats.submission.last;
            case "stats-submission-current":
                return this.stats.submission.current;
            case "stats-submission-modifier":
                return this.stats.submission.modifier;
            case "stats-temperament-min":
                return this.stats.temperament.min;
            case "stats-temperament-max":
                return this.stats.temperament.max;
            case "stats-temperament-start":
                return this.stats.temperament.start;
            case "stats-temperament-last":
                return this.stats.temperament.last;
            case "stats-temperament-current":
                return this.stats.temperament.current;
            case "stats-temperament-modifier":
                return this.stats.temperament.modifier;
            case "stats-tiredness-min":
                return this.stats.tiredness.min;
            case "stats-tiredness-max":
                return this.stats.tiredness.max;
            case "stats-tiredness-start":
                return this.stats.tiredness.start;
            case "stats-tiredness-last":
                return this.stats.tiredness.last;
            case "stats-tiredness-current":
                return this.stats.tiredness.current;
            case "stats-tiredness-modifier":
                return this.stats.tiredness.modifier;
            case "sexskills-anal-min":
                return this.sexSkills.anal.min;
            case "sexskills-anal-max":
                return this.sexSkills.anal.max;
            case "sexskills-anal-start":
                return this.sexSkills.anal.start;
            case "sexskills-anal-last":
                return this.sexSkills.anal.last;
            case "sexskills-anal-current":
                return this.sexSkills.anal.current;
            case "sexskills-anal-modifier":
                return this.sexSkills.anal.modifier;
            case "sexskills-blowjob-min":
                return this.sexSkills.blowjob.min;
            case "sexskills-blowjob-max":
                return this.sexSkills.blowjob.max;
            case "sexskills-blowjob-start":
                return this.sexSkills.blowjob.start;
            case "sexskills-blowjob-last":
                return this.sexSkills.blowjob.last;
            case "sexskills-blowjob-current":
                return this.sexSkills.blowjob.current;
            case "sexskills-blowjob-modifier":
                return this.sexSkills.blowjob.modifier;
            case "sexskills-bondage-min":
                return this.sexSkills.bondage.min;
            case "sexskills-bondage-max":
                return this.sexSkills.bondage.max;
            case "sexskills-bondage-start":
                return this.sexSkills.bondage.start;
            case "sexskills-bondage-last":
                return this.sexSkills.bondage.last;
            case "sexskills-bondage-current":
                return this.sexSkills.bondage.current;
            case "sexskills-bondage-modifier":
                return this.sexSkills.bondage.modifier;
            case "sexskills-cumbath-min":
                return this.sexSkills.cumBath.min;
            case "sexskills-cumbath-max":
                return this.sexSkills.cumBath.max;
            case "sexskills-cumbath-start":
                return this.sexSkills.cumBath.start;
            case "sexskills-cumbath-last":
                return this.sexSkills.cumBath.last;
            case "sexskills-cumbath-current":
                return this.sexSkills.cumBath.current;
            case "sexskills-cumbath-modifier":
                return this.sexSkills.cumBath.modifier;
            case "sexskills-dildo-min":
                return this.sexSkills.dildo.min;
            case "sexskills-dildo-max":
                return this.sexSkills.dildo.max;
            case "sexskills-dildo-start":
                return this.sexSkills.dildo.start;
            case "sexskills-dildo-last":
                return this.sexSkills.dildo.last;
            case "sexskills-dildo-current":
                return this.sexSkills.dildo.current;
            case "sexskills-dildo-modifier":
                return this.sexSkills.dildo.modifier;
            case "sexskills-fuck-min":
                return this.sexSkills.fuck.min;
            case "sexskills-fuck-max":
                return this.sexSkills.fuck.max;
            case "sexskills-fuck-start":
                return this.sexSkills.fuck.start;
            case "sexskills-fuck-last":
                return this.sexSkills.fuck.last;
            case "sexskills-fuck-current":
                return this.sexSkills.fuck.current;
            case "sexskills-fuck-modifier":
                return this.sexSkills.fuck.modifier;
            case "sexskills-gangbang-min":
                return this.sexSkills.gangBang.min;
            case "sexskills-gangbang-max":
                return this.sexSkills.gangBang.max;
            case "sexskills-gangbang-start":
                return this.sexSkills.gangBang.start;
            case "sexskills-gangbang-last":
                return this.sexSkills.gangBang.last;
            case "sexskills-gangbang-current":
                return this.sexSkills.gangBang.current;
            case "sexskills-gangbang-modifier":
                return this.sexSkills.gangBang.modifier;
            case "sexskills-group-min":
                return this.sexSkills.group.min;
            case "sexskills-group-max":
                return this.sexSkills.group.max;
            case "sexskills-group-start":
                return this.sexSkills.group.start;
            case "sexskills-group-last":
                return this.sexSkills.group.last;
            case "sexskills-group-current":
                return this.sexSkills.group.current;
            case "sexskills-group-modifier":
                return this.sexSkills.group.modifier;
            case "sexskills-kiss-min":
                return this.sexSkills.kiss.min;
            case "sexskills-kiss-max":
                return this.sexSkills.kiss.max;
            case "sexskills-kiss-start":
                return this.sexSkills.kiss.start;
            case "sexskills-kiss-last":
                return this.sexSkills.kiss.last;
            case "sexskills-kiss-current":
                return this.sexSkills.kiss.current;
            case "sexskills-kiss-modifier":
                return this.sexSkills.kiss.modifier;
            case "sexskills-lendher-min":
                return this.sexSkills.lendHer.min;
            case "sexskills-lendher-max":
                return this.sexSkills.lendHer.max;
            case "sexskills-lendher-start":
                return this.sexSkills.lendHer.start;
            case "sexskills-lendher-last":
                return this.sexSkills.lendHer.last;
            case "sexskills-lendher-current":
                return this.sexSkills.lendHer.current;
            case "sexskills-lendher-modifier":
                return this.sexSkills.lendHer.modifier;
            case "sexskills-lesbian-min":
                return this.sexSkills.lesbian.min;
            case "sexskills-lesbian-max":
                return this.sexSkills.lesbian.max;
            case "sexskills-lesbian-start":
                return this.sexSkills.lesbian.start;
            case "sexskills-lesbian-last":
                return this.sexSkills.lesbian.last;
            case "sexskills-lesbian-current":
                return this.sexSkills.lesbian.current;
            case "sexskills-lesbian-modifier":
                return this.sexSkills.lesbian.modifier;
            case "sexskills-lick-min":
                return this.sexSkills.lick.min;
            case "sexskills-lick-max":
                return this.sexSkills.lick.max;
            case "sexskills-lick-start":
                return this.sexSkills.lick.start;
            case "sexskills-lick-last":
                return this.sexSkills.lick.last;
            case "sexskills-lick-current":
                return this.sexSkills.lick.current;
            case "sexskills-lick-modifier":
                return this.sexSkills.lick.modifier;
            case "sexskills-masturbate-min":
                return this.sexSkills.masturbate.min;
            case "sexskills-masturbate-max":
                return this.sexSkills.masturbate.max;
            case "sexskills-masturbate-start":
                return this.sexSkills.masturbate.start;
            case "sexskills-masturbate-last":
                return this.sexSkills.masturbate.last;
            case "sexskills-masturbate-current":
                return this.sexSkills.masturbate.current;
            case "sexskills-masturbate-modifier":
                return this.sexSkills.masturbate.modifier;
            case "sexskills-naked-min":
                return this.sexSkills.naked.min;
            case "sexskills-naked-max":
                return this.sexSkills.naked.max;
            case "sexskills-naked-start":
                return this.sexSkills.naked.start;
            case "sexskills-naked-last":
                return this.sexSkills.naked.last;
            case "sexskills-naked-current":
                return this.sexSkills.naked.current;
            case "sexskills-naked-modifier":
                return this.sexSkills.naked.modifier;
            case "sexskills-plug-min":
                return this.sexSkills.plug.min;
            case "sexskills-plug-max":
                return this.sexSkills.plug.max;
            case "sexskills-plug-start":
                return this.sexSkills.plug.start;
            case "sexskills-plug-last":
                return this.sexSkills.plug.last;
            case "sexskills-plug-current":
                return this.sexSkills.plug.current;
            case "sexskills-plug-modifier":
                return this.sexSkills.plug.modifier;
            case "sexskills-spank-min":
                return this.sexSkills.spank.min;
            case "sexskills-spank-max":
                return this.sexSkills.spank.max;
            case "sexskills-spank-start":
                return this.sexSkills.spank.start;
            case "sexskills-spank-last":
                return this.sexSkills.spank.last;
            case "sexskills-spank-current":
                return this.sexSkills.spank.current;
            case "sexskills-spank-modifier":
                return this.sexSkills.spank.modifier;
            case "sexskills-striptease-min":
                return this.sexSkills.stripTease.min;
            case "sexskills-striptease-max":
                return this.sexSkills.stripTease.max;
            case "sexskills-striptease-start":
                return this.sexSkills.stripTease.start;
            case "sexskills-striptease-last":
                return this.sexSkills.stripTease.last;
            case "sexskills-striptease-current":
                return this.sexSkills.stripTease.current;
            case "sexskills-striptease-modifier":
                return this.sexSkills.stripTease.modifier;
            case "sexskills-threesome-min":
                return this.sexSkills.threesome.min;
            case "sexskills-threesome-max":
                return this.sexSkills.threesome.max;
            case "sexskills-threesome-start":
                return this.sexSkills.threesome.start;
            case "sexskills-threesome-last":
                return this.sexSkills.threesome.last;
            case "sexskills-threesome-current":
                return this.sexSkills.threesome.current;
            case "sexskills-threesome-modifier":
                return this.sexSkills.threesome.modifier;
            case "sexskills-titsfuck-min":
                return this.sexSkills.titsFuck.min;
            case "sexskills-titsfuck-max":
                return this.sexSkills.titsFuck.max;
            case "sexskills-titsfuck-start":
                return this.sexSkills.titsFuck.start;
            case "sexskills-titsfuck-last":
                return this.sexSkills.titsFuck.last;
            case "sexskills-titsfuck-current":
                return this.sexSkills.titsFuck.current;
            case "sexskills-titsfuck-modifier":
                return this.sexSkills.titsFuck.modifier;
            case "sexskills-touch-min":
                return this.sexSkills.touch.min;
            case "sexskills-touch-max":
                return this.sexSkills.touch.max;
            case "sexskills-touch-start":
                return this.sexSkills.touch.start;
            case "sexskills-touch-last":
                return this.sexSkills.touch.last;
            case "sexskills-touch-current":
                return this.sexSkills.touch.current;
            case "sexskills-touch-modifier":
                return this.sexSkills.touch.modifier;
            case "sexskills-act69-min":
                return this.sexSkills.act69.min;
            case "sexskills-act69-max":
                return this.sexSkills.act69.max;
            case "sexskills-act69-start":
                return this.sexSkills.act69.start;
            case "sexskills-act69-last":
                return this.sexSkills.act69.last;
            case "sexskills-act69-current":
                return this.sexSkills.act69.current;
            case "sexskills-act69-modifier":
                return this.sexSkills.act69.modifier;
            case "skills-dancing-min":
                return this.skills.dancing.min;
            case "skills-dancing-max":
                return this.skills.dancing.max;
            case "skills-dancing-start":
                return this.skills.dancing.start;
            case "skills-dancing-last":
                return this.skills.dancing.last;
            case "skills-dancing-current":
                return this.skills.dancing.current;
            case "skills-dancing-modifier":
                return this.skills.dancing.modifier;
            case "skills-dancing-untilnextlevel":
                return this.skills.dancing.untilNextLevel;
            case "skills-singing-min":
                return this.skills.singing.min;
            case "skills-singing-max":
                return this.skills.singing.max;
            case "skills-singing-start":
                return this.skills.singing.start;
            case "skills-singing-last":
                return this.skills.singing.last;
            case "skills-singing-current":
                return this.skills.singing.current;
            case "skills-singing-modifier":
                return this.skills.singing.modifier;
            case "skills-singing-untilnextlevel":
                return this.skills.singing.untilNextLevel;
            case "skills-swimming-min":
                return this.skills.swimming.min;
            case "skills-swimming-max":
                return this.skills.swimming.max;
            case "skills-swimming-start":
                return this.skills.swimming.start;
            case "skills-swimming-last":
                return this.skills.swimming.last;
            case "skills-swimming-current":
                return this.skills.swimming.current;
            case "skills-swimming-modifier":
                return this.skills.swimming.modifier;
            case "skills-swimming-untilnextlevel":
                return this.skills.swimming.untilNextLevel;
            case "skills-slavetrainer-min":
                return this.skills.slaveTrainer.min;
            case "skills-slavetrainer-max":
                return this.skills.slaveTrainer.max;
            case "skills-slavetrainer-start":
                return this.skills.slaveTrainer.start;
            case "skills-slavetrainer-last":
                return this.skills.slaveTrainer.last;
            case "skills-slavetrainer-current":
                return this.skills.slaveTrainer.current;
            case "skills-slavetrainer-modifier":
                return this.skills.slaveTrainer.modifier;
            case "skills-slavetrainer-untilnextlevel":
                return this.skills.slaveTrainer.untilNextLevel;
            case "skills-likesfemaletrainer-min":
                return this.skills.likesFemaleTrainer.min;
            case "skills-likesfemaletrainer-max":
                return this.skills.likesFemaleTrainer.max;
            case "skills-likesfemaletrainer-start":
                return this.skills.likesFemaleTrainer.start;
            case "skills-likesfemaletrainer-last":
                return this.skills.likesFemaleTrainer.last;
            case "skills-likesfemaletrainer-current":
                return this.skills.likesFemaleTrainer.current;
            case "skills-likesfemaletrainer-modifier":
                return this.skills.likesFemaleTrainer.modifier;
            case "skills-likesfemaletrainer-untilnextlevel":
                return this.skills.likesFemaleTrainer.untilNextLevel;
            case "skills-likesmaletrainer-min":
                return this.skills.likesMaleTrainer.min;
            case "skills-likesmaletrainer-max":
                return this.skills.likesMaleTrainer.max;
            case "skills-likesmaletrainer-start":
                return this.skills.likesMaleTrainer.start;
            case "skills-likesmaletrainer-last":
                return this.skills.likesMaleTrainer.last;
            case "skills-likesmaletrainer-current":
                return this.skills.likesMaleTrainer.current;
            case "skills-likesmaletrainer-modifier":
                return this.skills.likesMaleTrainer.modifier;
            case "skills-likesmaletrainer-untilnextlevel":
                return this.skills.likesMaleTrainer.untilNextLevel;
            case "skills-likesfutatrainer-min":
                return this.skills.likesFutaTrainer.min;
            case "skills-likesfutatrainer-max":
                return this.skills.likesFutaTrainer.max;
            case "skills-likesfutatrainer-start":
                return this.skills.likesFutaTrainer.start;
            case "skills-likesfutatrainer-last":
                return this.skills.likesFutaTrainer.last;
            case "skills-likesfutatrainer-current":
                return this.skills.likesFutaTrainer.current;
            case "skills-likesfutatrainer-modifier":
                return this.skills.likesFutaTrainer.modifier;
            case "skills-likesfutatrainer-untilnextlevel":
                return this.skills.likesFutaTrainer.untilNextLevel;
            case "skills-ponyslavetrainer-min":
                return this.skills.ponySlaveTrainer.min;
            case "skills-ponyslavetrainer-max":
                return this.skills.ponySlaveTrainer.max;
            case "skills-ponyslavetrainer-start":
                return this.skills.ponySlaveTrainer.start;
            case "skills-ponyslavetrainer-last":
                return this.skills.ponySlaveTrainer.last;
            case "skills-ponyslavetrainer-current":
                return this.skills.ponySlaveTrainer.current;
            case "skills-ponyslavetrainer-modifier":
                return this.skills.ponySlaveTrainer.modifier;
            case "skills-ponyslavetrainer-untilnextlevel":
                return this.skills.ponySlaveTrainer.untilNextLevel;
            case "skills-catslavetrainer-min":
                return this.skills.catSlaveTrainer.min;
            case "skills-catslavetrainer-max":
                return this.skills.catSlaveTrainer.max;
            case "skills-catslavetrainer-start":
                return this.skills.catSlaveTrainer.start;
            case "skills-catslavetrainer-last":
                return this.skills.catSlaveTrainer.last;
            case "skills-catslavetrainer-current":
                return this.skills.catSlaveTrainer.current;
            case "skills-catslavetrainer-modifier":
                return this.skills.catSlaveTrainer.modifier;
            case "skills-catslavetrainer-untilnextlevel":
                return this.skills.catSlaveTrainer.untilNextLevel;
            case "skills-dogslavetrainer-min":
                return this.skills.dogSlaveTrainer.min;
            case "skills-dogslavetrainer-max":
                return this.skills.dogSlaveTrainer.max;
            case "skills-dogslavetrainer-start":
                return this.skills.dogSlaveTrainer.start;
            case "skills-dogslavetrainer-last":
                return this.skills.dogSlaveTrainer.last;
            case "skills-dogslavetrainer-current":
                return this.skills.dogSlaveTrainer.current;
            case "skills-dogslavetrainer-modifier":
                return this.skills.dogSlaveTrainer.modifier;
            case "skills-dogslavetrainer-untilnextlevel":
                return this.skills.dogSlaveTrainer.untilNextLevel;
            case "skills-cowslavetrainer-min":
                return this.skills.cowSlaveTrainer.min;
            case "skills-cowslavetrainer-max":
                return this.skills.cowSlaveTrainer.max;
            case "skills-cowslavetrainer-start":
                return this.skills.cowSlaveTrainer.start;
            case "skills-cowslavetrainer-last":
                return this.skills.cowSlaveTrainer.last;
            case "skills-cowslavetrainer-current":
                return this.skills.cowSlaveTrainer.current;
            case "skills-cowslavetrainer-modifier":
                return this.skills.cowSlaveTrainer.modifier;
            case "skills-cowslavetrainer-untilnextlevel":
                return this.skills.cowSlaveTrainer.untilNextLevel;
            case "skills-succubustrainer-min":
                return this.skills.succubusTrainer.min;
            case "skills-succubustrainer-max":
                return this.skills.succubusTrainer.max;
            case "skills-succubustrainer-start":
                return this.skills.succubusTrainer.start;
            case "skills-succubustrainer-last":
                return this.skills.succubusTrainer.last;
            case "skills-succubustrainer-current":
                return this.skills.succubusTrainer.current;
            case "skills-succubustrainer-modifier":
                return this.skills.succubusTrainer.modifier;
            case "skills-succubustrainer-untilnextlevel":
                return this.skills.succubusTrainer.untilNextLevel;
            case "skills-sluttrainer-min":
                return this.skills.slutTrainer.min;
            case "skills-sluttrainer-max":
                return this.skills.slutTrainer.max;
            case "skills-sluttrainer-start":
                return this.skills.slutTrainer.start;
            case "skills-sluttrainer-last":
                return this.skills.slutTrainer.last;
            case "skills-sluttrainer-current":
                return this.skills.slutTrainer.current;
            case "skills-sluttrainer-modifier":
                return this.skills.slutTrainer.modifier;
            case "skills-sluttrainer-untilnextlevel":
                return this.skills.slutTrainer.untilNextLevel;
            case "skills-fairytrainer-min":
                return this.skills.fairyTrainer.min;
            case "skills-fairytrainer-max":
                return this.skills.fairyTrainer.max;
            case "skills-fairytrainer-start":
                return this.skills.fairyTrainer.start;
            case "skills-fairytrainer-last":
                return this.skills.fairyTrainer.last;
            case "skills-fairytrainer-current":
                return this.skills.fairyTrainer.current;
            case "skills-fairytrainer-modifier":
                return this.skills.fairyTrainer.modifier;
            case "skills-fairytrainer-untilnextlevel":
                return this.skills.fairyTrainer.untilNextLevel;
            case "skills-leadership-min":
                return this.skills.leadership.min;
            case "skills-leadership-max":
                return this.skills.leadership.max;
            case "skills-leadership-start":
                return this.skills.leadership.start;
            case "skills-leadership-last":
                return this.skills.leadership.last;
            case "skills-leadership-current":
                return this.skills.leadership.current;
            case "skills-leadership-modifier":
                return this.skills.leadership.modifier;
            case "skills-leadership-untilnextlevel":
                return this.skills.leadership.untilNextLevel;
            case "skills-trader-min":
                return this.skills.trader.min;
            case "skills-trader-max":
                return this.skills.trader.max;
            case "skills-trader-start":
                return this.skills.trader.start;
            case "skills-trader-last":
                return this.skills.trader.last;
            case "skills-trader-current":
                return this.skills.trader.current;
            case "skills-trader-modifier":
                return this.skills.trader.modifier;
            case "skills-trader-untilnextlevel":
                return this.skills.trader.untilNextLevel;
            case "skills-alchemy-min":
                return this.skills.alchemy.min;
            case "skills-alchemy-max":
                return this.skills.alchemy.max;
            case "skills-alchemy-start":
                return this.skills.alchemy.start;
            case "skills-alchemy-last":
                return this.skills.alchemy.last;
            case "skills-alchemy-current":
                return this.skills.alchemy.current;
            case "skills-alchemy-modifier":
                return this.skills.alchemy.modifier;
            case "skills-alchemy-untilnextlevel":
                return this.skills.alchemy.untilNextLevel;
            case "skills-mage-min":
                return this.skills.mage.min;
            case "skills-mage-max":
                return this.skills.mage.max;
            case "skills-mage-start":
                return this.skills.mage.start;
            case "skills-mage-last":
                return this.skills.mage.last;
            case "skills-mage-current":
                return this.skills.mage.current;
            case "skills-mage-modifier":
                return this.skills.mage.modifier;
            case "skills-mage-untilnextlevel":
                return this.skills.mage.untilNextLevel;
            case "skills-refined-min":
                return this.skills.refined.min;
            case "skills-refined-max":
                return this.skills.refined.max;
            case "skills-refined-start":
                return this.skills.refined.start;
            case "skills-refined-last":
                return this.skills.refined.last;
            case "skills-refined-current":
                return this.skills.refined.current;
            case "skills-refined-modifier":
                return this.skills.refined.modifier;
            case "skills-refined-untilnextlevel":
                return this.skills.refined.untilNextLevel;
            case "skills-noble-min":
                return this.skills.noble.min;
            case "skills-noble-max":
                return this.skills.noble.max;
            case "skills-noble-start":
                return this.skills.noble.start;
            case "skills-noble-last":
                return this.skills.noble.last;
            case "skills-noble-current":
                return this.skills.noble.current;
            case "skills-noble-modifier":
                return this.skills.noble.modifier;
            case "skills-noble-untilnextlevel":
                return this.skills.noble.untilNextLevel;
            case "virginity-vaginal":
                return this.virginity.vaginal;
            case "virginity-oral":
                return this.virginity.oral;
            case "virginity-anal":
                return this.virginity.anal;
            case "virginity-cock":
                return this.virginity.cock;
            case "training-likesfemale-trainable":
                return this.training.likesFemale.trainable;
            case "training-likesfemale-isbeingtrained":
                return this.training.likesFemale.isBeingTrained;
            case "training-likesfemale-resistance":
                return this.training.likesFemale.resistance;
            case "training-likesfemale-completion-min":
                return this.training.likesFemale.completion.min;
            case "training-likesfemale-completion-max":
                return this.training.likesFemale.completion.max;
            case "training-likesfemale-completion-start":
                return this.training.likesFemale.completion.start;
            case "training-likesfemale-completion-last":
                return this.training.likesFemale.completion.last;
            case "training-likesfemale-completion-current":
                return this.training.likesFemale.completion.current;
            case "training-likesfemale-completion-modifier":
                return this.training.likesFemale.completion.modifier;
            case "training-likesmale-trainable":
                return this.training.likesMale.trainable;
            case "training-likesmale-isbeingtrained":
                return this.training.likesMale.isBeingTrained;
            case "training-likesmale-resistance":
                return this.training.likesMale.resistance;
            case "training-likesmale-completion-min":
                return this.training.likesMale.completion.min;
            case "training-likesmale-completion-max":
                return this.training.likesMale.completion.max;
            case "training-likesmale-completion-start":
                return this.training.likesMale.completion.start;
            case "training-likesmale-completion-last":
                return this.training.likesMale.completion.last;
            case "training-likesmale-completion-current":
                return this.training.likesMale.completion.current;
            case "training-likesmale-completion-modifier":
                return this.training.likesMale.completion.modifier;
            case "training-likesfuta-trainable":
                return this.training.likesFuta.trainable;
            case "training-likesfuta-isbeingtrained":
                return this.training.likesFuta.isBeingTrained;
            case "training-likesfuta-resistance":
                return this.training.likesFuta.resistance;
            case "training-likesfuta-completion-min":
                return this.training.likesFuta.completion.min;
            case "training-likesfuta-completion-max":
                return this.training.likesFuta.completion.max;
            case "training-likesfuta-completion-start":
                return this.training.likesFuta.completion.start;
            case "training-likesfuta-completion-last":
                return this.training.likesFuta.completion.last;
            case "training-likesfuta-completion-current":
                return this.training.likesFuta.completion.current;
            case "training-likesfuta-completion-modifier":
                return this.training.likesFuta.completion.modifier;
            case "training-ponyslave-trainable":
                return this.training.ponySlave.trainable;
            case "training-ponyslave-isbeingtrained":
                return this.training.ponySlave.isBeingTrained;
            case "training-ponyslave-resistance":
                return this.training.ponySlave.resistance;
            case "training-ponyslave-completion-min":
                return this.training.ponySlave.completion.min;
            case "training-ponyslave-completion-max":
                return this.training.ponySlave.completion.max;
            case "training-ponyslave-completion-start":
                return this.training.ponySlave.completion.start;
            case "training-ponyslave-completion-last":
                return this.training.ponySlave.completion.last;
            case "training-ponyslave-completion-current":
                return this.training.ponySlave.completion.current;
            case "training-ponyslave-completion-modifier":
                return this.training.ponySlave.completion.modifier;
            case "training-catslave-trainable":
                return this.training.catSlave.trainable;
            case "training-catslave-isbeingtrained":
                return this.training.catSlave.isBeingTrained;
            case "training-catslave-resistance":
                return this.training.catSlave.resistance;
            case "training-catslave-completion-min":
                return this.training.catSlave.completion.min;
            case "training-catslave-completion-max":
                return this.training.catSlave.completion.max;
            case "training-catslave-completion-start":
                return this.training.catSlave.completion.start;
            case "training-catslave-completion-last":
                return this.training.catSlave.completion.last;
            case "training-catslave-completion-current":
                return this.training.catSlave.completion.current;
            case "training-catslave-completion-modifier":
                return this.training.catSlave.completion.modifier;
            case "training-dogslave-trainable":
                return this.training.dogSlave.trainable;
            case "training-dogslave-isbeingtrained":
                return this.training.dogSlave.isBeingTrained;
            case "training-dogslave-resistance":
                return this.training.dogSlave.resistance;
            case "training-dogslave-completion-min":
                return this.training.dogSlave.completion.min;
            case "training-dogslave-completion-max":
                return this.training.dogSlave.completion.max;
            case "training-dogslave-completion-start":
                return this.training.dogSlave.completion.start;
            case "training-dogslave-completion-last":
                return this.training.dogSlave.completion.last;
            case "training-dogslave-completion-current":
                return this.training.dogSlave.completion.current;
            case "training-dogslave-completion-modifier":
                return this.training.dogSlave.completion.modifier;
            case "training-cowslave-trainable":
                return this.training.cowSlave.trainable;
            case "training-cowslave-isbeingtrained":
                return this.training.cowSlave.isBeingTrained;
            case "training-cowslave-resistance":
                return this.training.cowSlave.resistance;
            case "training-cowslave-completion-min":
                return this.training.cowSlave.completion.min;
            case "training-cowslave-completion-max":
                return this.training.cowSlave.completion.max;
            case "training-cowslave-completion-start":
                return this.training.cowSlave.completion.start;
            case "training-cowslave-completion-last":
                return this.training.cowSlave.completion.last;
            case "training-cowslave-completion-current":
                return this.training.cowSlave.completion.current;
            case "training-cowslave-completion-modifier":
                return this.training.cowSlave.completion.modifier;
            case "training-succubus-trainable":
                return this.training.succubus.trainable;
            case "training-succubus-isbeingtrained":
                return this.training.succubus.isBeingTrained;
            case "training-succubus-resistance":
                return this.training.succubus.resistance;
            case "training-succubus-completion-min":
                return this.training.succubus.completion.min;
            case "training-succubus-completion-max":
                return this.training.succubus.completion.max;
            case "training-succubus-completion-start":
                return this.training.succubus.completion.start;
            case "training-succubus-completion-last":
                return this.training.succubus.completion.last;
            case "training-succubus-completion-current":
                return this.training.succubus.completion.current;
            case "training-succubus-completion-modifier":
                return this.training.succubus.completion.modifier;
            case "training-slut-trainable":
                return this.training.slut.trainable;
            case "training-slut-isbeingtrained":
                return this.training.slut.isBeingTrained;
            case "training-slut-resistance":
                return this.training.slut.resistance;
            case "training-slut-completion-min":
                return this.training.slut.completion.min;
            case "training-slut-completion-max":
                return this.training.slut.completion.max;
            case "training-slut-completion-start":
                return this.training.slut.completion.start;
            case "training-slut-completion-last":
                return this.training.slut.completion.last;
            case "training-slut-completion-current":
                return this.training.slut.completion.current;
            case "training-slut-completion-modifier":
                return this.training.slut.completion.modifier;
            case "training-fairy-trainable":
                return this.training.fairy.trainable;
            case "training-fairy-isbeingtrained":
                return this.training.fairy.isBeingTrained;
            case "training-fairy-resistance":
                return this.training.fairy.resistance;
            case "training-fairy-completion-min":
                return this.training.fairy.completion.min;
            case "training-fairy-completion-max":
                return this.training.fairy.completion.max;
            case "training-fairy-completion-start":
                return this.training.fairy.completion.start;
            case "training-fairy-completion-last":
                return this.training.fairy.completion.last;
            case "training-fairy-completion-current":
                return this.training.fairy.completion.current;
            case "training-fairy-completion-modifier":
                return this.training.fairy.completion.modifier;
            case "training-courtesan-trainable":
                return this.training.courtesan.trainable;
            case "training-courtesan-isbeingtrained":
                return this.training.courtesan.isBeingTrained;
            case "training-courtesan-resistance":
                return this.training.courtesan.resistance;
            case "training-courtesan-completion-min":
                return this.training.courtesan.completion.min;
            case "training-courtesan-completion-max":
                return this.training.courtesan.completion.max;
            case "training-courtesan-completion-start":
                return this.training.courtesan.completion.start;
            case "training-courtesan-completion-last":
                return this.training.courtesan.completion.last;
            case "training-courtesan-completion-current":
                return this.training.courtesan.completion.current;
            case "training-courtesan-completion-modifier":
                return this.training.courtesan.completion.modifier;
            case "owner-isowned":
                return this.owner.isOwned;
            case "owner-testing":
                return this.owner.testing;
            case "owner-testingurgent":
                return this.owner.testingUrgent;
            case "owner-owneridcurrent":
                return this.owner.ownerIDcurrent;
            case "owner-owneridprevious":
                return this.owner.ownerIDprevious;
            case "owner-ownername":
                return this.owner.ownerName;
            case "owner-ownerpath":
                return this.owner.ownerPath;
            case "father-id":
                return this.father.ID;
            case "father-raceid":
                return this.father.raceID;
            case "father-nameof-first":
                return this.father.nameOf.first;
            case "father-nameof-middle":
                return this.father.nameOf.middle;
            case "father-nameof-last":
                return this.father.nameOf.last;
            case "father-nameof-prefix":
                return this.father.nameOf.prefix;
            case "father-nameof-title":
                return this.father.nameOf.title;
            case "father-nameof-nickname":
                return this.father.nameOf.nickname;
            case "father-nameof-slavename":
                return this.father.nameOf.slavename;
            case "father-nameof-nameborn":
                return this.father.nameOf.nameBorn;
            case "mother-id":
                return this.mother.ID;
            case "mother-raceid":
                return this.mother.raceID;
            case "mother-nameof-first":
                return this.mother.nameOf.first;
            case "mother-nameof-middle":
                return this.mother.nameOf.middle;
            case "mother-nameof-last":
                return this.mother.nameOf.last;
            case "mother-nameof-prefix":
                return this.mother.nameOf.prefix;
            case "mother-nameof-title":
                return this.mother.nameOf.title;
            case "mother-nameof-nickname":
                return this.mother.nameOf.nickname;
            case "mother-nameof-slavename":
                return this.mother.nameOf.slavename;
            case "mother-nameof-nameborn":
                return this.mother.nameOf.nameBorn;
            default:
                return null;
        }
    }

}

public struct CharacterName
{				// example Magical Girl Miss Illya von Einzbern, 
	public string first;					// Illya
	public string middle;					// von
	public string last;						// Einzbern
	public string prefix;					// Miss
	public string title;					// Magicl Girl
	public string nickname;					// Kuros mana supply
	public string slavename;				// none, she isnt enslaved
	public string nameBorn;					// Illya von Einzbern (aka, she hasnt married)
}

public struct Gender
{
	public int current;
	public int last;
	public int born;
}

public struct BasicSize
{
	public float current;
	public float last;

}

public struct MediumSize
{
	public float min;
	public float max;
	public float start;
	public float last;
	public float current;
}

public struct StatBase
{
	public float min;
	public float max;
	public float start;
	public float last;
	public float current;
	public float modifier;
}
public struct SkillBase
{
	public int min;
	public int max;
	public int start;
	public int last;
	public int current;
	public int modifier;
	public float untilNextLevel;
}

public struct Cock
{
	public bool hasCock;
    public MediumSize size; 	// cock size , max 60cm
    public MediumSize grid;		// cock grid
    public float type;			// 0 human, 1 knotted, ...for human, feline, canine, equine
    public MediumSize typeVar;	// referes to a special size of the cock
    							// like knotsize, barbsizes, or whatever peculiarity the cock should have
}

public struct Cum
{
	public MediumSize volume;
	public float fertility;		// fertility 0 = 0%, 1 = 100%
}

public struct GeneralCharacter
{			// variables that dont have a place
	
	public bool sexActsOK; 		// are sex acts permitted via contract
	public int birthday;
	public int age;

	public string description;  // her short description "angry girl' etc

	public int goldEarned;
	public int goldOwned;
	
	public int badGirl;			// 0 she has not been bad, +1 for each bad action
	public int behaving;		// x > 0, she is obedient
								// raised by spanking. decreases each day
	public int loyalty;			// ?????
	public int attitude;		// 0 = normal, 1 = sexy, 2 = angry, 3 = heroine, 4 = scared, 5 = slut
	public int loveAccepted;	// -1 will never confess, 0 not confessed, 1 accepted confession, 2 refused confession outright, 3 asked for time to think

	public bool isNaked;		// is character wearing clothes
	public bool loli;			// is it a loli or shouta
	public int noble;			// 0 commoner, 1 minor noble, 2 noble, 3 major noble, 4 lord
}

public struct Vitals
{  			// all units are in kg(mass), cm(size) and ml(volume)
    // body demensions --------------------------------------------------------------
    public float height;
    public float weight;

    public MediumSize bust; 	// max 300cm
    public float underBustSize; 	// look up how BH sizes work if you dont get what this is for
    						  	// tldr: bust-underBustSize determites how large the breast are
    public MediumSize aurola;	// aurola size in cm
    public string cupSize;		// european cup sizes

    public Cock cock;			// cock variables
    public MediumSize testicles;// testicle size
    public Cum cum;		// cumvolume
    
    public MediumSize clit; 	// clit size, max 3cm
    
    public bool hasPussy;
    public MediumSize pussy; 	// depth of pussy
    public MediumSize pussyGrid;// how wide can the pussy strech
    
    public MediumSize waist; 
    public MediumSize throat; 	// depth of throat
    
    public string bloodType; 	// blood type A, B, O, AB, but you can insert anything
}

public struct TextInserts
{ 		// things to get for text inserts
	public string itHeShe;
	public string itHimHer;
	public string itsHisHer;
}

public struct Stats
{
	// A
		public StatBase agility;
	// B
		public StatBase blowjob; 		// Oral skills
	// C
		public StatBase charisma;		//
		public StatBase corruption;		// influences your dark magic power
		public StatBase constitution;	// 0 means dead
		public StatBase cooking;
		public StatBase cleaning;
		public StatBase conversation;	// 0 means unable to speak
	// D
		public StatBase dominance;
		public StatBase dexterity;
	// E
	// F
		public StatBase fuck; 			// Anal and Vaginal Skills
	// G
	// H
	// I
		public StatBase intelligence;	// decides your mana and learining capacity
	// J
		public StatBase joy;			// damages Mind if low
										// gives bonus to learning if high
	// K
	// L
		public StatBase libido;
		public StatBase love;			// love towards SlaveMaker
	// M 
		public StatBase mind;			// integrety of ones mind
										//decreases with trauma and low Joy. Constatn sex orgy hell, extreme bondadge, constantly locked in
										// has a daily regeneration + factor by Joy
										// if it hits 0 then mind break and regen stops
		public StatBase morality;		
	// N
		public StatBase nymphomania;	// slaanesh grants you bonus arousal damage
	// O
		public StatBase obedience;
	// P
	// Q
	// R
		public StatBase refinement;
		public StatBase reputation;
	// S
		public StatBase sensibility;
		public StatBase strenght;
		public StatBase submission;
	// T
		public StatBase temperament;
		public StatBase tiredness;
	// U
	// V
	// W
	// X
	// Y
	// Z
}

public struct SexSkills
{

	// A
		public StatBase anal;
	// B
		public StatBase blowjob;
		public StatBase bondage;
	// C
		public StatBase cumBath;
	// D
		public StatBase dildo;
	// E
	// F
		public StatBase fuck;
	// G
		public StatBase gangBang;
		public StatBase group;
	// H
	// I
	// J
	// K
		public StatBase kiss;
	// L
		public StatBase lendHer;
		public StatBase lesbian;
		public StatBase lick;
	// M 
		public StatBase masturbate;
	// N
		public StatBase naked;
	// O
	// P
		public StatBase plug;
	// Q
	// R
	// S
		public StatBase spank;
		public StatBase stripTease;
	// T
		public StatBase threesome;
		public StatBase titsFuck;
		public StatBase touch;
	// U
	// V
	// W
	// X
	// Y
	// Z
	// Num
		public StatBase act69;
}

public struct Skills
{
	public SkillBase dancing;
	public SkillBase singing;
	public SkillBase swimming;
	public SkillBase slaveTrainer;
	public SkillBase likesFemaleTrainer;
	public SkillBase likesMaleTrainer;
	public SkillBase likesFutaTrainer;
	public SkillBase ponySlaveTrainer;
	public SkillBase catSlaveTrainer;
	public SkillBase dogSlaveTrainer;
	public SkillBase cowSlaveTrainer;
	public SkillBase succubusTrainer;
	public SkillBase slutTrainer;
	public SkillBase fairyTrainer;

	public SkillBase leadership;
	public SkillBase trader;
	public SkillBase alchemy;
	public SkillBase mage;
	public SkillBase refined;
	public SkillBase noble;

}

public struct Viginity
{
	public bool vaginal;
	public bool oral;
	public bool anal;
	public bool cock;
}

public struct Training
{
	public bool trainable;			// can she be trained for this
	public bool isBeingTrained;		// is she being trained?
	public int resistance;			// how easy is it to train her
									// SMTrainerLevel has to be higher than her resistance to train her in it
									// 0 will always train, 3 high resistance, 4 never(dont use pls)
	public StatBase completion;		// from 0 to 100, how much of the training is complete
}

public struct TrainingTypes
{
	public Training likesFemale;
	public Training likesMale;
	public Training likesFuta;
	public Training ponySlave;
	public Training catSlave;
	public Training dogSlave;
	public Training cowSlave;
	public Training succubus;
	public Training slut;			// 60+ she is a slut, Nymphomania always 50+
	public Training fairy;		
	public Training courtesan;	
}

public struct Owner
{
	public bool isOwned;			// is the character owned?
	public bool testing;			//true = her owner will visit every 7 days and test her.
	public bool testingUrgent;		// owner comes when SM is at home the next time (morning or evening)
	public int ownerIDcurrent;		// who is the owner, preferebly the owner is added as a npc to the game
									// -1 for free person, 0 for unknown
	public int ownerIDprevious;
	public string ownerName;		// Owner name, for generic owners
	public string ownerPath;		// file path to images for generic owners

}

public struct Rules
{
	public bool talk;
	public bool fuck;
	public bool goOut;
	public bool touchThemself;
	public bool writeLetters;
	public bool poketMoney;
	public bool pray;
}

public struct CombatStats
{
	public CombatProficiency proficiency;
	public int weaponID;
	public CombatProficiency damage;
	public CombatProficiency resistance;
	public int fightsNumber;
	public int fightsVictory;
	public int fightsLosses;
	public int kills;
	public int exp;

}

public struct CombatProficiency
{
	public SkillBase sword;
	public SkillBase axe;
	public SkillBase spear;
	public SkillBase bow;
	public SkillBase magicIce;
	public SkillBase magicFire;
	public SkillBase magicThunder;
	public SkillBase magicLight;
	public SkillBase magicDark;
	public SkillBase armor;
	public SkillBase whip;
	public SkillBase unarmed;
	public SkillBase arousal;
}

public struct Parentclass
{
	public int ID;
	public int raceID;
	public CharacterName nameOf;
}