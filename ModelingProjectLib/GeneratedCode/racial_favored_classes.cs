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

public class Racial_favored_classes : DBTable_bridge
{
	private int race_id
	{
		get;
		set;
	}

	private int class_id
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

	public virtual Races races
	{
		get;
		set;
	}

	public virtual Classes Classes
	{
		get;
		set;
	}

	public virtual void delete(int Key)
	{
		throw new System.NotImplementedException();
	}

	public virtual Domains retrieve(int Key)
	{
		throw new System.NotImplementedException();
	}

	public virtual void save(int Key)
	{
		throw new System.NotImplementedException();
	}

}

