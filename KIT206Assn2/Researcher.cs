using System;
using System.Collections.Generic;
using System.Text;

namespace KIT206Assn2
{
    public enum Campus { Hobart, Launcestion, CradleCoast};
    public enum Title { Mr, Miss, Mrs, Ms, Mx, Dr}
    public enum CurrentJobTitle { PostDoc, Lecturer, SeniorLecturer, AssociateProfessor, Professor}


    public class Researcher
    {

        public int id { get; set; }
        public String givenName { get; set; }
        public String familyName { get; set; }
        public String school { get; set; } 
        public String unit { get; set; }
        public double tenure { get; set; }


        /*need to work out if we want to store all the publications in the researcher as objects or as a list of names
         storing them as objects means we will have to load up all the information for all the publications for all researchers on startup
         as opposed to just loading in the publications when a researcher is 
         */
        public List<String> publications { get; set; }


        public Campus campus { get; set; }
        public Title title { get; set; }
        public CurrentJobTitle currentJobTitle { get; set; }
        public String photo { get; set; } //its a url, might be a different way to store it but string will work for now
        public Position Position { get; set; }
        
    }
}
