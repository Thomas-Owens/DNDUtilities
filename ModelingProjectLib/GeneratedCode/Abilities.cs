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

public class Abilities : DBTable_lookup
{
	private int ability_id
	{
		get;
		set;
	}

	public virtual string name
	{
		get;
		set;
	}

	public virtual string abbreviation
	{
		get;
		set;
	}

	internal virtual const string TABLE
	{
		get;
		set;
	}

	internal virtual const string FIELD1
	{
		get;
		set;
	}

	public virtual Classes classes
	{
		get;
		set;
	}

	public virtual Abilities retrieveRecord(int Key)
	{
		throw new System.NotImplementedException();
	}

	public virtual List<NameKey> retrieveAll()
	{
		throw new System.NotImplementedException();
	}

	public virtual string ToString()()
	{
		throw new System.NotImplementedException();
	}

}

