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

public class Monster_families : DBTable_lookup
{
	private int family_id
	{
		get;
		set;
	}

	public virtual string name
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

	public virtual Monsters monsters
	{
		get;
		set;
	}

	public virtual void delete(int Key)
	{
		throw new System.NotImplementedException();
	}

	public virtual Monster_families retrieve(int Key)
	{
		throw new System.NotImplementedException();
	}

	public virtual void save(int Key)
	{
		throw new System.NotImplementedException();
	}

}

