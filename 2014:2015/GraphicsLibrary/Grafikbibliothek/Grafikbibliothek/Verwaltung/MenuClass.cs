﻿using System;

namespace Grafikbibliothek
{
	public class MenuClass
	{
		bool repeat = false;

		public MenuClass ()
		{
		}

		public int showMenu(){
			do {
				try{
					Console.Clear ();
					Console.WriteLine ("\tGraphikbibliothek\t");
					Console.WriteLine ("0 ... Ende");
					Console.WriteLine ("1 ... Neues Objekt anlegen");
					Console.WriteLine ("2 ... Vorhandenes Objekt bearbeiten");
					Console.WriteLine ("3 ... Vorhandenes Objekt löschen");
					Console.WriteLine ("4 ... Bestimmtes Objekt ausgeben");
					Console.WriteLine ("5 ... Alle ausgeben");

					repeat = false;

					return int.Parse (Console.ReadLine ());

				}catch(Exception){
					repeat = true;
				}
			} while(repeat == true);

			return 0;
		}

		public int showCreationMenu(){
			do {
				try{
					Console.Clear ();
					Console.WriteLine ("\tWas möchten Sie erstellen?\t");
					Console.WriteLine ("1 ... Linie");
					Console.WriteLine ("2 ... Rechteck");
					Console.WriteLine ("3 ... Kreis");
					Console.WriteLine ("4 ... Quadrat");

					repeat = false;

					return int.Parse (Console.ReadLine ());
				}catch(TestException t){
					Console.WriteLine (t.ToString());
					repeat = true;
				}
			} while(repeat == true);

			return 0;
		}

		public int showEditMenu(){
			do {
				try{
					Console.Clear ();
					Console.WriteLine ("\tWas möchten Sie editieren?\t");
					Console.WriteLine ("1 ... Form ändern");
					Console.WriteLine ("2 ... Koordinaten verändern (bewegen)");

					repeat = false;

					return int.Parse (Console.ReadLine ());
				}catch(Exception){
					repeat = true;
				}
			} while(repeat == true);

			return 0;
		}

		public int showMorphMenu(){
			do {
				try {
					Console.Clear ();
					Console.WriteLine ("\tWas möchten Sie aus dem Objekt machen?\t");
					Console.WriteLine ("1 ... Linie");
					Console.WriteLine ("2 ... Rechteck");
					Console.WriteLine ("3 ... Kreis");
					Console.WriteLine ("4 ... Quadrat");

					repeat = false;

					return int.Parse (Console.ReadLine ());
				} catch (Exception) {
					repeat = true;
				}
			} while(repeat == true);

			return 0;
		}
	}
}

