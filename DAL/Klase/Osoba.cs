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

public abstract class Osoba
{

    public Osoba(int id, string ime, string prezime, string spol, DateTime datumrodjenja, string kontakt)
    {
        ID = id;
        Ime = ime;
        Prezime = prezime;
        if (spol == "Musko") Spol = Spol.Musko;
        else Spol = Spol.Zensko;
        DatumRodjenja = datumrodjenja;
        Kontakt = kontakt;
    }

    public Osoba() { }
    public DateTime DatumRodjenja
	{
		get;
		set;
	}

    public int ID
    {
        get;
        set;
    }

    public string Ime
	{
		get;
		set;
	}

    public string Prezime
	{
		get;
		set;
	}

    public Spol Spol
	{
		get;
		set;
	}

    public string Kontakt
    {
        get;

        //throw new System.NotImplementedException();

        set;


    }

}

