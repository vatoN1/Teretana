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

public class TrajnaUsluga : Usluga
{
    public TrajnaUsluga() { }
    public TipClanarine Clanarina
	{
		get;
		set;
    }

    public global::PrehrambeniProgram PrehrambeniProgram
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
        }
    }

    public global::WorkoutProgram WorkoutProgram
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
        }
    }

	public virtual void produziClanarinu()
	{
		throw new System.NotImplementedException();
	}

	public virtual void okoncajUslugu()
	{
		throw new System.NotImplementedException();
	}
}

