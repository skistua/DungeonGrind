using UnityEngine;
using System.Collections;

public class Item {
	
	private string  _name;
	private bool    _isCraftable;
	private bool    _isUnlocked;
	private string  _recipe;
	private int     _maxStack = 1;
	private int     _nbrCrafted = 0;
	private Texture _ItemTexture;
	
	
	public string Name
	{
		get {return _name; }
		set {_name = value; }
	}
	
	public bool IsCraftable
	{
		get {return _isCraftable; }
		set {_isCraftable = value; }
	}
	
	public bool IsUnlocked
	{
		get {return _isUnlocked; }
		set {_isUnlocked = value; }
	}
	
	public string Recipe
	{
		get {return _recipe; }
		set {_recipe = value; }
	}
	
	public int MaxStack
	{
		get {return _maxStack; }
		set {_maxStack = value; }
	}
	
	public int NbrCrafted
	{
		get {return _nbrCrafted; }
		set {_nbrCrafted = value; }
	}
	
	public Texture ItemTexture
	{
		get {return _ItemTexture; }
		set {_ItemTexture = value; }
	}
}

// Enumeration of all Compound
public enum ItemName {
	None,
	Hammer,
	RockSword,
	RockAxe,
	RockPickaxe,
	GoldSword,
	GoldAxe,
	GoldPickaxe
}