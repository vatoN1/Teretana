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

public class Prostorija
{
    int id;
    String tipProstorije;
    String dostupnost;
    String inventar;
    public Prostorija(int id, String dostupnost, String tipProstorije, String inventar)
    {
        Id = id;
        TipProstorije = tipProstorije;
        Dostupnost = dostupnost;
        Inventar1 = inventar;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public String Inventar1
    {
        get { return inventar; }
        set { inventar = value; }
    }
    public String Dostupnost
    {
        get { return dostupnost; }
        set { dostupnost = value; }
    }
    public String TipProstorije
    {
        get { return tipProstorije; }
        set { tipProstorije = value; }
    }
    public TipProstorije NazivProstorije
	{
		get;
		set;
	}
    public List<Inventar> Inventar
    {
        get
        {
            throw new System.NotImplementedException();
        }
        set
        {
        }
    }



}

