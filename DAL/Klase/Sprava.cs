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

public class Sprava : Inventar
{
    String tipSpraveS;
    int id;
    public Sprava() { }

    public Sprava(int id, string tipSprave, int starost, int kolicina) : base(kolicina)
    {
        // TODO: Complete member initialization
        Id = id;
        TipSpraveS = tipSprave;
        Starost = starost;
    }
    
    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public TipSprave TipSprave
	{
		get;
		set;
	}
    public String TipSpraveS
    {
        get { return tipSpraveS; }
        set { tipSpraveS = value; }
    }
    public int Starost
	{
		get;
		set;
	}

}

