﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Monsters : DBTable
{
	private int monster_id
	{
		get;
		set;
	}

	private int monster_family_id
	{
		get;
		set;
	}

	public virtual string name
	{
		get;
		set;
	}

	public virtual string altname
	{
		get;
		set;
	}

	private int size_id
	{
		get;
		set;
	}

	private int type_id
	{
		get;
		set;
	}

	private int descriptor_id
	{
		get;
		set;
	}

	public virtual string hit_dice
	{
		get;
		set;
	}

	public virtual string initiative
	{
		get;
		set;
	}

	public virtual string speed
	{
		get;
		set;
	}

	public virtual string armor_class
	{
		get;
		set;
	}

	public virtual int base_attack
	{
		get;
		set;
	}

	public virtual int grapple
	{
		get;
		set;
	}

	public virtual string attack
	{
		get;
		set;
	}

	public virtual string full_attack
	{
		get;
		set;
	}

	public virtual string space
	{
		get;
		set;
	}

	public virtual string reach
	{
		get;
		set;
	}

	public virtual string special_attacks
	{
		get;
		set;
	}

	public virtual string special_qualities
	{
		get;
		set;
	}

	public virtual string saves
	{
		get;
		set;
	}

	public virtual string abilities
	{
		get;
		set;
	}

	public virtual string skills
	{
		get;
		set;
	}

	public virtual string bonus_feats
	{
		get;
		set;
	}

	public virtual string feats
	{
		get;
		set;
	}

	public virtual string epic_feats
	{
		get;
		set;
	}

	public virtual string environment
	{
		get;
		set;
	}

	public virtual string organization
	{
		get;
		set;
	}

	public virtual string challenge_rating
	{
		get;
		set;
	}

	public virtual string treasure
	{
		get;
		set;
	}

	public virtual string alignment
	{
		get;
		set;
	}

	public virtual string advancement
	{
		get;
		set;
	}

	public virtual string level_adjustment
	{
		get;
		set;
	}

	public virtual string special_abilities
	{
		get;
		set;
	}

	public virtual string stat_block
	{
		get;
		set;
	}

	public virtual string full_text
	{
		get;
		set;
	}

	internal virtual string FIELD
	{
		get;
		set;
	}

	internal virtual string FIELD_LIST
	{
		get;
		set;
	}

	internal virtual string TABLE
	{
		get;
		set;
	}

	public virtual void delete(int Key)
	{
		throw new System.NotImplementedException();
	}

	public virtual Monsters retrieve(int Key)
	{
		throw new System.NotImplementedException();
	}

	public virtual void save(int Key)
	{
		throw new System.NotImplementedException();
	}

}

