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
    public Sprava() { }

    public Sprava(int p1, string p2, int p3, int p4) // UREDITI PO NAMJENI (FROM BASE ITD)
    {
        // TODO: Complete member initialization
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
        this.p4 = p4;
    }
    int id;
    private int p1;
    private string p2;
    private int p3;
    private int p4;

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

    public int Starost
	{
		get;
		set;
	}

}

